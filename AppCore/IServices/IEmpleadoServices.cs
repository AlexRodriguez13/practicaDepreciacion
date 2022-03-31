using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
   public interface IEmpleadoServices: IServices<Empleado>
    {
        Empleado GetById(int id);
    }
}
