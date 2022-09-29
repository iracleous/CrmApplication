using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    internal interface ICustomerService
    {
        public void Add(Customer customer);
        public List<Customer> View();
        public virtual void SpecialPrint()
        {
            Console.WriteLine("SpecialPrint");
        }
    }
}
