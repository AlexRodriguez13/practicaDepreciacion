using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
   public interface IRegistroModel :IModel<Registro>
    {
        List<Registro> RegistroEspecifico(System.Linq.Expressions.Expression<Func<Registro, bool>> where);

        void Actualizar(Registro registro);   
    }
}
