using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class Nodo_de_Arbol
    {
        private int valor;
        private Nodo_de_Arbol izq;
        private Nodo_de_Arbol der;


        public Nodo_de_Arbol(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }


        public int Valor { get => valor; set => valor = value; }
        internal Nodo_de_Arbol Izq { get => izq; set => izq = value; }
        internal Nodo_de_Arbol Der { get => der; set => der = value; }
    }
}
