using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public  class Class1
    { 

        // metodos de encapsulacion para productos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public DateTime? Fecha_vencimiento { get; set; }

        public double? Compra { get; set; }
        public double? Venta { get; set; }
        public int? Stock { get; set; }

     

    }
}
