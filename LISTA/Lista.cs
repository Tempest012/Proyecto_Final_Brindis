using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol.LISTA
{
    internal class Lista
    {
        private Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        //Metodo para insertar o ingresar valores al nodo 
        public void Add()
        {
            Console.WriteLine("Ingrese un valor");
            int valor = Convert.ToInt32(Console.ReadLine());

            Nodo nuevo = new Nodo(valor);

            //Saber si la lista esta vacia
            if (inicio == null)
            {

                inicio = nuevo;
            }
            else
            {
                Nodo actual = inicio;

                //recorre hasta el ultimo nodo o elemento
                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                // agregamos al final de la lista
                actual.Sig = nuevo;
            }
            Console.WriteLine();
            Console.WriteLine($"El valor {valor} ha sido insertado.");
            Console.WriteLine();
            Console.WriteLine();
        }


        // Imprimir todos los valores
        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual;
            actual = inicio;

            Console.Write("Valores en la lista:");
            Console.WriteLine();

            // Recorremos toda la lista e imprimimos los valores de cada nodo
            while (actual != null)
            {
                Console.Write($"[{actual.Valor}] ");
                actual = actual.Sig;
                // Avanzar al siguiente nodo
            }
            Console.WriteLine();
        }

        //Imprime el tamaño de la lista o imprime la longitud de la lista, contando cada nodo.
        public int Count()
        {
            // Si la lista está vacía
            if (inicio == null)
            {
                Console.WriteLine("0");
                return 0;
            }

            Nodo actual = inicio;
            int contador = 0;

            // Recorremos la lista para contar los nodos
            while (actual != null)
            {
                contador++;
                actual = actual.Sig;
            }


            Console.WriteLine($"La lista tiene {contador} nodos");
            return contador;
        }



        //Ingresamos la posicion que queremos buscar, para que nos imprima la valor dentro de ese nodo.
        public int Find(int pos)
        {
            Nodo actual = inicio;

            // si la lista esta vacia
            if (inicio == null)
            {
                Console.WriteLine("0");
                return 0;
            }

            int contador = 0;

            // recorremo la lista hasta encontrar el nodo
            while (actual != null)
            {
                if (contador == pos)
                {
                    Console.WriteLine($"El valor en la posición {pos} es: {actual.Valor}");
                    return actual.Valor;
                }
                actual = actual.Sig;
                contador++;
            }

            // si sale del bucle, posicion invalida
            Console.WriteLine();
            Console.WriteLine($"-1");
            return -1;
        }

        //Ingresa el valor a buscar y imprime los nodos que tienen ese valor
        public int FindValue(int num)
        {
            Nodo actual = inicio;

            int posicion = 0;
            bool encontrado = false;

            // si la lista está vacía
            if (inicio == null)
            {
                Console.WriteLine();
                Console.WriteLine("0");
                return -1;
            }


            // recorremos la lista para buscar el valor
            while (actual != null)
            {
                if (actual.Valor == num)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Esta en la posición {posicion}.");
                    encontrado = true;
                }

                actual = actual.Sig;
                posicion++;
            }

            if (!encontrado)
            {
                Console.WriteLine();
                Console.WriteLine($"-1");
                return -1;
            }

            return 0; // Si se encontró al menos un valor, se retorna 0
        }


        public bool Change(int pos, int valor)
        {
            Nodo actual = inicio;

            // Verificar si la lista está vacía
            if (inicio == null)
            {
                Console.WriteLine("False");
                return false;
            }

            int contador = 0;

            // Recorremos la lista hasta encontrar el nodo en la posición indicada
            while (actual != null)
            {
                if (contador == pos)
                {
                    // Si se encuentra la posición, modificar el valor del nodo
                    int valorAntiguo = actual.Valor;
                    actual.Valor = valor;
                    Console.WriteLine("True");
                    return true;
                }
                actual = actual.Sig;
                contador++;
            }

            // Si se recorre toda la lista y no se encuentra la posición
            Console.WriteLine("False");
            return false;
        }



        public bool Delete(int pos)
        {
            Nodo actual = inicio;
            Nodo anterior = null;

            // Verificar si la lista está vacía
            if (inicio == null)
            {
                Console.WriteLine("False");
                return false;
            }

            // Si la posición es 0, eliminamos el primer nodo
            if (pos == 0)
            {

                inicio = inicio.Sig;
                Console.WriteLine("True");
                return true;
            }

            int contador = 0;

            // Recorremos la lista hasta encontrar el nodo en la posición indicada
            while (actual != null && contador < pos)
            {
                anterior = actual;
                actual = actual.Sig;
                contador++;
            }

            // Si salimos del bucle y actual es null, significa que la posición no es válida
            if (actual == null)
            {
                Console.WriteLine("False");
                return false;
            }

            // Ajustamos las referencias para eliminar el nodo
            anterior.Sig = actual.Sig; // El nodo anterior ahora apunta al siguiente nodo de actual
            Console.WriteLine("True");
            return true;
        }



    }
}
