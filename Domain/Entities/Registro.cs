using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
  public  class Registro
    {
        public int Id { get; set; }
        public Empleado Empleado { get; set; }
        public Activo Activo { get; set; }
        public double TiempoInicial { get; set; }
        public EstadoRegistro Estado { get; set; }

    }
}
