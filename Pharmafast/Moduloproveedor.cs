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
    public partial class Moduloproveedor : Form
    {
        public string ValorProovedor;
        bool control = false;
        RegistroProveedor registro = new RegistroProveedor();
        ModuloEditarProveedor Editar = new ModuloEditarProveedor();
        Controladores.ProveedorControlador controlador = new Controladores.ProveedorControlador();

        public Moduloproveedor()
        {
            InitializeComponent();
        }

        private void Moduloproveedor_Load(object sender, EventArgs e)
        {

            control = false;
            dataGridView1.DataSource = controlador.GetListbusquedaproveedor("Select");

            comboBoxproovedor.DataSource = controlador.GetListboxproveedor();
            comboBoxproovedor.ValueMember = "Nombre";

            control  = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro.Show();
           
        }

        private void comboBoxproovedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (control == true)
            {

                ValorProovedor = comboBoxproovedor.SelectedValue.ToString();
                Editar.valorP = ValorProovedor;
                dataGridView1.DataSource = controlador.GetListbusquedaproveedor(comboBoxproovedor.SelectedValue.ToString());
            }
        }

        private void buttoneliminar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxproovedor.SelectedValue != null)
            {
                controlador.Eliminar(comboBoxproovedor.SelectedValue.ToString());
                MessageBox.Show("Registro borrado con exito");
            }
            else
            {
                MessageBox.Show("Por favor escoga registro para eliminar");
            }
        }

        private void buttoneditar_Click(object sender, EventArgs e)
        {
            if (Editar.valorP != null && Editar.valorP != "Select")
            {

                Editar.Show();
            }
            else
            {
                MessageBox.Show("Porfavor especifique producto a editar");


            }
          
        }
    }
}
