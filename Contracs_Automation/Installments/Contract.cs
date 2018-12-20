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
        private ITaxServices taxServices;

        public string Name { get; set; }
        public int Mounth { get; private set; }
        public double ContractValue { get; private set; }
        public double PCent { get; set; }

        public Contract(string Name, int Mounth, double ContractValue, double PCent)
        {
            this.Name = Name;
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

        public override string ToString()
        {
            return "Name of Contract Owner: " + Name + "\n" 
                + "Contract initial Price: $" + ContractValue + "\n"
                + "Months Paid: " + Mounth;
        }
    }
}