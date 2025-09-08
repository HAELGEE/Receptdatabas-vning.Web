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



        [HttpGet("AddDish")]
        public IActionResult AddDish()
        {
            return View();
        }
        [HttpPost("AddDish")]
        public async Task<IActionResult> AddDish(Dish dish)
        {
            if (!ModelState.IsValid)
                return View();

            await _dishService.AddDishAsync(dish);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet("AddIngredience")]
        public IActionResult AddIngredience()
        {
            return View();
        }
        [HttpPost("AddIngredience")]
        public async Task<IActionResult> AddIngredience(Ingredience ingredience)
        {
            if (!ModelState.IsValid)
                return View();

            await _ingredience.AddIngredienceAsync(ingredience);

            return RedirectToAction(nameof(Index));
        }





        [HttpGet("update")]
        public async Task<IActionResult> Update(int id)
        {
            var dish = await _dishService.GetOneDishAsync(id);
            ViewData["DishId"] = dish.Id;
            ViewData["DishName"] = dish.Name;

            return View(await _ingredience.GetIngrediencesAsync());
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(List<int> ingredienceIDs, int id)
        {
            await _ingredience.EditIngredienceAsync(ingredienceIDs, id);

            return RedirectToAction(nameof(Details), new {id});
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
