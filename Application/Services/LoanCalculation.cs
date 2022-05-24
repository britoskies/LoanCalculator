using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModel;

namespace Application.Services
{
    public class LoanCalculation
    {
        public static string CalculateShare(LoanViewModel vm)
        {
            try
            {
                if (vm.RateType == "personal") vm.Rate = "22%";
                if (vm.RateType == "automovil") vm.Rate = "12%";
                if (vm.RateType == "hipotecario") vm.Rate = "8%";

                // Parsing model values to be able to do the calculation
                double amountAsDouble = Double.Parse(vm.Amount);
                int rateAsInt = int.Parse(vm.Rate.Remove(vm.Rate.Length - 1));
                int monthlyRateAsInt = int.Parse(vm.MonthlyRate);

                // First getting porcentange, then adding the amount to it
                double total = ((amountAsDouble * rateAsInt) / 100) + amountAsDouble;

                return string.Format("{0:0.00}", (total / monthlyRateAsInt));

            }
            catch (Exception)
            {
                return "";
                throw;
            }
        }
    }
}
