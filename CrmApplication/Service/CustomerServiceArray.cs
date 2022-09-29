using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    internal class CustomerServiceArray : ICustomerService
    {
        private static readonly int  MAX_CUSTOMERS = 10;
        private Customer[] _customers = new Customer[MAX_CUSTOMERS];
        private int _count;

        public void Add(Customer customer)
        {
            if (_count < MAX_CUSTOMERS)
            {
                _customers[_count++] = customer;
            }
           
        }

        public List<Customer> View()
        {
            var customers = new List<Customer>();
            for (int index = 0; index < _count; index++)
                customers.Add(_customers[index]);
            return customers;
        }
    }
}
