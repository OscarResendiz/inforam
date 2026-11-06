using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros.PuertoSerial
{
    internal class ManejadorConfiguracionSerial
    {
        public static void GuardarConfiguracion(SerialPortDto config, string nombreArchivo)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(config);
            System.IO.File.WriteAllText(NombreArchivo(nombreArchivo), json);
        }
        public static SerialPortDto CargarConfiguracion(string nombreArchivo)
        {
            string rutaArchivo = NombreArchivo(nombreArchivo);
            if (!System.IO.File.Exists(rutaArchivo))
            {
                return new SerialPortDto();
            }
            string json = System.IO.File.ReadAllText(rutaArchivo);
            return System.Text.Json.JsonSerializer.Deserialize<SerialPortDto>(json);
        }
        private static string NombreArchivo(string nombreArchivo)
        {
            string rutaCarpeta = AppContext.BaseDirectory;
            if (!System.IO.Directory.Exists(rutaCarpeta))
            {
                System.IO.Directory.CreateDirectory(rutaCarpeta);
            }
            //abro el archivo para gusradar la configuracion en formato json
            return System.IO.Path.Combine(rutaCarpeta, nombreArchivo);// "JtxToolA9.config");

        }
    }
}
