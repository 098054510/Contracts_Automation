using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracs_Automation.Services;

namespace Contracs_Automation.Installments
{
    class PayPal : ITaxServices
    {
        public double CValue {get;set;}
        public Contract contract { get; set; }

        public PayPal(Contract contract)
        {
            this.CValue = 0.0;
            this.contract = contract;
        }

        double ITax(double CValue)
        {
            CValue = contract.ContractValue / contract.Mounth;
            return CValue;
        }

        public double Tax(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}