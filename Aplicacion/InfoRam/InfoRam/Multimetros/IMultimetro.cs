using System;
using System.Collections.Generic;
using System.Text;

namespace InfoRam.Multimetros
{
    /*
     * interface que define los metodos que debe implementar un multimetro
     */
    internal interface IMultimetro
    {
        /// <summary>
        /// funcion que conecta el multimetro
        /// </summary>
        /// <returns></returns>
        bool Conectar();
        /// <summary>
        /// funcion que desconecta el multimetro
        /// </summary>
        /// <returns></returns>
        bool Desconectar();
        /// <summary>
        /// cambia a funcion de lecor de voltaje
        /// </summary>
        /// <returns></returns>
        bool CambiaVoltimetro();
        /// <summary>
        /// cambia funcionalidad de diodos
        /// </summary>
        /// <returns></returns>
        bool CambiaDiodos();
        /// <summary>
        /// obtiene la lectura del multimtero dependiendo de la funcion en la que este
        /// </summary>
        /// <returns></returns>
        string LeeDatos();
        /// <summary>
        /// configura el multimetro
        /// </summary>
        /// <returns></returns>
        bool Configurar();
    }
}
