using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoRam
{
    public partial class FormEditorMascara : Form
    {
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
    }
}
