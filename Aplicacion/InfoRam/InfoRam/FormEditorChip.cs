using InfoRam.Dibujable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InfoRam
{
    public partial class FormEditorChip : Form
    {
        CPad PadSeleccionado = null;
        private sealed class MascaraArchivo
        {
            public string Nombre { get; set; } = string.Empty;
            public int Columnas { get; set; }
            public int Filas { get; set; }
            public List<PadArchivo?> Pads { get; set; } = new List<PadArchivo?>();
        }

        private sealed class PadArchivo
        {
            public int Fila { get; set; }
            public int Columna { get; set; }
            public bool Visible { get; set; }
            public string Nombre { get; set; }
            public string ValorVoltaje { get; set; }
            public string ValorDiodos { get; set; }
        }

        public FormEditorChip()
        {
            InitializeComponent();
        }

        private void BtnSelMascara_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Filter = "Archivos mascara (*.mascara)|*.mascara|Todos los archivos (*.*)|*.*",
                Title = "Abrir máscara"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                string contenido = File.ReadAllText(dialogo.FileName);
                MascaraArchivo? mascara = JsonSerializer.Deserialize<MascaraArchivo>(contenido);
                bool[] visibilidad = ValidaMascara(mascara);

                cChip31.Filas = mascara!.Filas;
                cChip31.Columnas = mascara.Columnas;
                cChip31.EstableceVisibilidadPads(visibilidad);
            }
            catch (Exception excepcion) when (excepcion is IOException ||
                                               excepcion is JsonException ||
                                               excepcion is InvalidDataException ||
                                               excepcion is ArgumentException)
            {
                MessageBox.Show(
                    this,
                    $"No se pudo abrir la máscara:\n{excepcion.Message}",
                    "Abrir máscara",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static bool[] ValidaMascara(MascaraArchivo? mascara)
        {
            if (mascara == null || string.IsNullOrWhiteSpace(mascara.Nombre) ||
                mascara.Filas <= 0 || mascara.Columnas <= 0)
            {
                throw new InvalidDataException("El archivo no contiene una máscara válida.");
            }

            long cantidadPadsLong = (long)mascara.Filas * mascara.Columnas;
            if (cantidadPadsLong > int.MaxValue)
            {
                throw new InvalidDataException("Las dimensiones de la máscara son demasiado grandes.");
            }

            int cantidadPads = (int)cantidadPadsLong;
            if (mascara.Pads == null || mascara.Pads.Count != cantidadPads)
            {
                throw new InvalidDataException("El archivo no contiene todos los pads de la máscara.");
            }

            bool[] visibilidad = new bool[cantidadPads];
            bool[] padDefinido = new bool[cantidadPads];

            foreach (PadArchivo? pad in mascara.Pads)
            {
                if (pad == null || pad.Fila < 0 || pad.Fila >= mascara.Filas ||
                    pad.Columna < 0 || pad.Columna >= mascara.Columnas)
                {
                    throw new InvalidDataException("El archivo contiene un pad fuera de los límites de la máscara.");
                }

                int indice = pad.Fila * mascara.Columnas + pad.Columna;
                if (padDefinido[indice])
                {
                    throw new InvalidDataException("El archivo contiene pads duplicados.");
                }

                padDefinido[indice] = true;
                visibilidad[indice] = pad.Visible;
            }

            return visibilidad;
        }

        private void FormEditorChip_Load(object sender, EventArgs e)
        {
            ComboOpciones.SelectedIndex = 0;
        }

        private void ComboOpciones_Click(object sender, EventArgs e)
        {
            cChip31.MostrarNVD = ComboOpciones.SelectedIndex;
            cChip31.Invalidate();
        }

        private void cChip31_OnPadClick(InfoRam.Dibujable.CPad pad)
        {
            PadSeleccionado = pad;
            txtPad.Text = PadSeleccionado.Nombre;
            txtValor.Text = PadSeleccionado.DameValor();
            txtValor.Focus();
            txtValor.SelectAll();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (PadSeleccionado == null)
            {
                return;
            }
            ;
            switch (ComboOpciones.SelectedIndex)
            {
                case 0:
                    //cChip31.CambiaNombrePad(txtPad.Text, txtValor.Text);
                    PadSeleccionado.Nombre = txtValor.Text;
                    break;
                case 1:
                    //cChip31.AsignaVoltaje(txtPad.Text, txtValor.Text);
                    PadSeleccionado.ValorVoltaje = txtValor.Text;
                    break;
                case 2:
                    //cChip31.AsignaDiodo(txtPad.Text, txtValor.Text);
                    PadSeleccionado.ValorDiodos = txtValor.Text;
                    break;
            }
            cChip31.Invalidate();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialogo = new SaveFileDialog
            {
                Filter = "Archivos chip (*.chip)|*.chip|Todos los archivos (*.*)|*.*",
                DefaultExt = "chip",
                AddExtension = true,
                FileName = NombreArchivo(txtNombreChip.Text),
                Title = "Guardar máscara"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                MascaraArchivo mascara = new MascaraArchivo
                {
                    Nombre = txtNombreChip.Text,
                    Filas = cChip31.Filas,
                    Columnas = cChip31.Columnas
                };
                bool[] visibilidad = cChip31.ObtieneVisibilidadPads();
                for (int fila = 0; fila < mascara.Filas; fila++)
                {
                    for (int columna = 0; columna < mascara.Columnas; columna++)
                    {
                        CPad pad = cChip31.GetPad(fila * mascara.Columnas + columna);
                        mascara.Pads.Add(new PadArchivo
                        {
                            Fila = fila,
                            Columna = columna,
                            Visible = visibilidad[fila * mascara.Columnas + columna],
                            Nombre = pad.Nombre,
                            ValorVoltaje = pad.ValorVoltaje,
                            ValorDiodos = pad.ValorDiodos

                        });
                    }
                }

                //                string contenido = JsonSerializer.Serialize(cChip31.getMascara(), new JsonSerializerOptions
                string contenido = JsonSerializer.Serialize(mascara, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(dialogo.FileName, contenido);
            }
            catch (IOException excepcion)
            {
                MessageBox.Show(this, $"No se pudo guardar la máscara:\n{excepcion.Message}", "Guardar máscara", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static string NombreArchivo(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "mascara.chip";
            }

            foreach (char caracter in Path.GetInvalidFileNameChars())
            {
                nombre = nombre.Replace(caracter, '_');
            }

            return Path.ChangeExtension(nombre, ".chip");
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAplicar_Click(null, null);
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Filter = "Archivos CHIP (*.chip)|*.chip|Todos los archivos (*.*)|*.*",
                Title = "Abrir máscara"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                string contenido = File.ReadAllText(dialogo.FileName);
                MascaraArchivo? mascara = JsonSerializer.Deserialize<MascaraArchivo>(contenido);
                bool[] visibilidad = ValidaMascara(mascara);

                txtNombreChip.Text = mascara!.Nombre;
                //TFilas.Value = 
                //TColunmas.Value = 
                cChip31.Filas = mascara!.Filas;
                cChip31.Columnas = mascara.Columnas;
                cChip31.reajustaPads();
                cChip31.EstableceVisibilidadPads(visibilidad);
                //asigno los valores de nombre, voltaje y diodos a cada pad
                int indice = 0;
                foreach (PadArchivo? pad in mascara.Pads)
                {
                    CPad padChip = cChip31.GetPad(indice);
                    padChip.Nombre = pad.Nombre;
                    padChip.ValorVoltaje = pad.ValorVoltaje;
                    padChip.ValorDiodos = pad.ValorDiodos;
                    indice++;
                }
                cChip31.Invalidate();
            }
            catch (Exception excepcion) when (excepcion is IOException || excepcion is JsonException || excepcion is InvalidDataException || excepcion is ArgumentException)
            {
                MessageBox.Show(this, $"No se pudo abrir la máscara:\n{excepcion.Message}", "Abrir máscara", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreChip.Clear();
            txtPad.Clear();
            txtValor.Clear();
            cChip31.RestablecePads();
        }
    }
}
