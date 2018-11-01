using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracs_Automation.Services;

namespace Contracs_Automation.Installments
{
    public class Contract : ITaxServices<Amount>
    {
        public int Number { get; private set; }
        public double ContractValue { get; private set; }

        private ITaxServices taxServices;

        public Contract(int Number, double ContractValue, ITaxServices _taxServices)
        {
            Number = Number;
            _taxServices = taxServices;
        }

        public double Tax(double Amount)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Amount amount)
        {
            return Number == amount.Number &&
            ContractValue == amount.ContractValue; 
        }
    }
}