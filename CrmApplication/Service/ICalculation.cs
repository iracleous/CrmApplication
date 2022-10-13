using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    internal interface ICalculation
    {
        public ResponseData<decimal> Operation(decimal op1, decimal op2);
    }
}
