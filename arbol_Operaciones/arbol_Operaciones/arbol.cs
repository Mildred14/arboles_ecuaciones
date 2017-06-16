using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_Operaciones
{
    class arbol
    {
        private Nodo inicio;
        private Nodo final;
        private Nodo raiz;
        private Nodo pila_Inicio;
        private Nodo pila_Final;
        private Nodo numeroPila;

        public void agregarLista(Nodo Nchar)
        {
            if (inicio == null)
                inicio = Nchar;
            else
                agregar(Nchar, inicio);
        }

        private void agregar(Nodo Nchar, Nodo ultimo)
        {
            if (ultimo.LSig == null)
            {
                ultimo.LSig = Nchar;
                Nchar.LAnt = ultimo;
                final = Nchar;
            }
            else
                agregar(Nchar, ultimo.LSig);
        }

        private void push(Nodo nChar)
        {
            if (pila_Inicio == null)
                pila_Inicio = nChar;
            else
                agregarAPila(nChar, pila_Inicio);
        }

        private void agregarAPila(Nodo nChar, Nodo ultimo)
        {
            if (ultimo.LSig == null)
            {
                ultimo.LSig = nChar;
                nChar.LAnt = ultimo;
                pila_Final = nChar;
            }
            else
                agregarAPila(nChar, ultimo.LSig);
        }

        private string pop()
        {
            string num;
            num = Convert.ToString(pila_Final.condicion);
            pila_Final = pila_Final.LAnt;
            if (pila_Final != null)
                pila_Final.LSig = null;
            return num;
        }

        public void crearArbol()
        {
            raiz = null;
            string charEv;

            Nodo arbolCreado = inicio, creadoAnterior = null, creadoSiguiente = null;
            //busca multiplicaciones y divisiones
            while (arbolCreado != null)
            {
                creadoSiguiente = arbolCreado.LSig;
                charEv = Convert.ToString(arbolCreado.condicion);
                if (charEv == "*" || charEv == "/")
                {
                    raiz = arbolCreado;
                    arbolCreado.AIzq = arbolCreado.LAnt; arbolCreado.ADrc = arbolCreado.LSig;
                    eliminarNodos(arbolCreado, creadoAnterior, creadoSiguiente);
                }
                creadoAnterior = arbolCreado; arbolCreado = arbolCreado.LSig;
            }

            arbolCreado = inicio; creadoAnterior = null; creadoSiguiente = null;
            //busca sumas y restas
            while (arbolCreado != null)
            {
                creadoSiguiente = arbolCreado.LSig;
                charEv = Convert.ToString(arbolCreado.condicion);
                if (charEv == "+" || charEv == "-")
                {
                    raiz = arbolCreado;
                    arbolCreado.AIzq = arbolCreado.LAnt; arbolCreado.ADrc = arbolCreado.LSig;
                    eliminarNodos(arbolCreado, creadoAnterior, creadoSiguiente);
                }
                creadoAnterior = arbolCreado; arbolCreado = arbolCreado.LSig;
            }
            inicio = null;
        }

        private void eliminarNodos(Nodo arbolCreado, Nodo creadoAnterior, Nodo creadoSiguiente)
        {
            if (arbolCreado.LAnt != inicio)
            {
                arbolCreado.LAnt = creadoAnterior.LAnt;
                creadoAnterior.LAnt.LSig = arbolCreado;
            }
            else
            {
                inicio = inicio.LSig;
                inicio.LAnt = null;
            }

            if (arbolCreado.LSig != final)
            {
                arbolCreado.LSig = creadoSiguiente.LSig;
                creadoSiguiente.LSig.LAnt = arbolCreado;
            }
            else
            {
                final.LAnt.LSig = null;
                final = final.LAnt;
            }
        }

        public string PostOrden()
        {
            if (raiz == null)
                return "";
            else
                return PostOrder(raiz);
        }

        private string PostOrder(Nodo r)
        {
            string lista = "";

            if (r.AIzq != null)
                lista += PostOrder(r.AIzq); // I

            if (r.ADrc != null)
                lista += PostOrder(r.ADrc);// D

            lista += r.ToString();// R

            return lista;
        }

        public string notacionPost()
        {
            int aP = 0;
            string res = ""; Nodo arbolCreado = inicio;

            while (arbolCreado != null)
            {
                if (Char.IsNumber(Convert.ToChar(arbolCreado.condicion)) == true)
                {
                    numeroPila = new Nodo(arbolCreado.condicion);
                    push(numeroPila);
                }
                else
                {
                    string cond = arbolCreado.ToString(), condC;
                    int n1 = Convert.ToInt32(pop()), n2 = Convert.ToInt32(pop());
                    switch (cond)
                    {
                        case "*":
                            aP = n2 * n1;
                            break;
                        case "/":
                            aP = n2 / n1;
                            break;
                        case "+":
                            aP = n2 + n1;
                            break;
                        case "-":
                            aP = n2 - n1;
                            break;
                    }
                    condC = Convert.ToString(aP);
                    numeroPila = new Nodo(condC);
                    push(numeroPila);
                }

                arbolCreado = arbolCreado.LSig;

                if (arbolCreado == null)
                    res = Convert.ToString(pop());
            }

            pila_Inicio = null;
            pila_Final = null;
            inicio = null;
            return res;
        }

        public string notacionPre()
        {
            int aP = 0;
            string res = ""; Nodo arbolCreado = final;

            while (arbolCreado != null)
            {
                if (Char.IsNumber(Convert.ToChar(arbolCreado.condicion)) == true)
                {
                    numeroPila = new Nodo(arbolCreado.condicion);
                    push(numeroPila);
                }
                else
                {
                    string cond = arbolCreado.ToString(), condC;
                    int n1 = Convert.ToInt32(pop()), n2 = Convert.ToInt32(pop());

                    switch (cond)
                    {
                        case "*":
                            aP = n1 * n2;
                            break;
                        case "/":
                            aP = n1 / n2;
                            break;
                        case "+":
                            aP = n1 + n2;
                            break;
                        case "-":
                            aP = n1 - n2;
                            break;
                    }
                    condC = Convert.ToString(aP);
                    numeroPila = new Nodo(condC);
                    push(numeroPila);
                }
                arbolCreado = arbolCreado.LAnt;
                if (arbolCreado == null)
                    res = Convert.ToString(pop());
            }
            pila_Inicio = null;
            pila_Final = null;
            inicio = null;
            return res;
        }

        public string PreOrden()
        {
            if (raiz == null)
                return "";
            else
                return PreOrder(raiz);
        }

        private string PreOrder(Nodo r)
        {
            string lista = "";

            lista += r.ToString();// R

            if (r.AIzq != null)
                lista += PreOrder(r.AIzq); // I

            if (r.ADrc != null)
                lista += PreOrder(r.ADrc);// D

            return lista;
        }

        public string reporte()
        {
            string infoLista = "";

            Nodo datoActual = pila_Inicio;
            while (datoActual != null) //recorre la lista
            {
                infoLista += datoActual.ToString();
                datoActual = datoActual.LSig;
            }

            return infoLista;
        }


    }
}
