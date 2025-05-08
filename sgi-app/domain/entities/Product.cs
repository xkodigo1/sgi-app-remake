using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Barcode { get; set; }
        
        /*
        public ICollection<DetalleVenta> DetallesVenta { get; set; }
        public ICollection<DetalleCompra> DetallesCompra { get; set; }
        public ICollection<ProductoProveedor> ProductosProveedores { get; set; }
        public ICollection<PlanProducto> PlanesProductos { get; set; }
        */
    }
}