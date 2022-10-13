using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Repository
{
    public abstract class Repository<T,K> : IRepository<T, K> where T: Item<K>
    {

        private readonly List<T> _Ts;
      

        public Repository(List<T> Ts)
        {
            _Ts = Ts;
        }

        public abstract K IncreaseId();

        public T Create(T t)
        {
            _Ts.Add(t);
            t.Id = IncreaseId();
            return t;
        }

        public bool Delete(K Id)
        {
            T? T = Retreive(Id);
            if (T!=null)
            {
                _Ts.Remove(T); 
                return true;
            }
            return false;
        }

        public T? Retreive(K Id)
        {
            return _Ts
                .Where(T => T.Id.Equals(Id))
                .FirstOrDefault();
        }

        public List<T> Retreive()
        {
            return _Ts;
        }

       
    }
}
