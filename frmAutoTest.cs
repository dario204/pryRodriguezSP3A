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
    public partial class frmAutoTest : Form
    {
        //Declaracion de variables globales
        public struct Turno
        {
            int numeroTurno;
            string Dominio;
            int añoFabricacion;
            string titular;
        }
        const int Max = 50;
        public Turno[] turnos;
        public int cantidad = 0;
        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turnos = new Turno[Max];
            cantidad = 0;
            
        }
        private bool validarDatos()
        {
            bool resultado = false; // valor a devolver si no se cumplen todas las condiciones
                                    // validar la existencia de los datos a ingresar
            if (txtNumero.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6) // validar el contenido del Dominio
                {
                    // validar que NO exista el número de turno a cargar
                    if (!Turnos(int.Parse(txtNumero.Text)))
                    {
                        resultado = true; // si todo está bien devuelve verdadero
                    }
                    else
                    {
                        MessageBox.Show("El Número de Turno ingresado ya existe",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Dominio debe tener 6 o 7 caracteres",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
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
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text!="" && txtDominio.Text!=""&&txtTitular.Text!="")
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {   //si NO es un digito y NO es un blackspace (para borrar)
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;//borra la tecla ingresada
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar)) //es una minuscula?
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);//convertir a mayuscula
            }
            //no es ni letra ni numero y es distinto de blackspace?
            if (!Char.IsLetterOrDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

