using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ActivoServices:BaseServices<Activo>,IActivoServices
    {

        IActivoModel activoModel;
        public ActivoServices(IActivoModel model) : base(model)
        {
            this.activoModel = model;
        }

        public void Delete(int value)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            return activoModel.GetById(id);
        }

        public void Update(Activo activo, int id)
        {
            throw new NotImplementedException();
        }
    }

}
