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
    
    public partial class ModuloProducto : Form
    {

        public string ValorProducto;
        bool control = false;

        ModuloRegistroproducto registro = new ModuloRegistroproducto();
        ModuloEditarProducto Editar = new ModuloEditarProducto();

        Controladores.RegistroProductoControlador controlador = new  Controladores.RegistroProductoControlador();
        public ModuloProducto()
        {
          
            InitializeComponent();
        }

    
        private void buttonNuevo_Click(object sender, EventArgs e)
        {

            registro.Show();
        }

        private void ModuloProducto_Load(object sender, EventArgs e)
        {
            control = false;
            dataGridView1.DataSource = controlador.GetListbusqueda("Select");

            //  controlador.Actualizar();
            Busquedaproducto.DataSource = controlador.GetListbox();
            Busquedaproducto.ValueMember = "Nombre";

            control = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Busquedaproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (control == true)
            {
                
                ValorProducto = Busquedaproducto.SelectedValue.ToString();
                Editar.valor = ValorProducto;
                dataGridView1.DataSource = controlador.GetListbusqueda(Editar.valor);
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (Editar.valor != null && Editar.valor != "Select")
            {
            
                Editar.Show();
            }
            else
            {
                MessageBox.Show("Porfavor especifique producto a Editar");


            }

        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            if (Busquedaproducto.SelectedValue != null)
            {
                controlador.Eliminar(Busquedaproducto.SelectedValue.ToString());
                MessageBox.Show("Registro borrado con exito");
            }
            else {
                MessageBox.Show("Por favor escoga registro para eliminar");

            }
        }
    }

   
}
