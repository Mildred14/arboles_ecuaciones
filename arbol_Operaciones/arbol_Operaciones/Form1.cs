using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol_Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nodo charExp;
        arbol arbol = new arbol();
        private void resolver_Click(object sender, EventArgs e)
        {
            string ecuacion = txtEc.Text;

            char[] array = ecuacion.ToCharArray(); //pasa la exprecion a char dentro de un vectror;

            foreach (char charr in array) //pasa el vector a una lista
            {
                charExp = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(charExp);
            }

            //txtEc.Text = ar.reporte();            
            arbol.crearArbol();

            txtPost.Text = arbol.PostOrden();
            txtPre.Text = arbol.PreOrden();
        }

        private void evaluarPost_Click(object sender, EventArgs e)
        {
            string lPost = txtPost.Text;

            char[] array = lPost.ToCharArray();

            foreach (char charr in array)
            {
                charExp = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(charExp);
            }

            txtResPost.Text = arbol.notacionPost();
        

        }
        private void evaluarPre_Click(object sender, EventArgs e)
        {
            string lPre = txtPre.Text;

            char[] array = lPre.ToCharArray();

            foreach (char charr in array)
            {
                charExp = new Nodo(Convert.ToString(charr));
                arbol.agregarLista(charExp);
            }

            txtResPre.Text = arbol.notacionPre();
        }

    }
}