using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Domain
{
    public class Municipio
    {
        public Guid Id { get; set; }
        public String Nombre { get; set; }

        public Departamento Departamento { get; set; }

        public Guid _idDepartamento;


    }
}
