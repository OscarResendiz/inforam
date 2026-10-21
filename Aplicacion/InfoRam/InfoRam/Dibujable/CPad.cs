using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InfoRam.Dibujable
{
    /// <summary>
    /// Clase que representa un pad de un chip
    /// </summary>
    internal class CPad: CDibujable
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
        public int Diametro
        {
            get;
            set;
        }
        public String Nombre
        {
            get;
            set;
        }
        public float Zoom
        {
            get;
            set;
        }
        public bool Visible { get; set; } = true;
        public Font Fuente { get; set; }
        public int Indice { get; set; }

        public bool Contiene(int x, int y)
        {
            int diametroZoom = (int)(Diametro * Zoom);
            return diametroZoom > 0 &&
                x >= X && x < X + diametroZoom &&
                y >= Y && y < Y + diametroZoom;
        }

        //dibuja un circulo en el centro del pad
        public virtual void Dibuja(MiGraphics graphics)
        {
            if (!Visible)
            {
                return;
            }

            base.Dibuja(graphics);
            int diametroZoom = (int)(Diametro * Zoom);
            //obtengo las dimenciones del grafico
            graphics.FillEllipse(Brushes.LightSlateGray, X + diametroZoom / 4, Y + diametroZoom / 4, diametroZoom / 2, diametroZoom / 2);
            // dibujo el nombre del pad centrado en el pad
            if (!String.IsNullOrEmpty(Nombre))
            {
                SizeF tamNombre = graphics.MeasureString(Nombre, Fuente);
                graphics.DrawString(Nombre, Fuente, Brushes.White, X + diametroZoom / 2 - tamNombre.Width / 2, Y + diametroZoom / 2 - tamNombre.Height / 2);
            }
        }

    }
}
