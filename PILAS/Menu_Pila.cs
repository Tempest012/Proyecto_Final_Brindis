using Proyecto_Arbol.PILAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Brindis.PILAS
{
    public class Menu_Pila
    {
        public static void Pilas(string[] args)
        {
            // La iniciamos en null(vacia)
            Pila miPila = null;
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Elige una de las siguientes opciones");
                Console.WriteLine();
                Console.WriteLine("1.- Ingresa el tamaño");
                Console.WriteLine("2.- Push");
                Console.WriteLine("3.- Pop");
                Console.WriteLine("4.- Print");
                Console.WriteLine("5.- Regresar");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        if (miPila == null)
                            Console.WriteLine("Ingrese el tamaño máximo de la pila:");
                        int MAX = Convert.ToInt32(Console.ReadLine());
                        miPila = new Pila(MAX);
                        Console.WriteLine("");
                        break;



                    case 2:

                        if (miPila != null)
                        {
                            Console.WriteLine("Ingrese el número a agregar a la pila:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            miPila.Push(num);
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                        break;



                    case 3:
                        if (miPila != null)
                        {
                            int eliminado = miPila.Pop();
                            if (eliminado != -1)
                            {
                                Console.WriteLine($"Eliminado {eliminado}");
                            }
                            else
                            {
                                Console.WriteLine("-1");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No existe");
                        }
                        break;



                    case 4:
                        if (miPila != null)
                        {
                            miPila.Print();
                        }
                        else
                        {
                            Console.WriteLine("No exites");
                        }
                        break;



                    case 5:
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
