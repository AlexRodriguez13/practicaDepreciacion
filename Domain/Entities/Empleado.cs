using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado
    {
        public int Id { get; set; }
        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public string Apellido { get; set; }
        //public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public EstadoEmpleado Estado { get; set; }

        



    }
}
