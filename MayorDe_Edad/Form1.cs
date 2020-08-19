using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDe_Edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnidentificar_Click(object sender, EventArgs e)

        {
            int edad; 
           edad =     int.Parse(txtedad.Text);


            if (edad <= 0 || edad >= 121)
            {
                MessageBox.Show("Rango de edad invalidado;Ingresar edad entre 1 hasta 120 años",
                "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtedad.Text = String.Empty;
                txtedad.Focus();
                return;

            }
            else if (edad >= 1 && edad <= 18)
            {
                lblrangoedad.Text = Convert.ToString( "  * Eres menor de edad *");
            }
            else 
                lblrangoedad.Text = Convert.ToString(" * Eres mayor de edad *");
                lblrangoedad.Visible = true;
                label3.Visible = true;
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia",
                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtedad.Text = String.Empty;
          
            lblrangoedad.Visible = false;
            label3.Visible = false;
            txtedad.Focus();

        }
    }
}
