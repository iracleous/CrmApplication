using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.DataTranfer
{
    internal struct CustomerStructure
    {
        public string Name { get; init; }
        public string Address { get; init; }
        public int Id { get; init; }
    }
}

    internal record CustomerRecord
    {
        public string Name { get; init; }
        public string Address { get; init; }
        public int Id { get; init; }
    }