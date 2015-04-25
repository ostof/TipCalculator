using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class TipDataContext
    {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }

        public TipDataContext()
        {
            this.BillAmount = string.Empty;
            this.TipAmount = string.Empty;
            this.TotalAmount = string.Empty;
        }

        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if (double.TryParse(originalAmount.Replace('€', ' '), out billAmount))
            {
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }

            this.BillAmount = String.Format("{0:C}", billAmount);
            this.TipAmount = String.Format("{0:C}", tipAmount);
            this.TotalAmount = String.Format("{0:C}", totalAmount);
        }


        public double tipAmount { get; set; }
    }
}
