using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReceptdatabasÖvning.Web.Models;
using ReceptdatabasÖvning.Web.Services;

namespace ReceptdatabasÖvning.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDishService _dishService;
        private readonly IIngredienceService _ingredience;

        public HomeController(IDishService dishService, IIngredienceService ingredience)
        {
            _dishService = dishService;
            _ingredience = ingredience;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _dishService.GetDishAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
