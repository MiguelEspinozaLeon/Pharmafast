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
    public partial class ModuloEditarProducto : Form
    {
        public string valor;
        RegistroProductoControlador controlador = new RegistroProductoControlador();
       

        public ModuloEditarProducto()
        {
            InitializeComponent();
        }

        private void textBoxnombrep_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
          
            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {
                 
                if (textBoxnombrep.Text != "" && textBoxproducto.Text != "" && textBoxMarca.Text != "" && textBoxcompra.Text != "" && textBoxstock.Text != "" && textBoxventa.Text != "")
                {

                   

                    controlador.Actualizar(textBoxnombrep.Text, textBoxproducto.Text,  textBoxMarca.Text, textBoxcompra.Text, textBoxventa.Text, textBoxstock.Text, dateTimePicker1.Value);

                    MessageBox.Show("Producto Modificado");
                    //Actualizar base de datos con nuevo producto


                }
                else
                {

                    MessageBox.Show("Llene todos los espacios");


                }
            }
        }

        private void ModuloEditarProducto_Load(object sender, EventArgs e)
        {
          
            textBoxproducto.Enabled = false; 
            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {

                if (valor != null && valor != "Todos")
                {
                    var comparar = context.PRODUCTOS.SingleOrDefault(b => b.nombre_producto == valor);

                    var result = context.PRODUCTOS.SingleOrDefault(b => b.id_producto == comparar.id_producto);

                    textBoxnombrep.Text = result.nombre_producto;
                    textBoxMarca.Text = result.marca;
                    textBoxproducto.Text = result.id_producto.ToString();
                    textBoxcompra.Text = result.precio_compra.ToString();
                    textBoxventa.Text = result.precio_venta.ToString();
                    textBoxstock.Text = result.stock.ToString();

                }
                else
                {
                    MessageBox.Show("Porfavor especifique producto a eliminar");

                 
                }
            }

        
        

                   
        }

        private void ModuloEditarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
