using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            //Get data from db
            //put items into model
            //render a view
            return View();
        }
    }
}