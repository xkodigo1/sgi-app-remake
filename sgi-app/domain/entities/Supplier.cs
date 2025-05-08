using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Supplier
    {
         public int Id { get; set; }
        public string TerceroId { get; set; }
        public double Dcto { get; set; }
        public int DiaPago { get; set; }
        
        // Relaciones de navegación
        public Tercero Tercero { get; set; }
        public ICollection<ProductoProveedor> ProductosProveedores { get; set; }
    }
}