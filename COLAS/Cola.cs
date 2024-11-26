using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol.COLAS
{
    internal class Cola
    {
        private int MAX;
        private int count = 0;
        private Nodo inicio;

        public Cola(int max)
        {
            MAX = max;
            inicio = null;
        }

        //Cola vacio
        private bool Underflow()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Cola llena
        private bool Overflow()
        {
            if (MAX == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Insert(int num)
        {
            // Regresa "true", si se inserto exitosamente.
            // Regresa "false", si la cola esta llena.


            if (Overflow())
            {
                Console.WriteLine("false");
                return false;
            }

            Nodo nuevoNodo = new Nodo(num);

            if (inicio == null)
            {
                // Si está vacía, el nuevo nodo es el inicio de la cola
                inicio = nuevoNodo;
            }
            else
            {
                // Si no está vacía, recorrer la cola hasta el final e insertar el nodo
                Nodo actual = inicio;
                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevoNodo;
            }
            count++;

            Console.WriteLine("true");
            return true;
        }



        public int Extract()
        {
            // Regresa el numero sacado de la cola o
            // Regresa "-1", si la cola esta vacia.


            if (Underflow())
            {
                Console.WriteLine("-1");
                return -1;
            }

            // Obtener el valor del nodo al inicio de la cola
            int valorExtraido = inicio.Valor;
            inicio = inicio.Sig;
            count--;

            Console.WriteLine($"Valor sacado {valorExtraido}");
            return valorExtraido;
        }



        public int Count()
        {
            Console.WriteLine($"Tiene {count} elementos.");
            return count;
        }



        public void Print()
        {
            // Imprimir todos los elementos que estan en la cola.

            if (Underflow())
            {
                Console.WriteLine("Underflow");
                return;
            }

            Nodo actual = inicio;

            while (actual != null)
            {
                Console.WriteLine($"| {actual.Valor} |");
                actual = actual.Sig;
            }
            Console.WriteLine();
        }



    }
}
