using Domain.Entities;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ListActivoRepository : BaseRepositoy<Activo>, IActivoModel
    {
        public Activo GetById(int id)
        {
            return data.Where(x => x.Id == id).FirstOrDefault();

            //foreach(Activo activo in data)
            //{
            //    if (activo.Id == id)
            //    {
            //        return activo;
                   
            //    }
               
            //}
            //return null;
        }

        public List<Activo> FindSpecific(Expression<Func<Activo, bool>> where)
        {
            throw new NotImplementedException();
        }
        public void Update(Activo activo)
        {
            throw new NotImplementedException();
        }
    }
}
