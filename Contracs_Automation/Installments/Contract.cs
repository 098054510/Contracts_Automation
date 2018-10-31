using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracs_Automation.Services;

namespace Contracs_Automation.Installments
{
    class Contract
    {
        public int Number { get; private set; }
        public double ContractValue { get; private set; }

        private ITaxServices taxServices;

        public Contract(int Number, double ContractValue, ITaxServices PayPal)
        {
            Number = Number;
            taxServices = PayPal;
        }
    }
}
