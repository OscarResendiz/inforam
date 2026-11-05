using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros.JTXToolA9
{
    internal class JTXToolA9Multimeter : IMultimetro
    {
        public bool CambiaDiodos()
        {
            throw new NotImplementedException();
        }

        public bool CambiaVoltimetro()
        {
            throw new NotImplementedException();
        }

        public bool Conectar()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public string LeeDatos()
        {
            throw new NotImplementedException();
        }
    }
}
