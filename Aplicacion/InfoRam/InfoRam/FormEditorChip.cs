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
    public partial class FormEditorChip : Form
    {
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
        }

        public FormEditorChip()
        {
            InitializeComponent();
        }

        private void BtnSelMascara_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Filter = "Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*",
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

                cChip21.Filas = mascara!.Filas;
                cChip21.Columnas = mascara.Columnas;
                cChip21.EstableceVisibilidadCeldas(visibilidad);
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
    }
}
