using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class ThirdParties
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public int TipoDocId { get; set; }
        public int TipoTerceroId { get; set; }
        public int CiudadId { get; set; }
    }
}