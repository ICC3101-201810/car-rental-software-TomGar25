using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Clientes
    {
        string nombre;
        string licencia;

        public Clientes(string nom, string lic)
        {
            nombre = nom;
            licencia = lic;

        }
        public string getnombre()
        {
            return this.nombre;
        }
        public string getlicencia()
        {
            return this.licencia;

        }
    }
    

    class persona : Clientes
    {
        string nombre;
        string licencia;
        public persona(string nom, string lic): base(nom,lic)
        {
            nombre = nom;
            licencia = lic;
        }

    }
    class institucion : Clientes
    {
        string nombre;
        string licencia;
        public institucion(string nom, string lic) : base(nom, lic)
        {
            nombre = nom;
            licencia = lic;
        }
    }
    class organizacion : Clientes
    {
        string nombre;
        string licencia;
        public organizacion(string nom, string lic) : base(nom, lic)
        {
            nombre = nom;
            licencia = lic;
        }
    }
    class empresa : Clientes
    {
        string nombre;
        string licencia;
        public empresa(string nom, string lic) : base(nom, lic)
        {
        }
    }
}
