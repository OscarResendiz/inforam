using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros.PuertoSerial
{
    internal class SerialPortDto
    {
        public string SerialPort { get; set; } = string.Empty;
        public string Velocidad { get; set; } = string.Empty;
        public string Paridad { get; set; } = string.Empty;
        public string BitsDatos { get; set; } = string.Empty;
        public string BitsParada { get; set; } = string.Empty;
//        public string retardo { get; set; } = string.Empty;
    }
}
