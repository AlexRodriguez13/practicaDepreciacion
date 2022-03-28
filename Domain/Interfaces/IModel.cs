using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Add(T t);
        void Delete(int id);

        void Update(T t, int g);


        List<T> Read();


    }
}
