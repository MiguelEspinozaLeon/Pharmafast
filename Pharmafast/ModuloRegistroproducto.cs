using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controladores;

namespace Pharmafast 
{
    public partial class ModuloRegistroproducto : Form
    {
      
        public ModuloRegistroproducto()
        {
            InitializeComponent();
        }

        private void ModuloRegistroproducto_Load(object sender, EventArgs e)
        {

        }

        private void textBoxcompra_TextChanged(object sender, EventArgs e)
        {


        }

        private void Registrarproducto_Click(object sender, EventArgs e)
        {

        }

        private void buttoncomfirmar_Click(object sender, EventArgs e)
        {

            RegistroProductoControlador hola = new RegistroProductoControlador();
            ModuloProducto moduloproducto = new ModuloProducto();

            if (textBoxnombrep.Text != "" && textBoxproducto.Text != "" && textBox2.Text !="" && textBoxcompra.Text !="" && textBoxstock.Text != "" && textBoxventa.Text != "")
            {
               
               
                hola.Ingresar(textBoxnombrep.Text, textBoxproducto.Text, textBox2.Text, textBoxcompra.Text, textBoxventa.Text, textBoxstock.Text, dateTimePicker1.Value);
                textBoxnombrep.Text = string.Empty; textBoxproducto.Text = string.Empty; textBox2.Text = string.Empty; textBoxcompra.Text = string.Empty; textBoxventa.Text = string.Empty; textBoxstock.Text = string.Empty;
              
                MessageBox.Show("Producto agregado");
                //Actualizar base de datos con nuevo producto


            }
            else {
             
                MessageBox.Show("Llene todos los espacios");
              

            }
        }


        private void textBoxproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            solodoubles(e);
        }

       
        private void textBoxventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            solodoubles(e);
        }

        private void textBoxstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloint(e);
        }

        private void textBoxproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloint(e);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnombrep_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void textBoxnombrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModuloRegistroproducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
