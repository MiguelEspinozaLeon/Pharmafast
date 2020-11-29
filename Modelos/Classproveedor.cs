using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Classproveedor
    {
        // metodos de encapsulacio para proveedores
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int? Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
