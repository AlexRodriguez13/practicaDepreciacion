using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryEmpleadoRespository : IEmpleadoModel
    {
        private RAFContext Context;
        private const int Size = 576;

        public BinaryEmpleadoRespository()
        {
            this.Context = new RAFContext("Empleado", Size);
        }

        public void Add(Empleado t)
        {

            Context.Create<Empleado>(t);
        }

        public void Delete(Empleado t)
        {
            Context.Delete(t.Id);
        }

        public bool Delete(int id)
        {
            return Context.Delete(id);
        }

        public List<Empleado> Read()
        {
            return Context.GetAll<Empleado>();
        }

        public Empleado GetById(int id)
        {
            return Context.Get<Empleado>(id);
        }

        public void Update(Empleado Empleado)
        {
            Context.Update<Empleado>(Empleado);
        }
    }
}
