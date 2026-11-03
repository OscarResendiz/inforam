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
            return multimetros;
        }
        public IMultimetro ObtenerMultimetro(string nombreMultimetro)
        {
            if (nombreMultimetro == "Multimetro virtual")
            {
                return new Multimetros.MultimetroVitual.MultimetroVitual();
            }
            else
            {
                return null;
            }
        }
    }
}
