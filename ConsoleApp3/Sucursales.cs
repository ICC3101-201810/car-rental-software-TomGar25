using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Sucursal
    {
        string nombre;
        string vec;
        string horas;
        string sucu;

        public Sucursal(string n, string v, string h, string su)
        {
            nombre = n;
            vec = v;
            horas = h;
            sucu = su;
        }
        public void imp()
        {

            Console.WriteLine(nombre, "Arrendo ");
        }
        
        
    }
}
