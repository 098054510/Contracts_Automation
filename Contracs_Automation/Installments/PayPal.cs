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
        public double CC { get; set; }
        public int I { get; set; }
        public double CValue {get;set;}

        public PayPal(double CC, int I, double CValue)
        {
            this.CC = CC;
            this.I = I;
            this.CValue = 0.0;
        }

        double ITax(double CValue)
        {
            CValue = CC / I ;
            return CValue;
        }

        public double Tax(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}