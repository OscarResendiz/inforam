using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Dibujable
{
    internal class CMascaraChip : CDibujable
    {
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }
        public int Filas
        {
            get;
            set;
        }
        public int Columnas
        {
            get;
            set;
        }
        public int DiametroPad
        {
            get;
            set;
        }
        public float Zoom
        {
            get;
            set;
        }
        public Func<int, bool> PadVisible { get; set; }

        public override void Dibuja(MiGraphics graphics)
        {
            base.Dibuja(graphics);
            int diametroPad = (int)(DiametroPad * Zoom);
            //dibujo el fondo de la mascara al tamaño que ocupan los pads
            graphics.FillRectangle(Brushes.DarkGreen, X, Y, Columnas * diametroPad, Filas * diametroPad);
            Pen pen = new Pen(Color.LightSlateGray);
            graphics.DrawRectangle(pen, X, Y, Columnas * diametroPad, Filas * diametroPad);
            char letra = 'A';
            char letra2 = '\0';
            //dibujo los pads de la mascara
            for (int i = 0; i < Filas; i++)
            {
                letra = 'A';
                letra2 = '\0';
                for (int j = 0; j < Columnas; j++, letra++)
                {
                    if (letra > 'Z')
                    {
                        letra = 'A';
                        letra2++;
                        if (letra2 < 'A')
                            letra2 = 'A';
                    }
                    CPad pad = new CPad();
                    pad.X = X + j * diametroPad;
                    pad.Y = Y + i * diametroPad;
                    pad.Diametro = DiametroPad;
                    pad.Zoom = Zoom;
                    pad.Nombre = $"{letra2}{letra}{i}";
                    pad.Visible = PadVisible == null || PadVisible(i * Columnas + j);
                    pad.Dibuja(graphics);
                }
            }
            //dibuja un rectangulo con las dimensiones de la mascara
        }
        public Size GetSize()
        {
            int diametroPad = (int)(DiametroPad * Zoom);
            return new Size(Columnas * diametroPad, Filas * diametroPad);
        }
    }
}