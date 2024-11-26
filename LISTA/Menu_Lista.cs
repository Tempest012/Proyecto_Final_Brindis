using Proyecto_Arbol.LISTA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Brindis.LISTA
{
    public class Menu_Lista
    {
        public static void Listas(string[] args)
        {
            Lista miLista = new Lista();

            int opcion = 0;

            while (opcion != 8)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Elige una de las siguientes opciones");
                Console.WriteLine();
                Console.WriteLine("1.- Add");
                Console.WriteLine("2.- Count");
                Console.WriteLine("3.- Find");
                Console.WriteLine("4.- Delete");
                Console.WriteLine("5.- Change");
                Console.WriteLine("6.- FindValue");
                Console.WriteLine("7.- Print");
                Console.WriteLine("8.- Regresar");
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        miLista.Add();
                        break;


                    case 2:
                        miLista.Count();
                        break;


                    case 3:
                        Console.WriteLine("Ingrese la posición del nodo a buscar:");
                        int posicion = Convert.ToInt32(Console.ReadLine());
                        miLista.Find(posicion);
                        break;


                    case 4:
                        Console.WriteLine("Ingrese la posición del nodo a eliminar:");
                        int posicionEliminar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        miLista.Delete(posicionEliminar);
                        break;


                    case 5:
                        Console.WriteLine("Ingrese la posición del nodo a cambiar:");
                        int posicionCambio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el nuevo valor:");
                        int nuevoValor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        miLista.Change(posicionCambio, nuevoValor);
                        break;


                    case 6:
                        Console.WriteLine("Ingrese el valor a buscar:");
                        int valorBuscar = Convert.ToInt32(Console.ReadLine());
                        miLista.FindValue(valorBuscar);
                        break;


                    case 7:
                        miLista.Print();
                        break;


                    case 8:
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