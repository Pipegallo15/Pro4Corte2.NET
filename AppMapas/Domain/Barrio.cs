using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Domain
{
    public class Barrio
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }

        public  Municipio Municipio { get; set; }

        public Guid _idMunicipio;
    }
}
