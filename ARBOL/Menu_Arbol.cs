using Proyecto_Arbol.ARBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Brindis.ARBOL
{
    public class Menu_Arbol
    {
        public static void Arboles(string[] args)
        {
            Arbol miArbol = new Arbol();

            int opcion = 0;


            while (opcion != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine();
                Console.WriteLine("1.- Insertar nodo");
                Console.WriteLine("2.- Tamaño");
                Console.WriteLine("3.- Altura");
                Console.WriteLine("4.- LRP");
                Console.WriteLine("5.- Recorrido");
                Console.WriteLine("6.- Regresar");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine( );
                        Console.WriteLine("Ingrese valor al albol");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        miArbol.Insertar(valor);
                        break;



                    case 2:
                        Console.WriteLine($"El tamaño del arbol es {miArbol.Tamaño(miArbol.raiz)}");
                        break;



                    case 3:
                        Console.WriteLine($"El altura del arbol es {miArbol.Altura(miArbol.raiz)}");
                        break;



                    case 4:
                        miArbol.LRP();
                        break;



                    case 5:
                        miArbol.Recorrido(miArbol.raiz);
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