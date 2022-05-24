using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoanViewModel
    {
        public string Amount { get; set; }
        public string Rate { get; set; }
        public string RateType { get; set; }
        public string MonthlyRate { get; set; }
        public string MonthlyShare { get; set; }
    }
}
