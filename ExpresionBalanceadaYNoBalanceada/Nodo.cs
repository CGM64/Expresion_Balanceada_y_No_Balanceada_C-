using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionBalanceadaYNoBalanceada
{
    class Nodo
    {
        private char dato;
        private Nodo siguiente = null;

        public char Dato
        {
            get => dato;
            set => dato = value;
        }

        internal Nodo Siguiente
        {
            get => siguiente;
            set => siguiente = value;
        }


        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
