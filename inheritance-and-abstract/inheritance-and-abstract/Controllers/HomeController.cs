using Microsoft.AspNetCore.Mvc;
using AnimalWebApp.Models;

namespace AnimalWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            ViewBag.DogInfo = $"{dog.MakeSound()} | {dog.Sleep()}";
            ViewBag.CatInfo = $"{cat.MakeSound()} | {cat.Sleep()}";

            return View();
        }
    }
}
