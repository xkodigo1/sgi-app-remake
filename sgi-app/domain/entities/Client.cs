using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace sgi_app.domain.entities
{
    public class Client
    {
        public int Id { get; set; }
        public string TerceroId { get; set; }
        public DateTime? FechaNac { get; set;}
        public DateTime FechaCompra { get; set;}
        
        public Tercero Tercero { get; set;}
    }
}