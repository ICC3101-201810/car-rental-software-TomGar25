using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Vehiculos
    {
        
        string ve;
        Int32 prehora;
        string licen;
        public Vehiculos(string vehiculo, Int32 precio,string lic)
        {
            ve = vehiculo;
            prehora = precio;
            licen = lic

        }
        
        public void impirmir()
        {
            Console.WriteLine("tipo de vehiculo: "+ ve+", precio: "+ prehora+", tipo lic. : "+ licen);
        }




    }
}

