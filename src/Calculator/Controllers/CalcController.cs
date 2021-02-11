namespace Calculator.Controllers
{
    public CalcController : Controller
    {
        public IActionResult Index()
        {
            return view();
        }
    }
}