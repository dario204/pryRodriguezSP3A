using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP3A
{
    public partial class frmAutoTest : Form
    {
        
        public struct Turno
        {
           
            public int numeroTurno;
           public string Dominio;
            public int añoFabricacion;
           public string titular;
        }
        const int Max = 50;
        public Turno[] turnos;
        public int cantidad = 0;
        public string Turnos;
        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turnos = new Turno[Max];
            cantidad = 0;
            LimpiarInterfaz();

        }
        private bool validarDatos()
        {
            bool resultado = false; 
                                  
            if (txtNumero.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6) 
                {
                    
                    if (!buscarTurno(int.Parse(txtNumero.Text)))
                    {
                        resultado = true; 
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

        private bool buscarTurno(int numero)
        {
            bool existe = false; 
            int posicion = 0;
                         
            while (posicion < cantidad)
            {
                
                if (numero == turnos[posicion].numeroTurno)
                {
                    existe = true;
                    break; 
                }
                posicion++; 
            }
            return existe; 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                turnos[cantidad].numeroTurno = int.Parse(txtNumero.Text);
                turnos[cantidad].Dominio = txtDominio.Text;
                turnos[cantidad].añoFabricacion= int.Parse(numFabricacion.Value.ToString());
                turnos[cantidad].titular = txtTitular.Text;
                cantidad++;
            }
            if (cantidad==Max)
            {
                MessageBox.Show("Se completó la capacidad de carga de datos","" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRegistrar.Enabled = false;
            }

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
            txtCantidadTurnos.Text = cantidad.ToString();
            int menor= int.MaxValue;
            int posicion;
            for ( posicion = 0; posicion < cantidad; posicion++)
            {
                if (turnos[posicion].añoFabricacion < menor)
                {
                    menor = turnos[posicion].añoFabricacion;
                }
            }
            txtAntiguedad.Text = menor.ToString();
            int contador = 0;
            for (posicion = 0; posicion < cantidad ; posicion++)
            {
                if (turnos[posicion].Dominio.Length== 6)
                {
                    contador++;
                }
            }
            txtDominioSeisMeses.Text = contador.ToString();
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
        {   
            if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar)) 
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            
            if (!Char.IsLetterOrDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

