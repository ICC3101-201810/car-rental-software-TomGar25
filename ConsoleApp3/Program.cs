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
            star2:

            Console.WriteLine("Bienvenid@, Ingrese numero de sucursal");
            string a = Console.ReadLine();


            bool a1 = suc.Contains(a);
            if (a1 == false)
            {
                suc.AddLast(a);
            }
            Console.Beep();
            Console.WriteLine("¿desea agregar vehiculos? (1)si (2)no");
            string b = Console.ReadLine();
            if (b == "2")
            {
                goto star1;
            }
            while (b == "1")
            {
                Console.WriteLine("tipo de vehiculo\n auto\n camion\n bus\n moto\n maq pesada\n Ingrese:");
                string b1 = Console.ReadLine();
                if (b1 == "auto")
                {

                }
                Console.WriteLine("precio hora");
                string b2 = Console.ReadLine();
                int b22 = int.Parse(b2);
                Console.WriteLine("tipo licencia, respectivo; B, A1, A2, C, A3 ");
                string b3 = Console.ReadLine();
                Vehiculos nuevo = new Vehiculos(b1, b22, b3);
                vehiculo.AddFirst(nuevo);

                Console.WriteLine("Desea agregar otro?(1)si(2)no");
                string b4 = Console.ReadLine();
                if (b4 == "2")
                {
                    break;
                }
            }
            star1:
            Console.Clear();
            foreach (Vehiculos i in vehiculo)
            {
                i.impirmir();

            }


            Console.WriteLine("¿desea arrendar un vehiculo? (1)si (2)no");
            string c = Console.ReadLine();
            if (c == "2")
            {
                Console.WriteLine("muchas gracias!");
                goto star2;
            }
            otroarrendado:

            Console.WriteLine("tipo de vehiculo; auto - camion - bus - moto - maq pesada");
            string c3 = Console.ReadLine();
            string c13 = "B";
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

            if (c3 == "auto")
            {
                Console.WriteLine("accesorios?(1)nada(2)asientos extra (3)electrico (4)maletero mas grandre (5)Reproductor dvd");
                string c9 = Console.ReadLine();
            }

            Console.WriteLine("Cuantas horas?");
            string c7 = Console.ReadLine();



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

                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }

                        if (c3 == "maq pesada")
                        {
                            Random rd = new Random();
                            int rd2 = rd.Next(0, 101);
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
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                    }

                    if (c4 == "2") //persona
                    {
                        Console.WriteLine("Licencia:B,A1,C, A3");
                        string c5 = Console.ReadLine();
                        bool re = Revisar(c13, c5);
                        persona per = new persona(c11, c5);
                        perl.AddLast(per);

                        if (re == false)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
                        if (c3 == "bus")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }
                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                        

                    }
                    if (c4 == "3") //institucion
                    {
                        Console.WriteLine("permiso: B,A1, A2, C, A3");
                        string c5 = Console.ReadLine();
                        institucion ins = new institucion(c11, c5);
                        insl.AddLast(ins);
                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
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
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                    }
                    if (c4 == "4") //org
                    {
                        Console.WriteLine("permiso: B,A1, A2, C, A3");
                        string c5 = Console.ReadLine();
                        organizacion og = new organizacion(c11, c5);
                        orgl.AddLast(og);

                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
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
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }


                    }
                }
                else
                {
                    string c5 = "";
                    Console.WriteLine("(1)Empresa(2)persona(3)intittucion (4)organizacion");
                    string c4 = Console.ReadLine();

                    if (c4 == "1")
                    {

                        foreach (empresa j in empl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                c5 = j.getlicencia();
                                break;
                            }
                        }
                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
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


                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                    }

                    if (c4 == "2") //persona
                    {
                        foreach (persona j in perl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                c5 = j.getlicencia();
                                break;
                            }
                        }
                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
                        if (c3 == "bus")
                        {
                            Console.WriteLine("No puede arrendar ");
                        }

                        Sucursal na = new Sucursal(c11, c3, c7, a);
                        registro.AddFirst(na);
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }
                    }
                    if (c4 == "3") //institucion
                    {
                        foreach (institucion j in insl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                c5 = j.getlicencia();
                                break;
                            }
                        }
                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
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
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                    }
                    if (c4 == "4") //organizacion
                    {
                        foreach (organizacion j in orgl)
                        {
                            string j1 = j.getnombre();
                            if (c11 == j1)
                            {
                                c5 = j.getlicencia();
                                break;
                            }
                        }
                        bool re = Revisar(c13, c5);
                        if (re != true)
                        {
                            Console.WriteLine("No tiene la licencia");
                            goto finish;
                        }
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
                        foreach (Vehiculos tem in vehiculo)
                        {
                            string veic = tem.getnombre();
                            if (c3 == veic)
                            {
                                vehiculo.Remove(tem);
                                break;
                            }
                        }

                    }

                }

                //Console.Clear();
                break;
            }
            finish:
            Console.WriteLine("Arrendar otro?(1)si(2)no");
            string g = Console.ReadLine();
            if (g == "1")
            {
                goto otroarrendado;
            }
            Console.Clear();
            foreach (Vehiculos i in vehiculo)
            {
                i.impirmir();

            }

            foreach (Sucursal im in registro)
            {
                im.imp();
            }
            Console.WriteLine("pulsar cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}
    

