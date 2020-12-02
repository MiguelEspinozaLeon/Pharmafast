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
    public partial class ModuloEditarProveedor : Form
    {
        public string valorP;
        ProveedorControlador controlador = new ProveedorControlador();
        public ModuloEditarProveedor()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {

                if (textBoxIdpro.Text != "" && textBoxnombrepro.Text != "" && textBoxtelpro.Text != "" && textBoxdirepro.Text != "")
                {

                    controlador.Actualizar(textBoxIdpro.Text, textBoxnombrepro.Text, textBoxtelpro.Text, textBoxdirepro.Text);

                    MessageBox.Show("Producto Modificado");
                    //Actualizar base de datos con nuevo proveedor
                }
                else
                {
                    MessageBox.Show("Llene todos los espacios");
                }
            }
        }

        private void ModuloEditarProveedor_Load(object sender, EventArgs e)
        {
            textBoxIdpro.Enabled = false;
            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {
                if (valorP != null && valorP != "Todos")
                {

                    var comparar = context.PROVEEDORES.SingleOrDefault(b => b.nonmbre_proveedor == valorP);

                    var result = context.PROVEEDORES.SingleOrDefault(b => b.id_proveedor == comparar.id_proveedor);
                    textBoxIdpro.Text = result.id_proveedor.ToString();
                    textBoxnombrepro.Text = result.nonmbre_proveedor;
                    textBoxtelpro.Text = result.telefono.ToString();
                    textBoxdirepro.Text = result.Direccion;

                }

                else
                {
                    MessageBox.Show("Porfavor especifique producto a Editar");


                }
            }
        }

        private void ModuloEditarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
