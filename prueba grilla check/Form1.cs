using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_grilla_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Armo una lista.
            datos[] lista = new datos[3];
            datos a = new datos();
            a.cadena = "es true";
            a.Check = true;
            lista[0] = a;
            a = new datos();
            a.cadena = "es falso";
            a.Check = false;
            lista[1] = a;
            a = new datos();
            a.cadena = "otro verdadero";
            a.Check = true;
            lista[2] = a;


            dataGridView1.DataSource = lista;


        }
    }
}
