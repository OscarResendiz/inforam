using InfoRam.Dibujable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoRam.EditorChip
{
    public delegate void OnPadClickDelegate(CPad pad);
    public partial class CChip3 : ScrollableControl
    {
        public event OnPadClickDelegate OnPadClick;
        private int FFilas = 10;
        private float FZoom = 1.0f;
        private int FColumnas = 10;
        CObjetoDibujable TieneRaton;
        private int Desplazamiento = 1;
        private int FHScroolValue;
        private int FVScroolValue;
        private List<CObjetoDibujable> Controles;
        private readonly HashSet<int> PadsOcultos = new HashSet<int>();
        private Brush BakBrush;
        private MiGraphics FGraphics;
        private readonly CMascaraChip mascara = new CMascaraChip();
        private Size tamMascaraAnterior;
        private Point origenMascaraAnterior;
        CCuadricula Cuadricula;
        private int FAnchoCuadricula;
        private bool FMostrarCuadricula;
        private Color FColorCuadricula;

        [Category("Cuadricula")]
        [Description("Indica si se muestra la cuadrícula en el fondo.")]
        [DefaultValue(false)]
        public int Filas
        {
            get
            {
                return FFilas;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("No se acepta el cero");
                }
                FFilas = value;
                Invalidate();
            }
        }

        public bool[] ObtieneVisibilidadPads()
        {
            bool[] visibilidad = new bool[FFilas * FColumnas];
            for (int fila = 0; fila < FFilas; fila++)
            {
                for (int columna = 0; columna < FColumnas; columna++)
                {
                    visibilidad[fila * FColumnas + columna] =
                        !PadsOcultos.Contains(fila * FColumnas + columna);
                }
            }

            return visibilidad;
        }

        public void EstableceVisibilidadPads(IReadOnlyList<bool> visibilidad)
        {
            if (visibilidad == null || visibilidad.Count != FFilas * FColumnas)
            {
                throw new ArgumentException("La cantidad de estados de los pads no coincide con las dimensiones de la máscara.", nameof(visibilidad));
            }

            PadsOcultos.Clear();
            for (int indice = 0; indice < visibilidad.Count; indice++)
            {
                if (!visibilidad[indice])
                {
                    PadsOcultos.Add(indice);
                }
            }

            Invalidate();
        }


        [Category("Cuadricula")]
        [Description("Indica si se muestra la cuadrícula en el fondo.")]
        [DefaultValue(false)]

        public int Columnas
        {
            get
            {
                return FColumnas;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("No se acepta el cero");
                }
                FColumnas = value;
                Invalidate();
            }
        }

        [Category("Cuadricula")]
        [Description("Indica si se muestra la cuadrícula en el fondo.")]
        [DefaultValue(false)]
        public bool MostrarCuadricula
        {
            get
            {
                return FMostrarCuadricula;
            }
            set
            {
                FMostrarCuadricula = value;
                Invalidate();
            }
        }
        // Métodos requeridos por el diseñador para evitar el error de serialización
        private bool ShouldSerializeMostrarCuadricula()
        {
            return FMostrarCuadricula != false; // Cambia 'false' por tu valor predeterminado real
        }

        private void ResetMostrarCuadricula()
        {
            MostrarCuadricula = false;
        }
        [Category("Cuadricula")]
        [Description("indica el ancho de la cuadricula")]
        [DefaultValue(10)]
        public int AnchoCuadricula
        {
            get
            {
                return FAnchoCuadricula;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("No se acepta el cero");
                }
                FAnchoCuadricula = value;
                Invalidate();
            }
        }
        [Category("Cuadricula")]
        [Description("indica el color de la cuadricula")]
        public Color ColorCuadricula
        {
            get
            {
                return FColorCuadricula;
            }
            set
            {
                FColorCuadricula = value;
                Invalidate();
            }
        }
        [Category("Cuadricula")]
        [Description("aumenta o disminulle el tamaño")]
        [DefaultValue(1.0f)]
        public float Zoom
        {
            get
            {
                return FZoom;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El zoom debe ser mayor que cero.");
                }
                FZoom = value;
                Invalidate();
            }
        }
        [Category("General")]
        [Description("indica si se mostraran los nombres, voltajes o diodos")]
        [DefaultValue(0)]
        public int MostrarNVD
        {
            get;
            set;
        }
        private bool ShouldSerializeColorCuadricula()
        {
            return FColorCuadricula != Color.White; // Valor por defecto en el constructor
        }

        private void ResetColorCuadricula()
        {
            ColorCuadricula = Color.White;
        }
        public CChip3()
        {
            Controles = new List<CObjetoDibujable>();
            ColorCuadricula = Color.White;
            BakBrush = new SolidBrush(BackColor);
            AnchoCuadricula = 50;
            FHScroolValue = 0;
            FVScroolValue = 0;
            AutoScroll = true;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.ResizeRedraw |
              ControlStyles.ContainerControl |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.SupportsTransparentBackColor, true);
            FGraphics = new MiGraphics(Width, Height);
            InitializeComponent();
        }
        public virtual void InicializaComponentes()
        {
        }
        private void LiberaRaon(CObjetoDibujable objeto)
        {
            TieneRaton = null;
        }
        private void MouseCapture(CObjetoDibujable objeto)
        {
            TieneRaton = objeto;
        }
        private void Repinta(CObjetoDibujable sender)
        {
            Invalidate();
        }
        /// <summary>
        /// establece el desplazamiento horizontal
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int HScroolValue
        {
            get
            {
                return FHScroolValue;
            }
            set
            {
                value = Math.Max(0, value);
                Point posicion = AutoScrollPosition;
                AutoScrollPosition = new Point(value, -posicion.Y);
                ActualizaDesplazamiento();
            }
        }
        /// <summary>
        /// establece el desplazamiento Vertical
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VScroolValue
        {
            get
            {
                return FVScroolValue;
            }
            set
            {
                value = Math.Max(0, value);
                Point posicion = AutoScrollPosition;
                AutoScrollPosition = new Point(-posicion.X, value);
                ActualizaDesplazamiento();
            }
        }

        private void ActualizaDesplazamiento()
        {
            Point posicion = AutoScrollPosition;
            FHScroolValue = Math.Max(0, -posicion.X);
            FVScroolValue = Math.Max(0, -posicion.Y);

            if (FGraphics != null)
            {
                FGraphics.Desplazamiento = Desplazamiento;
                FGraphics.HScroolValue = FHScroolValue;
                FGraphics.VScroolValue = FVScroolValue;
            }

            Invalidate();
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            ActualizaDesplazamiento();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control && e.Delta != 0)
            {
                Zoom = Math.Max(0.1f, Zoom + Math.Sign(e.Delta) * 0.1f);
                return;
            }

            base.OnMouseWheel(e);
        }
        /// <summary>
        /// agrega el objeto al control de los eventos del raton
        /// </summary>
        /// <param name="obj"></param>
        private void CambiaCursor(CObjetoDibujable obj, Cursor cursor)
        {
            this.Cursor = cursor;
        }
        private void RemoveObjetc(CObjetoDibujable obj)
        {
            if (obj != null)
            {
                obj.OnRedibuja -= Repinta;
                obj.OnMouseCapture -= MouseCapture;
                obj.OnMouseFree -= LiberaRaon;
                Controles.Remove(obj);
            }
        }
        #region Manejo de ventanas
        private bool EstaAlFrente(CObjetoDibujable obj)
        {
            if (Controles.Count > 0)
            {
                if (Controles[Controles.Count - 1] == obj)
                    return true;
            }
            return false;

        }
        private void AddObjetc(CObjetoDibujable obj)
        {
            obj.OnRedibuja += new CObjetoDibujableDelegate(Repinta);
            obj.OnMouseCapture += new CObjetoDibujableDelegate(MouseCapture);
            obj.OnMouseFree += new CObjetoDibujableDelegate(LiberaRaon);
            obj.OnChangeCursor += new CObjetoDibujableDelegateCurdor(CambiaCursor);
            obj.OnEstoyAlFrente += new CObjetoDibujableDelegate2(EstaAlFrente);
            Controles.Add(obj);
            Invalidate();
        }
        #endregion
        #region Manejo del raton
        private void ControlDibujable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int mx = e.Location.X + (FHScroolValue * Desplazamiento);
            int my = e.Location.Y + (FVScroolValue * Desplazamiento);
            for (int i = Controles.Count - 1; i > 0; i--)
            {
                CObjetoDibujable obj = Controles[i];
                if (obj.IsVisible())
                {
                    if (obj.OnMouseIn(mx, my))
                    {
                        if (obj.OnMouseDoubleClick(sender, e, mx, my) == true)
                        {
                            return;
                        }
                    }
                }
            }
        }
        private void ControlDibujable_MouseUp(object sender, MouseEventArgs e)
        {
            int mx = e.Location.X + (FHScroolValue * Desplazamiento);
            int my = e.Location.Y + (FVScroolValue * Desplazamiento);
            for (int i = Controles.Count - 1; i > 0; i--)
            {
                CObjetoDibujable obj = Controles[i];
                if (obj.IsVisible())
                {
                    if (obj.OnMouseIn(mx, my))
                    {
                        if (obj.OnMouseUp(sender, e, mx, my) == true)
                        {
                            return;
                        }
                    }
                }
            }

        }
        private void ControlDibujable_MouseMove(object sender, MouseEventArgs e)
        {
            int mx = e.Location.X + (FHScroolValue * Desplazamiento);
            int my = e.Location.Y + (FVScroolValue * Desplazamiento);
            if (TieneRaton != null)
            {
                if (TieneRaton.IsVisible())
                {
                    if (TieneRaton.OnMouseMove(sender, e, mx, my) == true)
                    {
                        return;
                    }
                }
            }
            for (int i = Controles.Count - 1; i > 0; i--)
            {
                CObjetoDibujable obj = Controles[i];
                if (obj.IsVisible())
                {
                    if (obj.OnMouseIn(mx, my))
                    {
                        if (obj.OnMouseMove(sender, e, mx, my) == true)
                        {
                            return;
                        }
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }
        private void ControlDibujable_MouseDown(object sender, MouseEventArgs e)
        {
            int mx = e.Location.X + (FHScroolValue * Desplazamiento);
            int my = e.Location.Y + (FVScroolValue * Desplazamiento);
            bool menuok = false;
            //hago el recorrido desde el masal frente hacia el que esta mas atraz
            for (int i = Controles.Count - 1; i > 0; i--)
            {
                CObjetoDibujable obj = Controles[i];
                if (obj.IsVisible())
                {
                    if (obj.OnMouseIn(mx, my))
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            ContextMenuStrip = obj.PreparaMenu(this.components, mx, my);
                            if (ContextMenuStrip != null)
                            {
                                menuok = true;
                                break;
                            }
                        }
                        if (obj.OnMouseDown(sender, e, mx, my) == true)
                        {
                            //lo paso al frente
                            Controles.Remove(obj);
                            Controles.Add(obj);
                            Invalidate();
                            return;
                        }
                    }
                }
            }
            if (menuok == false)
                ContextMenuStrip = null;
        }
        private void ControlDibujable_MouseClick(object sender, MouseEventArgs e)
        {
            int mx = e.Location.X + (FHScroolValue * Desplazamiento);
            int my = e.Location.Y + (FVScroolValue * Desplazamiento);
            seleccionaPad(mx,my);
//            if (e.Button == MouseButtons.Left && AlternaVisibilidadPad(mx, my))
//          {
//            return;
//      }

            //            for (int i = Controles.Count - 1; i > 0; i--)
            //          {
            //            CObjetoDibujable obj = Controles[i];
            //          if (obj.IsVisible())
            //        {
            //          if (obj.OnMouseIn(mx, my))
            //        {
            //          if (obj.OnMouseClick(sender, e, mx, my) == true)
            //        {
            //          return;
            //    }
            //                    }
            //              }
            //        }
        }


        private Point CalculaOrigenMascara(Size tamMascara)
        {
            int origenX = Math.Max(10, (ClientSize.Width - tamMascara.Width) / 2);
            int origenY = Math.Max(10, (ClientSize.Height - tamMascara.Height) / 2);
            return new Point(origenX, origenY);
        }
        #endregion
        private void Dibuja()
        {
            mascara.Filas = FFilas;
            mascara.Columnas = FColumnas;
            mascara.DiametroPad = 35;
            mascara.Zoom = Zoom;
            mascara.PadVisible = EsPadVisible;
            Size tam = mascara.GetSize();
            Point origen = CalculaOrigenMascara(tam);
            mascara.X = origen.X;
            mascara.Y = origen.Y;

            if (tam != tamMascaraAnterior || origen != origenMascaraAnterior)
            {
                AutoScrollMinSize = new Size(mascara.X + tam.Width, mascara.Y + tam.Height);
                tamMascaraAnterior = tam;
                origenMascaraAnterior = origen;
            }

            int anchoVisible = Math.Max(1, ClientSize.Width);
            int altoVisible = Math.Max(1, ClientSize.Height);
            if (FGraphics.Width != anchoVisible || FGraphics.Height != altoVisible)
            {
                FGraphics.Redimenciona(anchoVisible, altoVisible);
            }

            FGraphics.Clear(BackColor);
            mascara.MostrarNVD = MostrarNVD;
            mascara.Dibuja(FGraphics);
        }
        public void AsignaVoltaje(String nombre, string valor)
        {
            mascara.AsignaVoltaje(nombre, valor);
        }
        public void CambiaNombrePad(String nombre, String nuevoNombre)
        {
            mascara.CambiaNombre(nombre, nuevoNombre);
        }

        public void AsignaDiodo(String nombre, string valor)
        {
            mascara.AsignaDiodo(nombre, valor);
        }

        private bool EsPadVisible(int indice)
        {
            return !PadsOcultos.Contains(indice);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Dibuja();
            e.Graphics.DrawImage(FGraphics.GetBitMap(), 0, 0);
        }
        private void seleccionaPad(int x, int y)
        {
            const int diametroPad = 35;
            int diametroZoom = (int)(diametroPad * Zoom);
            Size tamMascara = new Size(FColumnas * diametroZoom, FFilas * diametroZoom);
            Point origen = CalculaOrigenMascara(tamMascara);

            if (diametroZoom <= 0 || x < origen.X || y < origen.Y)
            {
                return ;
            }

            int columna = (x - origen.X) / diametroZoom;
            int fila = (y - origen.Y) / diametroZoom;
            if (columna < 0 || columna >= FColumnas || fila < 0 || fila >= FFilas)
            {
                return ;
            }

            int indice = fila * FColumnas + columna;
            CPad? pad = mascara.GetPad(indice);
            mascara.ResaltaPad(indice);
            if (pad.Visible)
            {
                OnPadClick?.Invoke(pad);
            }
            Invalidate();
        }
        public CMascaraChip getMascara()
        {
             return mascara; 
        }
        public CPad GetPad(int index)
        {
            return mascara.GetPad(index);
        }
        public void RestablecePads()
        {
            mascara.RestableceValoresPads();
            //PadsOcultos.Clear();
            Invalidate();
        }
        public void reajustaPads()
        {
            mascara.Filas = Filas;
            mascara.Columnas = Columnas;
            mascara.RestableceValoresPads();
        }
    }
}
