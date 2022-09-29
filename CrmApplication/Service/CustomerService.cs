using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    internal class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customerList;

        public CustomerService()
        {
            _customerList = new();
        }
        public void Add(Customer customer)
        {
            _customerList.Add(customer);
        }

        public List<Customer> View()
        {
            return _customerList;
        }
    }
}
