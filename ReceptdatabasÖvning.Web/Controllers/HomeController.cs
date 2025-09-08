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

        public async Task<IActionResult> Details(int id)
        {
            return View(await _dishService.GetOneDishAsync(id));
        }

        [HttpGet("adddish")]
        public IActionResult AddDish()
        {
            return View();
        }
        [HttpPost("adddish")]
        public async Task<IActionResult> AddDish(Dish dish)
        {
            if (!ModelState.IsValid)
                return View();

            await _dishService.AddDishAsync(dish);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(await _dishService.GetOneDishAsync(id));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(List<Ingredience> ingredience, int id)
        {
            await _ingredience.EditIngredienceAsync(ingredience, id);

            return View();
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
