using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
namespace Controladores
{
    public class ProveedorControlador
    {
        // metodos sql proveedor
        #region
        public void Ingresar(string ID, string Nombre, string Tel, string direccion)
        {
            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {

                var proveedores = db.PROVEEDORES.SingleOrDefault(b => b.id_proveedor.ToString() == ID);
                var proveedoresNom = db.PROVEEDORES.SingleOrDefault(b => b.nonmbre_proveedor == Nombre);
                if (proveedores == null && proveedoresNom == null)
                {

                    var proveedor = new Modelos.EF.PROVEEDORES
                    {
                        id_proveedor = Int32.Parse(ID),
                        nonmbre_proveedor = Nombre,
                        telefono = Int32.Parse(Tel),
                        Direccion = direccion


                    };

                    using (var context = new Modelos.EF.PHARMAFASTEntities())
                    {

                        context.PROVEEDORES.Add(proveedor); // adds the author to the DbSet in memory
                        context.SaveChanges(); // commits the changes to the database

                    }
                }
            }
        }
        public void Eliminar(string valor)
        {

            Modelos.EF.PROVEEDORES proveedor;
            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {

                proveedor = db.PROVEEDORES.Where(b => b.nonmbre_proveedor == valor).First();

                db.PROVEEDORES.Remove(proveedor);
                db.SaveChanges();


            }
        }
        public void Actualizar(string ID, string Nombre, string Tel, string direccion)
        {
            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {

                var result = context.PROVEEDORES.SingleOrDefault(b => b.id_proveedor.ToString() == ID);
                if (result != null)
                {
                    result.nonmbre_proveedor = Nombre;
                    result.telefono = Int32.Parse(Tel);
                    result.Direccion = direccion;

                    context.SaveChanges();
                }
            }

        }
        public IEnumerable<Classproveedor> GetListboxproveedor()
        {



            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {


                IEnumerable<Classproveedor> lst = (from d in db.PROVEEDORES

                                                   select new Classproveedor
                                                   {


                                                       Nombre = d.nonmbre_proveedor,


                                                   }).ToList();

                return lst;



            }

        }
        public IEnumerable<Classproveedor> GetListbusquedaproveedor(string valor)
        {


            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {

                if (valor != "Select")
                {
                    IEnumerable<Classproveedor> lstProveedor = (from d in db.PROVEEDORES
                                                                where (d.nonmbre_proveedor == valor && d.nonmbre_proveedor != "Select")
                                                                select new Classproveedor
                                                                {
                                                                    ID = d.id_proveedor,
                                                                    Nombre = d.nonmbre_proveedor,
                                                                    Telefono = d.telefono,
                                                                    Direccion = d.Direccion


                                                                }).ToList();

                    return lstProveedor;



                }
                else
                {
                    IEnumerable<Classproveedor> lstProveedor = (from d in db.PROVEEDORES
                                                                where d.nonmbre_proveedor != "Select"
                                                                select new Classproveedor
                                                                {
                                                                    ID = d.id_proveedor,
                                                                    Nombre = d.nonmbre_proveedor,
                                                                    Telefono = d.telefono,
                                                                    Direccion = d.Direccion


                                                                }).ToList();

                    return lstProveedor;

                }
            }
        }
        #endregion
    }
}

