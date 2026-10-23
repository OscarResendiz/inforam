using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InfoRam.Dibujable
{
    public class CMascaraChip : CDibujable
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
        public int MostrarNVD
        {
            get;
            set;
        }
        private readonly List<CPad> pads = new List<CPad>();
        private Font fuentePad;
        private int filasConfiguradas;
        private int columnasConfiguradas;
        private float zoomConfigurado;
        private int diametroConfigurado;
        [JsonIgnore]
        public Func<int, bool> PadVisible { get; set; }

        public override void Dibuja(MiGraphics graphics)
        {
            base.Dibuja(graphics);
            int diametroPad = (int)(DiametroPad * Zoom);
            ActualizaPads(diametroPad);
            //dibujo el fondo de la mascara al tamaño que ocupan los pads
            graphics.FillRectangle(Brushes.DarkGreen, X, Y, Columnas * diametroPad, Filas * diametroPad);
            graphics.DrawRectangle(Pens.LightSlateGray, X, Y, Columnas * diametroPad, Filas * diametroPad);
            foreach (CPad pad in pads)
            {
                pad.X = X + (pad.Indice % Columnas) * diametroPad;
                pad.Y = Y + (pad.Indice / Columnas) * diametroPad;
                pad.Visible = PadVisible == null || PadVisible(pad.Indice);
                pad.MostrarNVD = MostrarNVD;
                pad.Dibuja(graphics);
            }
            //dibuja un rectangulo con las dimensiones de la mascara
        }

        private void ActualizaPads(int diametroPad)
        {
            if (filasConfiguradas == Filas && columnasConfiguradas == Columnas &&
                zoomConfigurado == Zoom && diametroConfigurado == DiametroPad)
            {
                return;
            }

            fuentePad?.Dispose();
            fuentePad = new Font("Arial", 6 * Zoom);
            //pads.Clear();

            char letra = 'A';
            char letra2 = '\0';
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
                    string nombre = "";
                    if (letra2 != '\0')
                    {
                        nombre = $"{letra2}{letra}{i}";
                    }
                    else
                    {
                        nombre = $"{letra}{i}";
                    }
                    CPad? padExistente = pads.Find(p => p.Indice == i * Columnas + j);
                    if (padExistente != null)
                    {
                        //padExistente.Nombre = nombre;
                        padExistente.Zoom = Zoom;
                        padExistente.Fuente = fuentePad;
                        continue;
                    }
                    else
                    {
                        pads.Add(new CPad
                        {
                            Indice = i * Columnas + j,
                            X = X + j * diametroPad,
                            Y = Y + i * diametroPad,
                            Diametro = DiametroPad,
                            Zoom = Zoom,
                            Nombre = nombre, //$"{letra2}{letra}{i}",
                            Fuente = fuentePad
                        });
                    }
                }
            }

            filasConfiguradas = Filas;
            columnasConfiguradas = Columnas;
            zoomConfigurado = Zoom;
            diametroConfigurado = DiametroPad;
        }
        public Size GetSize()
        {
            int diametroPad = (int)(DiametroPad * Zoom);
            return new Size(Columnas * diametroPad, Filas * diametroPad);
        }
        public void AsignaVoltaje(string nombre, string valor)
        {
            foreach (CPad pad in pads)
            {
                if (pad.Nombre == nombre)
                {
                    pad.ValorVoltaje = valor;
                    break;
                }
            }
        }
        public void CambiaNombre(string nombre, string nuevoNombre)
        {
            foreach (CPad pad in pads)
            {
                if (pad.Nombre == nombre)
                {
                    pad.Nombre = nuevoNombre;
                    break;
                }
            }
        }
        public void AsignaDiodo(string nombre, string valor)
        {
            foreach (CPad pad in pads)
            {
                if (pad.Nombre == nombre)
                {
                    pad.ValorDiodos = valor;
                    break;
                }
            }
        }
        public float GetVoltaje(string nombre)
        {
            foreach (CPad pad in pads)
            {
                if (pad.Nombre == nombre)
                {
                    if (float.TryParse(pad.ValorVoltaje, out float valor))
                    {
                        return valor;
                    }
                    break;
                }
            }
            return 0f;
        }
        public float GetDiodo(string nombre)
        {
            foreach (CPad pad in pads)
            {
                if (pad.Nombre == nombre)
                {
                    if (float.TryParse(pad.ValorDiodos, out float valor))
                    {
                        return valor;
                    }
                    break;
                }
            }
            return 0f;
        }
        public CPad GetPad(int indice)
        {
            if (indice < 0 || indice >= pads.Count)
            {
                return null;
            }
            return pads[indice];
        }
        public void ResaltaPad(int indice)
        {
            for (int i = 0; i < pads.Count; i++)
            {
                pads[i].Resaltado = false;
            }
            pads[indice].Resaltado = true;
        }
        public void RestableceValoresPads()
        {
         //   if (filasConfiguradas == Filas && columnasConfiguradas == Columnas &&
           //    zoomConfigurado == Zoom && diametroConfigurado == DiametroPad)
            //{
              //  return;
            //}

            char letra = 'A';
            char letra2 = '\0';
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
                    string nombre = "";
                    if (letra2 != '\0')
                    {
                        nombre = $"{letra2}{letra}{i}";
                    }
                    else
                    {
                        nombre = $"{letra}{i}";
                    }
                    CPad? padExistente = pads.Find(p => p.Indice == i * Columnas + j);
                    if (padExistente != null)
                    {
                        //padExistente.Nombre = nombre;
                        padExistente.Zoom = Zoom;
                        padExistente.Fuente = fuentePad;
                        padExistente.Nombre = nombre;
                        padExistente.ValorDiodos = "X";
                        padExistente.ValorVoltaje = "0";
                        continue;
                    }
                    else
                    {
                        pads.Add(new CPad
                        {
                            Indice = i * Columnas + j,
                            X = X + j * DiametroPad,
                            Y = Y + i * DiametroPad,
                            Diametro = DiametroPad,
                            Zoom = Zoom,
                            Nombre = nombre, //$"{letra2}{letra}{i}",
                            Fuente = fuentePad
                        });
                    }
                }
            }
        }
    }
}