using Microsoft.AspNetCore.Mvc;
using Application.ViewModel;
using Application.Services;

namespace LoanCalculator.Controllers
{
    public class LoanController : Controller
    {
        private readonly LoanCalculation CalculationService;

        public LoanController()
        {
            CalculationService = new LoanCalculation();
        }

        public IActionResult Index(LoanViewModel vm)
        {
            return View(vm);
        }

        [HttpGet]
        public IActionResult Result(LoanViewModel vm)
        {
            vm.MonthlyShare = LoanCalculation.CalculateShare(vm);
            return View(vm);
        }
    }
}
