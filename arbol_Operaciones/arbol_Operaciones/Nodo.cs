using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_Operaciones
{
    class Nodo
    {
        private string _condicion { get; }
        public string condicion { get { return _condicion; } }

        public Nodo AIzq { get; set; }
        public Nodo ADrc { get; set; }
        public Nodo LSig { get; set; }
        public Nodo LAnt { get; set; }

        public Nodo(string nodo)
        {
            this._condicion = nodo;

            AIzq = null;
            ADrc = null;
            LSig = null;
            LAnt = null;
        }

        public override string ToString()
        {
            return _condicion + "";
        }
    }
}
