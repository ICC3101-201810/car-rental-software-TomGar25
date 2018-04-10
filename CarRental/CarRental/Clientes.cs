using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Clientes
    {
        public string nombre;
        public string licencia;

    }
    class persona : Clientes
    {
        public persona(string nom, string lic)
        {
            nombre = nom;
            licencia = lic;
        }

    }
    class insorg : Clientes
    {
        public insorg(string nom, string lic)
        {
            nombre = nom;
            licencia = lic;
        }
    }
    class empresa : Clientes
    {
        public empresa(string nom, string lic)
        {
            nombre = nom;
            licencia = lic;
        }
    }

}

