using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static bool Revisar(string v3, string v2)
        {

            if (v3 == v2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            LinkedList<Vehiculos> vehiculo = new LinkedList<Vehiculos>();

            LinkedList<persona> perl = new LinkedList<persona>();
            LinkedList<empresa> empl = new LinkedList<empresa>();
            LinkedList<institucion> insl = new LinkedList<institucion>();
            LinkedList<organizacion> orgl = new LinkedList<organizacion>();

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
                Console.WriteLine("tipo de vehiculo, auto - camion - bus - moto - maq pesada");
                string b1 = Console.ReadLine();
                Console.WriteLine("precio hora");
                string b2 = Console.ReadLine();
                int b22 = int.Parse(b2);
                Console.WriteLine("tipo licencia, respectivo; B, A1, A2, C, A3 ");
                string b3 = Console.ReadLine();
                Vehiculos nuevo = new Vehiculos(b1, b22, b3);

                Console.WriteLine("Desea agregar otro?(1)si(2)no");
                string b4 = Console.ReadLine();
                if (b4 == "2")
                {
                    break;
                }
            }
            foreach (Vehiculos i in vehiculo)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("¿desea arrendar un vehiculo? (1)si (2)no");
            string c = Console.ReadLine();
            Console.WriteLine("tipo de vehiculo; auto - camion - bus - moto - maq pesada");
            string c3 = Console.ReadLine();
            string c13;
            if (c3 == "auto")
            {
                c13 = "B";
            }
            if (c3 == "camion")
            {
                c13 = "A1";
            }
            if (c3 == "bus")
            {
                c13 = "A2";
            }
            if (c3 == "moto")
            {
                c13 = "C";
            }
            if (c3 == "maq pesada")
            {
                c13 = "A3";
            }
            Console.WriteLine("accesorios?(1)nada(2)silla guaguas (3)GPS");
            string c9= Console.ReadLine();
            Console.WriteLine("Cuantas horas?");
            string c6 = Console.ReadLine();
            int c7 = int.Parse(c6);
            
            if (c == "2")
            {
                Console.WriteLine("muchas gracias!");
            }
            while (c == "1")
            {
                Console.WriteLine("nombre");
                string c11 = Console.ReadLine();
                Console.WriteLine("cliente nuevo (1)si(2)no");
                string c1 = Console.ReadLine();
                if (c1 == "1")
                {
                    Console.WriteLine("(1)Empresa(2)persona(3)intittucion (4)organizacion");
                    string c4 = Console.ReadLine();
                    if (c4 == "1")
                    {

                        Console.WriteLine("permiso: B,A1, A2, C, A3");
                        string c5 = Console.ReadLine();
                        empresa em1 = new empresa(c11, c5);
                        empl.AddLast(em1);
                        /*
                        bool re = Revisar(c13, c5 ); no entiendo pq no reconoce 13
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
                        */
                        if (c3 == "maq pesada")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0,101);
                            int rd1 = 63;
                            if (rd2 > rd1)
                            {
                                Console.WriteLine("No puede arrendar por falta de permiso");
                            }
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 80;
                            if (rd2 >= rd1)
                            {
                                Console.WriteLine("No puede arrendar");
                            }

                            else
                            {
                                Console.WriteLine("bus liviano, normal, de lujo?");
                                string b1 = Console.ReadLine();
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                   
                    }

                    if (c4 == "2") 
                    {
                        Console.WriteLine("Licencia:B,A1,C, A3");
                        string c5 = Console.ReadLine();
                        persona per = new persona(c11, c5);
                        perl.AddLast(per);
                        if (c3 == "bus")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                      
                    }
                    if (c4 == "3") //institucion
                    {
                        Console.WriteLine("permiso: B,A1, A2, C, A3");
                        string c5 = Console.ReadLine();
                        institucion ins = new institucion(c11, c5);
                        insl.AddLast(ins);
                        if (c3 == "maq pesada")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 58;
                            if (rd2 > rd1)
                            {
                                Console.WriteLine("No puede arrendar ");
                            }

                            else
                            {
                                Console.WriteLine("liviano, normal, de lujo?");
                                string b1 = Console.ReadLine();
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                       
                    }
                    if (c4 == "4")
                    {
                        Console.WriteLine("permiso: B,A1, A2, C, A3");
                        string c5 = Console.ReadLine();
                        organizacion og = new organizacion(c11, c5);
                        orgl.AddLast(og);
                        if (c3 == "maq pesada")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 58;
                            if (rd2 > rd1)
                            {
                                Console.WriteLine("No puede arrendar ");
                            }
                            if (rd2 <= rd1)
                            {
                                string b1 = "normal";
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                      

                    }
                }
                else
                {
                    Console.WriteLine("(1)Empresa(2)persona(3)intittucion (4)organizacion");
                    string c4 = Console.ReadLine();
                    string licen;
                    if (c4 == "1")
                    {
                        if (c3 == "maq pesada")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 63;
                            if (rd2 >= rd1)
                            {
                                Console.WriteLine("No puede arrendar por falta de permiso");
                            }
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 80;
                            if (rd2 >= rd1)
                            {
                                Console.WriteLine("No puede arrendar");
                            }

                            else
                            {
                                Console.WriteLine("bus liviano, normal, de lujo?");
                                string b1 = Console.ReadLine();
                            }
                        }
                        foreach (empresa j in empl)
                        {
                            string j1 = j.getnombre();
                            if (c11 ==  j1)
                            {
                                licen = j.getlicencia();
                                break;
                            }
                        }

                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                        
                    }

                    if (c4 == "2") //persona
                    {
                        if (c3 == "bus")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        foreach (persona j in perl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                licen = j.getlicencia();
                                break;
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                     
                    }
                    if (c4 == "3") //institucion
                    {
                        if (c3 == "maq pesada")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 58;
                            if (rd2 > rd1)
                            {
                                Console.WriteLine("No puede arrendar ");
                            }
                            else
                            {
                                Console.WriteLine("liviano, normal, de lujo?");
                                string b1 = Console.ReadLine();
                            }
                        }
                            
                        foreach (institucion j in insl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                licen = j.getlicencia();
                                break;
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                       
                    }
                    if (c4 == "4") //organizacion
                    {
                        if (c3 == "maq pesada")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        if (c3 == "bus")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
                            int rd1 = 58;
                            if (rd2 > rd1)
                            {
                                Console.WriteLine("No puede arrendar ");
                            }
                            if (rd2 <= rd1)
                            {
                                string b1 = "normal";
                            }
                        }
                        foreach (organizacion j in orgl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                licen = j.getlicencia();
                                break;
                            }
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                       

                    }

                }
                finish:
                Console.WriteLine("otro?(1)si(2)no");
                string g = Console.ReadLine();
                if (g == "2")
                {
                    break;
                }
            }
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
    

