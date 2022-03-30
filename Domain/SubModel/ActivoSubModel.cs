using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SubModel
{
  public class ActivoSubModel
    {
        public int id { get; set; }
        public string Json { get; set; }

        public static ActivoSubModel Convert(Activo activo)
        {

            if(activo== null)
            {
                return null;
            }

            ActivoSubModel activosubmodel = new ActivoSubModel();
            activosubmodel.id = activo.Id;
            activosubmodel.Json = JsonConvert.SerializeObject(activo);// serializar es convertir un obj csharp a json

            return activosubmodel;
        }

        public static Activo Convert(ActivoSubModel activoSubModel)
        {
            if( activoSubModel== null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(activoSubModel.Json))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<Activo>(activoSubModel.Json);// se convierte de un obj json a csharp
        }

        



    }
}
