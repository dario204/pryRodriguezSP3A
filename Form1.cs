using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP3A
{
    public partial class Form1 : Form
    {
        //Declaracion de variables globales
        int numeroTurno;
        string Dominio;
        int añoFabricacion;
        string titular;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            numeroTurno = int.Parse(txtNumero.Text);
            Dominio = txtDominio.Text;
            añoFabricacion = Convert.ToInt32(numFabricacion.Value);
            titular = txtTitular.Text;

            MessageBox.Show("Registro realizado", "registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarInterfaz();
        }
    
        private void LimpiarInterfaz()
         {
            txtTitular.Clear();
            txtDominio.Clear();
            txtNumero.Clear();
         }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text!="")
            {
                txtDominio.Text ="";
            }
        }
    }
}

