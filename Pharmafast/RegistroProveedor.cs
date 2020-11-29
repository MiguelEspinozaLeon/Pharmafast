using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Pharmafast
{
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdpro_TextChanged(object sender, EventArgs e)
        {

        }
        // Metodos texbox
        #region
        // Metodo textboxSolodoubles
        private void solodoubles(KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

        }

        private void soloint(KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
                e.Handled = true;

        }
        #endregion

        private void textBoxIdpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloint(e);
        }

        private void textBoxnombrepro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxtelpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloint(e);
        }

        private void textBoxdirepro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttoncomfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxIdpro.Text != "" && textBoxnombrepro.Text != "" && textBoxtelpro.Text != "" && textBoxdirepro.Text != "")
            {

                ProveedorControlador hola = new ProveedorControlador();
             
                hola.Ingresar(textBoxIdpro.Text, textBoxnombrepro.Text, textBoxtelpro.Text, textBoxdirepro.Text);
                textBoxIdpro.Text = string.Empty; textBoxnombrepro.Text = string.Empty; textBoxtelpro.Text = string.Empty; textBoxdirepro.Text = string.Empty; 

                MessageBox.Show("Producto agregado");
              

            }
            else
            {

                MessageBox.Show("Llene todos los espacios");


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxdirepro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtelpro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnombrepro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
           
        }

        private void RegistroProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
