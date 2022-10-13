using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Repository
{
    public interface IRepository<T,K>
    {

        //CRUD
        public T Create(T t);
        public T? Retreive(K Id);
        public List<T> Retreive();
   //     public T? Update(T newData );

        public bool Delete(K Id);

    }
}
