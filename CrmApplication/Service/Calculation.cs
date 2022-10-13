using CrmApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Service
{
    internal class Calculation : ICalculation
    {
        public ResponseData<decimal> Operation(decimal op1, decimal op2)
        {
            try
            {
                return new ResponseData<decimal> { Data = op1 / op2, ReturnStatus = 0, Description = "Sucessful return" };
            }
            catch (Exception exception)
            {
                return new ResponseData<decimal> { Data = 0, ReturnStatus = -1, Description = exception.ToString() };

            }
        }
    }
}
