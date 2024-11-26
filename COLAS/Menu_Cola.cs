using Proyecto_Arbol.COLAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Final_Brindis.COLAS
{
    public class Menu_Cola
    {
        public static void Colas(string[] args)
        {
            // La iniciamos en null(vacia)
            Cola miCola = null;
            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Elige una de las siguientes opciones");
                Console.WriteLine();
                Console.WriteLine("1.- Ingresa el tamaño");
                Console.WriteLine("2.- Imprimir conteo");
                Console.WriteLine("3.- Insert");
                Console.WriteLine("4.- Extract");
                Console.WriteLine("5.- Imprimir Cola");
                Console.WriteLine("6.- Regresar");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el tamaño a la cola:");
                        int MAX = Convert.ToInt32(Console.ReadLine());
                        miCola = new Cola(MAX);
                        Console.WriteLine();
                        break;



                    case 2:
                        if (miCola != null)
                        {
                            miCola.Count();
                        }
                        else
                        {
                            Console.WriteLine("La cola no existe");
                        }
                        break;



                    case 3:
                        if (miCola != null)
                        {
                            Console.WriteLine("Ingrese valor");
                            int num = Convert.ToInt32(Console.ReadLine());
                            miCola.Insert(num);
                        }
                        else
                        {
                            Console.WriteLine("La cola no existe");
                        }
                        break;



                    case 4:
                        if (miCola != null)
                        {
                            miCola.Extract();
                        }
                        else
                        {
                            Console.WriteLine("La cola no existe");
                        }
                        break;



                    case 5:
                        if (miCola != null)
                        {
                            miCola.Print();
                        }
                        else
                        {
                            Console.WriteLine("La cola no existe");
                        }
                        break;



                    case 6:
                        Console.Clear();
                        Proyecto_Final_Brindis.Program.Main(new string[0]);
                        break;



                    default:
                        Console.WriteLine("Opció Incorrecta, selecciona otra");
                        break;
                }
            }
        }
    }
}
