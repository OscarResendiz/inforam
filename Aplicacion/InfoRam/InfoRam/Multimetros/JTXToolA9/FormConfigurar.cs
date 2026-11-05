using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoRam.Multimetros.JTXToolA9
{
    public partial class FormConfigurar : Form
    {
        public FormConfigurar()
        {
            InitializeComponent();
        }
        private void CargaPuertos()
        {
            string[] puertos = System.IO.Ports.SerialPort.GetPortNames();
            ComboPuerto.Items.Clear();
            ComboPuerto.Items.AddRange(puertos);
        }

        private void FormConfigurar_Load(object sender, EventArgs e)
        {
            CargaPuertos();
        }
    }
}
