using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Sucursal
    {
        
        string nombre;
        string vec;
        int horas;
        persona t1;
        insorg t2;
        empresa t3;
        string sucu;

        public Sucursal(string n, string v, int h,  string su)
        {
            nombre = n;
            vec = v;
            horas = h;
            sucu = su;
        }
        public void revisar()
        {
            if (t3.licencia != "A1")
            {
                
                Console.WriteLine("No puede arrendar por permiso");
            }
      
    
        }
       
        //accesoriosd 
        //suma total
      
        

    }
}
