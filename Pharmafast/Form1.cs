using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmafast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }





        public Form activeform = null;
        public void openForm(Form formulario)
        {
            
            if (activeform != null)
                activeform.Close();
            activeform = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formulario);
            panelFormulario.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            openForm(new ModuloVentasVista());
            //openForm(new ModuloRegistroproducto());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openForm(new ModuloProducto());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 500);
        }

        private void buttonproveedor_Click(object sender, EventArgs e)
        {
            openForm(new Moduloproveedor());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        public void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }





