using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Cliente
    {
        private string cli_DNI;
        private string cli_Apellido;
        private string cli_Nombre;
        private string cli_Direccion;
        private string os_CUIT;
        private string cli_NroCarnet;

        public string Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }

        public string OS_CUIT
        {
            get { return os_CUIT; }
            set { os_CUIT = value; }
        }

        public string Cli_NroCarnet
        {
            get { return cli_NroCarnet; }
            set { cli_NroCarnet = value; }
        }

        public Cliente(string dni, string apellido, string nombre, string direccion, string osCuit, string nroCarnet)
        {
            Cli_DNI = dni;
            Cli_Apellido = apellido;
            Cli_Nombre = nombre;
            Cli_Direccion = direccion;
            OS_CUIT = osCuit;
            Cli_NroCarnet = nroCarnet;

        }
    }
}
