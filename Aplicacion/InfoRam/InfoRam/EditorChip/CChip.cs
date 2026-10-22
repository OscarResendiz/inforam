using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoRam.EditorChip
{
    public partial class CChip : UserControl
    {
        private int FFilas = 10;
        private int FColumnas = 10;
        public CChip()
        {
            InitializeComponent();
        }
        [Category("Valores")]
        [Description("Indica numero de filas.")]
        [DefaultValue(10)]
        public int Filas
        {
            get
            {
                return FFilas;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Filas", "El número de filas debe ser mayor o igual a 1.");
                }
                FFilas = value;
                CargaPads();
            }
        }

        [Category("Valores")]
        [Description("Indica numero de columnas.")]
        [DefaultValue(10)]
        public int Columnas
        {
            get
            {
                return FColumnas;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Columnas", "El número de columnas debe ser mayor o igual a 1.");
                }
                FColumnas = value;
                CargaPads();
            }
        }

        private void CChip_Load(object sender, EventArgs e)
        {
        }
        private void CargaPads()
        {
            char letra = 'A';
            char letra2 = '\0';

            this.Controls.Clear();
            for (int i = 0; i < Filas; i++)
            {
                letra = 'A';
                letra2 = '\0';
                for (int j = 0; j < Columnas; j++)
                {
                    if (letra > 'Z')
                    {
                        letra = 'A';
                        letra2++;
                        if (letra2 < 'A')
                            letra2 = 'A';
                    }
                    CPadEditable pad = new CPadEditable();
                    pad.Location = new Point(j * (pad.Width + 5), i * (pad.Height + 5));
                    pad.Nombre = $"{letra2.ToString().Replace("\0", "")}{letra}{i}";
                    this.Controls.Add(pad);
                }
            }
        }
    }
}
