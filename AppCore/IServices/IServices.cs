using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {

        void Add(T t);
        void Delete(int id);
        List<T> Read();
        void Delete(int id, List<int> listaIds);
        void Update(T t, int id);
    }
}
