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
            LinkedList<persona> perl= new LinkedList<persona>();
            LinkedList<empresa> empl = new LinkedList<empresa>();
            LinkedList<insorg> insl = new LinkedList<insorg>();

            LinkedList<Sucursal> registro = new LinkedList<Sucursal>();


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
                Console.WriteLine("cliente nuevo (1)si(2)no");
                string c1 = Console.ReadLine();
                if (c1 == "1")
                {
                    Console.WriteLine("nombre");
                    string c11 = Console.ReadLine();
                    Console.WriteLine("(1)Empresa(2)persona(3)intittucion u organizacion");
                    string c4 = Console.ReadLine();
                    if (c4 == "1")
                    {
                        Console.WriteLine("permiso(A1) o (A2)");
                        string c5 = Console.ReadLine();
                        empresa em1 = new empresa(c11, c5);
                        empl.AddLast(em1);
                    }
                    if (c4 == "2")
                    {
                        Console.WriteLine("Licencia (B)auto(C)moto");
                        string c5 = Console.ReadLine();
                        persona per = new persona(c11, c5);
                        perl.AddLast(per);
                    }
                    if (c4 == "3")
                    {
                        Console.WriteLine("Permiso (A3) o (A4)");
                        string c5 = Console.ReadLine();
                        
                        insorg ins = new insorg(c11, c5);

                        insl.AddLast(ins);
                    }
                    Console.WriteLine("tipo de vehiculo; auto - camion - bus - moto - maq pesada");
                    string c3 = Console.ReadLine();

                    Console.WriteLine("Cuantas horas?");
                    string c6 = Console.ReadLine();
                    int c7 = int.Parse(c6);
                    Sucursal s = new Sucursal(c11, c3, c7, a);


                }
                else
                {


                    Console.WriteLine("nombre");
                    string c11 = Console.ReadLine();
                    Console.WriteLine("(1)Empresa(2)persona(3)intittucion u organizacion");
                    string c4 = Console.ReadLine();
                    if (c4 == "1")
                    {
                        Console.WriteLine("permiso(A1) o (A2)");
                        string c5 = Console.ReadLine();
                    }
                    if (c4 == "2")
                    {
                        Console.WriteLine("Licencia (B)auto(C)moto");
                        string c5 = Console.ReadLine();
                    }
                    if (c4 == "3")
                    {
                        Console.WriteLine("Permiso (A3) o (A4)");
                        string c5 = Console.ReadLine();
                    }

                    Console.WriteLine("tipo de vehiculo; auto - camion - bus - moto - maq pesada");
                    string c3 = Console.ReadLine();
                   

                    Console.WriteLine("Cuantas horas?");
                    string c6 = Console.ReadLine();
                    int c7 = int.Parse(c6);
                    Sucursal s = new Sucursal(c11, c3, c7,a);
                }

                break;


            }
            Console.WriteLine("");
            string d = Console.ReadLine();


            Console.ReadLine();
        }
    }
    
    
}
