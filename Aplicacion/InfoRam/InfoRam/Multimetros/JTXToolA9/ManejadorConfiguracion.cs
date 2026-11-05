using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros.JTXToolA9
{
    internal class ManejadorConfiguracion
    {
        public static void GuardarConfiguracion(JtxToolA9Dto config)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(config);
            System.IO.File.WriteAllText(NombreArchivo(), json);
        }
        public static JtxToolA9Dto CargarConfiguracion()
        {
            string rutaArchivo = NombreArchivo();
            if (!System.IO.File.Exists(rutaArchivo))
            {
                return new JtxToolA9Dto();
            }
            string json = System.IO.File.ReadAllText(rutaArchivo);
            return System.Text.Json.JsonSerializer.Deserialize<JtxToolA9Dto>(json);
        }
        private static string NombreArchivo()
        {
            string rutaCarpeta = AppContext.BaseDirectory;
            if (!System.IO.Directory.Exists(rutaCarpeta))
            {
                System.IO.Directory.CreateDirectory(rutaCarpeta);
            }
            //abro el archivo para gusradar la configuracion en formato json
            return System.IO.Path.Combine(rutaCarpeta, "JtxToolA9.config");

        }
    }
}
