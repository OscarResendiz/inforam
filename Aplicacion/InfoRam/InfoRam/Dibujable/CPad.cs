using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InfoRam.Dibujable
{
    /// <summary>
    /// Clase que representa un pad de un chip
    /// </summary>
    /// 
    public class CPad: CDibujable
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
        public int MostrarNVD
        {
            get;
            set;
        }
        public String Nombre
        {
            get;
            set;
        }
        public string ValorVoltaje 
        {
            get; 
            set; 
        }
        public string ValorDiodos 
        { 
            get; 
            set; 
        }

        public float Zoom
        {
            get;
            set;
        }
        public bool Resaltado { get; set; } = false;
        public bool Visible { get; set; } = true;
        public Font Fuente { get; set; }
        public int Indice { get; set; }

        public CPad()
            {
            MostrarNVD = 0;
            Nombre = "A0";
            ValorVoltaje = "0";
            ValorDiodos = "X";
        }
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
            Brush brocha = Brushes.LightSlateGray;
            if(Resaltado)
            {
                brocha = Brushes.DarkTurquoise;
            }
            //obtengo las dimenciones del grafico
            graphics.FillEllipse(brocha, X + diametroZoom / 4, Y + diametroZoom / 4, diametroZoom / 2, diametroZoom / 2);
            // dibujo el nombre del pad centrado en el pad
            string texto = "";
            brocha = Brushes.White;
            switch (MostrarNVD)
            {
                case 1:
                    texto = ValorVoltaje+"V";
                    brocha=Brushes.Red;
                    break;
                case 2:
                    texto = ValorDiodos+"D";
                    brocha = Brushes.Black;
                    break;
                default:
                    texto = Nombre;
                    brocha = Brushes.White;
                    break;
            }
            if (!String.IsNullOrEmpty(texto))
            {
                SizeF tamTexto = graphics.MeasureString(texto, Fuente);
                graphics.DrawString(texto, Fuente, brocha, X + diametroZoom / 2 - tamTexto.Width / 2, Y + diametroZoom / 2 - tamTexto.Height / 2);
            }
        }
        public string DameValor()
        {
            switch (MostrarNVD)
            {
                case 1:
                    return ValorVoltaje;
                case 2:
                    return ValorDiodos;
                default:
                    return Nombre;
            }
        }
    }
}
