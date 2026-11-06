using InfoRam.Multimetros.PuertoSerial;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace InfoRam.Multimetros.XDM1041
{
    internal class XDM1041Multimeter : IMultimetro
    {
        private SerialPort? PuertoSerial;
        string Datos = "";
        string Funcion = "";
        public bool CambiaDiodos()
        {
            EnviarComando("CONF:DIOD\r\n");
            return true;
        }

        public bool CambiaVoltimetro()
        {
            EnviarComando("CONF:VOLT:DC AUTO\r\n");
            return true;
        }


        public bool Configurar()
        {
            try
            {
                FormComConfig form = new FormComConfig("XDM1041.config");
                form.ShowDialog();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Desconectar()
        {
            try
            {
                PuertoSerial.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string LeeDatos()
        {

            EnviarComando("MEAS1\r\n");
            //doy tiempo a que el multimetro responda
            System.Threading.Thread.Sleep(200);
            return Datos;
        }
        public bool Conectar()
        {
            try
            {
                SerialPortDto config = ManejadorConfiguracionSerial.CargarConfiguracion("XDM1041.config");
                if (PuertoSerial == null)
                {
                    PuertoSerial = new SerialPort(config.SerialPort, int.Parse(config.Velocidad), (Parity)Enum.Parse(typeof(Parity), config.Paridad), int.Parse(config.BitsDatos), (StopBits)Enum.Parse(typeof(StopBits), config.BitsParada));
                    PuertoSerial.DataReceived += new SerialDataReceivedEventHandler(OnDataReceived);
                }
                else if (PuertoSerial.IsOpen)
                {
                    PuertoSerial.Close();
                    PuertoSerial.PortName = config.SerialPort;
                    PuertoSerial.BaudRate = int.Parse(config.Velocidad);
                    PuertoSerial.Parity = (Parity)Enum.Parse(typeof(Parity), config.Paridad);
                    PuertoSerial.DataBits = int.Parse(config.BitsDatos);
                    PuertoSerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), config.BitsParada);
                }
                PuertoSerial.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Handle the data received event here
            string datos = PuertoSerial?.ReadExisting() ?? string.Empty; // Read the data from the serial port
            string[] lineas = datos.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lineas.Length > 0)
            {
                Datos = lineas[lineas.Length-1]; // Store the last line of data received
            }

        }
        private void EnviarComando(string comando)
        {
            if (PuertoSerial != null && PuertoSerial.IsOpen)
            {
                PuertoSerial.WriteLine(comando);
            }
        }
    }
}
