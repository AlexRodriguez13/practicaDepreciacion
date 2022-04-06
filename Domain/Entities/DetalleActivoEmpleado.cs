﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetalleActivoEmpleado
    {
        public int Id { get; set; }
        public Activo Activo { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }




    }
}
