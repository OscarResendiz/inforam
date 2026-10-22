using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoRam.EditorChip
{
    public partial class CPadEditable : UserControl
    {
        public CPadEditable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // 1. Permitir teclas de control (como Retroceso / Backspace)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // 2. Verificar si es un número (0-9)
            bool esNumero = char.IsDigit(e.KeyChar);

            // 3. Verificar si es un separador decimal (punto o coma según la configuración)
            char separadorDecimal = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            bool esSeparador = (e.KeyChar == '.' || e.KeyChar == separadorDecimal);

            // 4. Verificar si es el signo menos '-' (solo al inicio y si no existe ya)
            bool esSignoMenos = (e.KeyChar == '-' && textBox.SelectionStart == 0 && !textBox.Text.Contains("-"));

            // Si no es ninguna de las opciones permitidas, se cancela el evento
            if (!esNumero && !esSeparador && !esSignoMenos)
            {
                e.Handled = true;
                return;
            }

            // 5. Evitar que se escriba más de un punto o coma decimal
            if (esSeparador && (textBox.Text.Contains(".") ))
            {
                e.Handled = true;
            }
        }

        [Category("Valores")]
        [Description("Indica el valor del diodo.")]
        [DefaultValue(0.0f)]
        public float Diodo
        {
            get { return float.Parse(TDiodo.Text); }
            set { TDiodo.Text = value.ToString(); }
        }
        [Category("Valores")]
        [Description("Indica el valor del voltaje.")]
        [DefaultValue(0.0f)]
        public float Voltaje
        {
            get { return float.Parse(TVoltaje.Text); }
            set { TVoltaje.Text = value.ToString(); }
        }
        [Category("Valores")]
        [Description("Indica el nombre del componente.")]
        [DefaultValue("A0")]
        public string Nombre
        {
            get { return LNombre.Text; }
            set { LNombre.Text = value; }
        }
        [Category("Valores")]
        [Description("Indica la visibilidad del componente.")]
        [DefaultValue(true)]
        public bool visible
        {
            get {
                return LNombre.Visible; 
            }
            set {
                LNombre.Visible = value;
                label1.Visible = value;
                label2.Visible = value;
                TDiodo.Visible = value;
                TVoltaje.Visible = value;
            }
        }
    }
}
