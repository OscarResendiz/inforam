using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros
{
    internal class AdministradorMultimetros
    {
        public List<string> ObtenerMultimetrosDisponibles()
        {
            List<string> multimetros = new List<string>();
            multimetros.Add("Multimetro virtual");
            multimetros.Add("JTXToolA9");
            return multimetros;
        }
        public IMultimetro ObtenerMultimetro(string nombreMultimetro)
        {
            if (nombreMultimetro == "Multimetro virtual")
            {
                return new Multimetros.MultimetroVitual.MultimetroVitual();
            }
            else if (nombreMultimetro == "JTXToolA9")
            {
                return new Multimetros.JTXToolA9.JTXToolA9Multimeter();
            }
            return null;
        }
    }
}
