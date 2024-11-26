using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Arbol
{
    internal class Nodo
    {
        // VARIABLES
        private int valor;
        private Nodo sig;



        // CONSTRUCTOR
        public Nodo(int Valor)
        {
            valor = Valor;
            sig = null;
        }


        // EMCAPSULANDO DATOS
        public int Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}
