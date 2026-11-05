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
            LeerDatos();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            GuardaDatos();
            this.Close();
        }
        private void GuardaDatos()
        {
            var config = new JtxToolA9Dto
            {
                SerialPort = ComboPuerto.SelectedItem?.ToString() ?? string.Empty,
                Velocidad = ComboVelocidad.SelectedItem?.ToString() ?? string.Empty,
                Paridad = ComboParidad.SelectedItem?.ToString() ?? string.Empty,
                BitsDatos = ComboBitsDatos.SelectedItem?.ToString() ?? string.Empty,
                BitsParada = ComboBitsParo.SelectedItem?.ToString() ?? string.Empty,
                retardo = TxtRetardo.Text
            };
            ManejadorConfiguracion.GuardarConfiguracion(config);
        }
        private void LeerDatos()
        {
            var config = ManejadorConfiguracion.CargarConfiguracion();
            ComboPuerto.SelectedItem = config.SerialPort;
            ComboVelocidad.SelectedItem = config.Velocidad;
            ComboParidad.SelectedItem = config.Paridad;
            ComboBitsDatos.SelectedItem = config.BitsDatos;
            ComboBitsParo.SelectedItem = config.BitsParada;
            TxtRetardo.Text = config.retardo;
        }
    }
}
