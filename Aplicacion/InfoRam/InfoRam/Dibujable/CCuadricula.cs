using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Dibujable
{
    public class CCuadricula : CDibujable
    {
        public CCuadricula()
        {
            Color = Color.LightGray;
            AnchoCuadricula = 25;
        }
        /// <summary>
        /// indica si se va a ver o no la cuadricula
        /// </summary>
        public bool Visible
        {
            get;
            set;
        }
        /// <summary>
        /// Indica el ancho de la cuadricula
        /// </summary>
        public int AnchoCuadricula
        {
            get;
            set;
        }
        public Color Color
        {
            get;
            set;
        }
        public int Ancho
        {
            get;
            set;
        }
        public int Alto
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
        public override void Dibuja(MiGraphics graphics)
        {
            base.Dibuja(graphics);
            if (Visible)
            {
                //obtengo las dimenciones del grafico
                Pen pen = new Pen(Color);
                //creo el marco
                graphics.FDrawRectangle(pen, 0, 0, Ancho - 1, Alto - 1);
                //ahora creo la cuadricula
                for (int x = 0; x < Ancho; x += AnchoCuadricula)
                {
                    graphics.FDrawLine(pen, x, 0, x, Alto);
                }
                for (int y = 0; y < Alto; y += AnchoCuadricula)
                {
                    graphics.FDrawLine(pen, 0, y, Ancho, y);
                }
            }
        }

    }
}