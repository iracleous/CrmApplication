using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Model
{
    internal  abstract class  Person  
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";


        public virtual void Print()
        {
            Console.WriteLine("This is a person");
        }

    }

    internal class Customer : Person
    {
        public decimal Balance { get; set; } = 300.9m;

       public override void Print()
        {

        }

        public override string ToString()
        {
            return $"Name= {Name} Id= {Id} Balance= {Balance}";
        }
    }

    internal class Employee : Person
    {

    }

}
