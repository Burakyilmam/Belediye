using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T Get(int id);
        List<T> List();
    }

}
