using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracs_Automation.Services;
using Contracs_Automation.Installments;

namespace Contracs_Automation.Installments
{
    public class Contract : ITaxServices
    {
        public int Mounth { get; private set; }
        public double ContractValue { get; private set; }
        public double PCent { get; set; }

        private ITaxServices taxServices;

        public Contract(int Mounth, double ContractValue, double PCent)
        {
            this.PCent = PCent;
            this.Mounth = Mounth;
            this.ContractValue = ContractValue;
            taxServices = null;
        }

        public double SubPercent()
        {
            double Percent;
            Percent = PCent / 100;
            return Percent;
        }

        public double Tax(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}