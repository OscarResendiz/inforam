using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace InfoRam.Multimetros.MultimetroVitual
{

    internal class MultimetroVitual : IMultimetro
    {
        private bool voltimetro = true;
        public bool Conectar()
        {
            MessageBox.Show("Conectando al multimetro virtual", "Multimetro virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool Desconectar()
        {
            MessageBox.Show("Desconectando del multimetro virtual", "Multimetro virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public bool CambiaVoltimetro()
        {
            MessageBox.Show("Cambiando a voltimetro", "Multimetro virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            voltimetro = true;
            return true;
        }

        public bool CambiaDiodos()
        {
            MessageBox.Show("Cambiando a diodos", "Multimetro virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            voltimetro = false;
            return true;
        }

        public string LeeDatos()
        {
            string mensaje = voltimetro ? "Ingrese el valor de voltaje:" : "Ingrese el valor de diodo:";
            string textoIngresado = Interaction.InputBox( mensaje,"Multimetro virtual","0");
            return textoIngresado;
        }

        public bool Configurar()
        {
            MessageBox.Show("Configurando el multimetro virtual", "Multimetro virtual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}