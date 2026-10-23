using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace InfoRam
{
    public partial class FormEditorMascara : Form
    {
        private sealed class MascaraArchivo
        {
            public string Nombre { get; set; } = string.Empty;
            public int Columnas { get; set; }
            public int Filas { get; set; }
            public List<PadArchivo> Pads { get; set; } = new List<PadArchivo>();
        }

        private sealed class PadArchivo
        {
            public int Fila { get; set; }
            public int Columna { get; set; }
            public bool Visible { get; set; }
        }

        public FormEditorMascara()
        {
            InitializeComponent();
        }
        private void DibujaMascara()
        {
            // Aquí puedes agregar el código para dibujar la máscara en el formulario
            // Por ejemplo, podrías usar Graphics para dibujar formas o imágenes
            int filas = (int)TFilas.Value;
            int columnas = (int)TColunmas.Value;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Dibuja un rectángulo en la posición (i, j)
                    // Puedes ajustar el tamaño y la posición según tus necesidades
                    int x = j * 20; // Ajusta el tamaño del rectángulo
                    int y = i * 20; // Ajusta el tamaño del rectángulo
                    this.CreateGraphics().DrawRectangle(Pens.Black, x, y, 20, 20);
                }
            }
        }

        private void controlDibujable1_Click(object sender, EventArgs e)
        {

        }

        private void TFilas_ValueChanged(object sender, EventArgs e)
        {
            controlDibujable1.Filas = (int)TFilas.Value;
        }

        private void TColumnas_ValueChanged(object sender, EventArgs e)
        {
            controlDibujable1.Columnas = (int)TColunmas.Value;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 

            float zoom = float.Parse(comboBox1.SelectedItem.ToString());
            controlDibujable1.Zoom= zoom;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            TFilas.Value = 10;
            TColunmas.Value = 10;
            controlDibujable1.RestableceVisibilidadPads();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Filter = "Archivos MASCARA (*.mascara)|*.mascara|Todos los archivos (*.*)|*.*",
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

                textBox1.Text = mascara!.Nombre;
                TFilas.Value = mascara.Filas;
                TColunmas.Value = mascara.Columnas;
                controlDibujable1.EstableceVisibilidadPads(visibilidad);
            }
            catch (Exception excepcion) when (excepcion is IOException || excepcion is JsonException || excepcion is InvalidDataException || excepcion is ArgumentException)
            {
                MessageBox.Show(this, $"No se pudo abrir la máscara:\n{excepcion.Message}", "Abrir máscara", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialogo = new SaveFileDialog
            {
                Filter = "Archivos MASCARA (*.mascara)|*.mascara|Todos los archivos (*.*)|*.*",
                DefaultExt = "mascara",
                AddExtension = true,
                FileName = NombreArchivo(textBox1.Text),
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
                    Nombre = textBox1.Text,
                    Filas = (int)TFilas.Value,
                    Columnas = (int)TColunmas.Value
                };
                bool[] visibilidad = controlDibujable1.ObtieneVisibilidadPads();
                for (int fila = 0; fila < mascara.Filas; fila++)
                {
                    for (int columna = 0; columna < mascara.Columnas; columna++)
                    {
                        mascara.Pads.Add(new PadArchivo
                        {
                            Fila = fila,
                            Columna = columna,
                            Visible = visibilidad[fila * mascara.Columnas + columna]
                        });
                    }
                }

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

        private bool[] ValidaMascara(MascaraArchivo? mascara)
        {
            if (mascara == null || string.IsNullOrWhiteSpace(mascara.Nombre) ||
                mascara.Filas < TFilas.Minimum || mascara.Filas > TFilas.Maximum ||
                mascara.Columnas < TColunmas.Minimum || mascara.Columnas > TColunmas.Maximum)
            {
                throw new InvalidDataException("El archivo no contiene una máscara válida.");
            }

            int cantidadPads = mascara.Filas * mascara.Columnas;
            if (mascara.Pads == null || mascara.Pads.Count != cantidadPads)
            {
                throw new InvalidDataException("El archivo no contiene todos los pads de la máscara.");
            }

            bool[] visibilidad = new bool[cantidadPads];
            bool[] padDefinido = new bool[cantidadPads];
            foreach (PadArchivo pad in mascara.Pads)
            {
                if (pad.Fila < 0 || pad.Fila >= mascara.Filas ||
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

        private static string NombreArchivo(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "mascara.mascara";
            }

            foreach (char caracter in Path.GetInvalidFileNameChars())
            {
                nombre = nombre.Replace(caracter, '_');
            }

            return Path.ChangeExtension(nombre, ".mascara");
        }
    }
}
