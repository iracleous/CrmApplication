using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Model
{
    internal class ResponseData<T>
    {
        public T Data { set; get; }
        public int ReturnStatus{set; get;}
        public string Description { set; get; }
    }
}
