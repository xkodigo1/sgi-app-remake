using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sgi_app.domain.entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string TerceroId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SalarioBase { get; set; }
        public int EpsId { get; set; }
        public int ArlId { get; set; }
        

        public Tercero Tercero { get; set; }
        public EPS Eps { get; set; }
        public ARL Arl { get; set; }
    }
}