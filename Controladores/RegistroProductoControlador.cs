using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Controladores
{

    public class RegistroProductoControlador
    {
        
        // metodos sql productos
        #region 
        public void Ingresar(string nombre, string Id, string Marca, string compra, string venta, string stock, DateTime datetime) {
            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {

               var  product = db.PRODUCTOS.SingleOrDefault(b => b.id_producto.ToString() == Id);
               var productoNom = db.PROVEEDORES.SingleOrDefault(b => b.nonmbre_proveedor == nombre);

                if (product == null || productoNom == null)
                {
                    var producto = new Modelos.EF.PRODUCTOS
                    {
                        nombre_producto = nombre,
                        id_producto = Int32.Parse(Id),
                        marca = Marca,
                        precio_compra = double.Parse(compra),
                        precio_venta = double.Parse(venta),
                        stock = Int32.Parse(stock),
                        fecha_vencimiento = datetime
                    };

                    using (var context = new Modelos.EF.PHARMAFASTEntities())
                    {

                        context.PRODUCTOS.Add(producto); // adds the author to the DbSet in memory
                        context.SaveChanges(); // commits the changes to the database

                    }
                }
            }
            
        }
        public string mostrar(string Cambio)
        {

            using (var context = new Modelos.EF.PHARMAFASTEntities())
            {
                
                var result = context.PRODUCTOS.SingleOrDefault(b => b.nombre_producto == Cambio);
        
                return result.ToString();
            }

            
        }
        public void Eliminar(string valor) {
      
            Modelos.EF.PRODUCTOS product;
            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {

                product =db.PRODUCTOS.Where(b => b.nombre_producto == valor).First();

                db.PRODUCTOS.Remove(product);
                db.SaveChanges();
                
             
                
            }
        }
            public void Actualizar(string Cambio, string Id, string Marca, string compra, string venta, string Stock ,DateTime datetime)
        {

                using (var context = new Modelos.EF.PHARMAFASTEntities())
                {
            
                var result = context.PRODUCTOS.SingleOrDefault(b => b.id_producto.ToString() == Id);
                    if (result != null)
                    {
                    
                    result.nombre_producto = Cambio;
                    result.marca = Marca;
                    result.precio_compra = double.Parse(compra);
                    result.precio_venta = double.Parse(venta);
                        //result.stock = Int32.Parse(Stock); 
                        context.SaveChanges();
                    }
                }
            
        }
        
            public IEnumerable<Modelos.Class1> GetListbox()
        {
             
            
            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities())
            {


                IEnumerable<Modelos.Class1> lst = (from d in db.PRODUCTOS
                                                  
                                                   select new Modelos.Class1
                                                   {
                                                     
                                                       Nombre = d.nombre_producto,
                                                     

                                                   }).ToList();

                return lst;



            }

        }
        public IEnumerable<Modelos.Class1> GetListbusqueda(string valor){



            using (Modelos.EF.PHARMAFASTEntities db = new Modelos.EF.PHARMAFASTEntities()) {
                if (valor != "Todos") 
                {
                    IEnumerable<Modelos.Class1> lst = (from d in db.PRODUCTOS
                                                       where (d.nombre_producto == valor && d.nombre_producto != "Todos")
                                                       select new Modelos.Class1
                                                       {

                                                           Id = d.id_producto,
                                                           Nombre = d.nombre_producto,
                                                           Marca = d.marca,
                                                           Fecha_vencimiento = d.fecha_vencimiento,
                                                           Compra = d.precio_compra,
                                                           Venta = d.precio_venta,
                                                           Stock = d.stock,

                                                       }).ToList();
                    return lst;

                }
                else {
                    IEnumerable<Modelos.Class1> lst = (from d in db.PRODUCTOS
                                                      where d.nombre_producto != "Todos"
                                                       select new Modelos.Class1
                                                      {

                                                          Id = d.id_producto,
                                                          Nombre = d.nombre_producto,
                                                          Marca = d.marca,
                                                          Fecha_vencimiento = d.fecha_vencimiento,
                                                          Compra = d.precio_compra,
                                                          Venta = d.precio_venta,
                                                          Stock = d.stock,

                                                      }).ToList();
                    return lst;
                }
               

            }
            
        }
     
        #endregion

     
    }
}
