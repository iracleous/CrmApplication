using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Model
{

    public class Item<K>
    {
        public K Id { get; set; }
        
    }


    public class Book:Item<int>
    {
        
        public string? Title { get; set; }
        public string? Author { get; set; }
        public bool IsAvailable { get; set; }
    }
    public class Member : Item<int>
    {
 
        public string? Name { get; set; }
    }

    public class Lending : Item<int>
    {
        public DateTime DateTime { get; set; }
        public Member? Member { get; set; } = null;
        public Book? Book { get; set; } = null;
        public bool IsReturned { get; set; } = false;
    }
}
