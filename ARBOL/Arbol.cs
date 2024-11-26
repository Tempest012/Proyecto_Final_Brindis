using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyecto_Arbol.ARBOL
{
    internal class Arbol
    {
        public Nodo_de_Arbol raiz;
        private Nodo_de_Arbol obs; // "obs", es el observador.

        public void Recorrido(Nodo_de_Arbol q)
        {
            if (q != null)
            {
                Console.Write($"{q.Valor},");
                Recorrido(q.Izq);
                Console.Write($"{q.Valor},");
                Recorrido(q.Der);
                Console.Write($"{q.Valor},");
            }
        }



        private bool FindKey(int v)
        {
            Boolean Found = false;
            Nodo_de_Arbol q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.Valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.Valor)
                    {
                        if (q.Izq == null)
                            obs = q;
                        q = q.Izq;

                    }
                    else
                    {
                        if (q.Der == null)
                            obs = q;
                        q = q.Der;
                    }

                }
            }
            return Found;
        }



        public void Insertar(int v)
        {
            Nodo_de_Arbol nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = FindKey(v);

            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else
            {
                nuevo = new Nodo_de_Arbol(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.Valor)
                        obs.Izq = nuevo;
                    else
                        obs.Der = nuevo;
                    obs = nuevo;
                }
                Console.WriteLine("Ingreso exitoso");
            }
        }



        // Tamaño 
        public int Tamaño(Nodo_de_Arbol nodo)
        {
            if (nodo == null) return 0;
            return 1 + Tamaño(nodo.Izq) + Tamaño(nodo.Der);
        }



        // Altura
        public int Altura(Nodo_de_Arbol nodo)
        {
            if (nodo == null) return 0;
            int alturaIzq = Altura(nodo.Izq);
            int alturaDer = Altura(nodo.Der);
            return 1 + Math.Max(alturaIzq, alturaDer);
        }



        public void LRP()
        {
            int sumatoria = 0;
            int tamaño = Tamaño(raiz);
            CalcularSumatoria(raiz, 1, ref sumatoria); // La raíz empieza con profundidad 1

            if (tamaño == 0)
            {
                Console.WriteLine("El árbol está vacío, LRP no es aplicable.");
                return;
            }

            double lrp = (double)sumatoria / tamaño - 0.01;
            Console.WriteLine($"El LRP del árbol es: {lrp:F2}");
        }

        private void CalcularSumatoria(Nodo_de_Arbol nodo, int profundidad, ref int sumatoria)
        {
            if (nodo != null)
            {
                sumatoria += profundidad; // Acumula la profundidad del nodo actual
                CalcularSumatoria(nodo.Izq, profundidad + 1, ref sumatoria); // Recorre subárbol izquierdo
                CalcularSumatoria(nodo.Der, profundidad + 1, ref sumatoria); // Recorre subárbol derecho
            }
        }

    }
}
