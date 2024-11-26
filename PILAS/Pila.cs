﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol.PILAS
{
    internal class Pila
    {
        //atributos
        private int MAX;
        private int tope = 0;
        
        private Nodo inicio;

        //contructor
        public Pila(int max)
        {
            MAX = max;
            inicio = null;
        }



        private bool Empty()
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



        private bool Full()
        {
            if (MAX == tope)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void Long(int longs)
        {
            MAX = longs;
            Console.WriteLine("Ingresa el nuevo tamaño");

            // Si el nuevo tamaño es menor que el número de elementos actuales
            // eliminamos los elementos excedentes.
            while (tope > MAX)
            {
                Pop();
            }
        }



        public void Print()
        {
            // Imprimir Pila

            if (Empty())
            {
                // Empty porque la pila esta vacia.
                Console.WriteLine("Empty");
                return;
            }

            Nodo actual = inicio;
            Console.WriteLine("Elementos en la pila:");

            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Sig;
            }
        }



        public bool Push(int num)
        {
            // Regresa "true" si se inserto el elemento
            // de forma exitosa
            // regresa "false" si no se pudo insertar o porque la pila esta en "Full" (llena).

            if (Full())
            {
                Console.WriteLine("FULL");
                return false;
            }

            Nodo nuevoNodo = new Nodo(num);

            nuevoNodo.Sig = inicio;
            inicio = nuevoNodo;
            tope++;

            Console.WriteLine("true");
            return true;
        }



        public int Pop()
        {
            // Regresa el valor sacado, que es el ultimo elemento
            // pero, si no se pudo, que regrese -1  

            if (Empty())
            {
                return -1;
            }

            int valorEliminado = inicio.Valor;
            inicio = inicio.Sig;
            tope--;

            return valorEliminado;
        }


    }
}
