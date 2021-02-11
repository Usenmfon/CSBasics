using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(string firstNumber, string secondNumber)
        {
            int fNum = int.Parse(firstNumber);
            int sNum = int.Parse(secondNumber);
            int addNum = fNum + sNum;
            ViewBag.result = addNum;
            return View();
        }
    }
}