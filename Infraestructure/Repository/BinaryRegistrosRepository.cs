using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
   public class BinaryRegistrosRepository
    {
        RAFContext Context;
        public BinaryRegistrosRepository()
        {
            this.Context = new RAFContext("Registro", 30);
        }

        public void Actualizar(Registro registro)
        {
            Context.Update<Registro>(registro);
        }

        public void Add(Registro t)
        {
            Context.Create<Registro>(t);
        }

        public void Delete(Registro t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Registro> Read()
        {
            return Context.GetAll<Registro>();
        }

        public List<Registro> RegistroEspecifico(Expression<Func<Registro, bool>> where)
        {
            return Context.Find<Registro>(where);
        }
    }



}
}
