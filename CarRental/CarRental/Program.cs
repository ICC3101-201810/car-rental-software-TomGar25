using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Vehiculos> vehiculo = new LinkedList<Vehiculos>();
            LinkedList<Clientes> clientel= new LinkedList<Clientes>();
            LinkedList<string> suc = new LinkedList<string>();

            Console.WriteLine("Bienvenid@, Ingrese numero de sucursal");
            string a = Console.ReadLine();

            bool a1 = suc.Contains(a);
            if (a1 == false)
            {
                suc.AddLast(a);
            }
            Console.WriteLine("¿desea agregar vehiculos? (1)si (2)no");
            string b = Console.ReadLine();
            while (b == "1")
            {
                Console.WriteLine("tipo de vehiculo");
                string b1 = Console.ReadLine();
                Console.WriteLine("precio hora");
                string b2 = Console.ReadLine();
                int b22 = int.Parse(b2);
                Console.WriteLine("tipo licencia");
                string b3 = Console.ReadLine();
                Vehiculos nuevo = new Vehiculos(b1,b22,b3);

                Console.WriteLine("Desea agregar otro?(1)si(2)no");
                string b4 = Console.ReadLine();
                if (b4=="2")
                {
                    break;
                }
            }
            Console.WriteLine("¿desea arrendar un vehiculo? (1)si (2)no");
            string c = Console.ReadLine();
            while (c == "1")
            {
                Console.WriteLine("cliente nuevo?(1)si(2)no");
                string c1 = Console.ReadLine();
                if (c1 == "1")
                {
                    Console.WriteLine("nombre");
                    string c2 = Console.ReadLine();
                    Console.WriteLine("tipo de licencia");
                    string c3 = Console.ReadLine();

                 

                }
                
                
  
                
            }

            Console.WriteLine("Nuestros vehiculos disponibles son:");
            foreach (Vehiculos vh in vehiculo)
            {
                vh.impirmir();
            }
            
         

            Console.ReadLine();
        }
    }
    
    
}
