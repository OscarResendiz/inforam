using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace InfoRam.Multimetros.JTXToolA9
{
    internal class JTXToolA9Multimeter : IMultimetro
    {
        private SerialPort? PuertoSerial;
        string Datos = "";
        string Funcion="";
        public bool CambiaDiodos()
        {
            //throw new NotImplementedException();
            EnviarComando("setD\r\n");
            return true;
        }

        public bool CambiaVoltimetro()
        {
            //throw new NotImplementedException();
            EnviarComando("setC\r\n");
            return true;
        }


        public bool Configurar()
        {
            try
            {
                FormConfigurar form = new FormConfigurar();
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
            return Datos;
        }
        public bool Conectar()
        {
            try
            {
                JtxToolA9Dto config = ManejadorConfiguracion.CargarConfiguracion();
                if (PuertoSerial == null)
                {
                    PuertoSerial = new SerialPort(config.SerialPort, int.Parse(config.Velocidad), (Parity)Enum.Parse(typeof(Parity), config.Paridad), int.Parse(config.BitsDatos), (StopBits)Enum.Parse(typeof(StopBits), config.BitsParada));
                    PuertoSerial.DataReceived += new  SerialDataReceivedEventHandler(OnDataReceived);
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
            foreach (var item in lineas)
            {
                if(item.Contains("qc'")) //se lee voltajes
                {
                    Funcion = "voltaje";
                    string d =item.Replace("qc'", "").Trim();
                    string[] partes = d.Split(' ');
                    if(partes.Length > 1)
                    {
                        Datos = partes[1];
                        float f;
                        if (float.TryParse(Datos, out f))
                        {
                            Datos = f.ToString("F4");
                        }
                    }
                }
                if (item.Contains("zd'")) //se lee diodos
                {
                    Funcion = "diodos";
                    string d = item.Replace("zd'", "").Trim();
                    string[] partes = d.Split(' ');
                    if (partes.Length > 1)
                    {
                        Datos = partes[0];
                        float f;
                        if (float.TryParse(Datos, out f))
                        {
                            Datos = f.ToString("F4");
                        }
                    }
                }
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
