using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using WebAppRandom.Models;

namespace WebAppRandom.Controllers
{
    public class RandomController : Controller
    {
        public IActionResult temp()
        {
            var scales = new List<string> { "Celsius", "Fahrenheit" };
            ViewBag.Scales = new SelectList(scales);
            return View();
        }

        [HttpPost]
        public IActionResult temp(TempModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ConvertToScale == "Celsius" && model.Scale == "Celsius")
                {
                    model.ConvertedValue = model.Value;
                }
                else if (model.ConvertToScale == "Celsius" && model.Scale == "Fahrenheit")
                {
                    model.ConvertedValue = (model.Value * 9 / 5) + 32;

                }
                else if (model.ConvertToScale == "Fahrenheit" && model.Scale == "Fahrenheit")
                {
                    model.ConvertedValue = model.Value;
                }
                else if (model.ConvertToScale == "Fahrenheit" && model.Scale == "Celsius")
                {
                    model.ConvertedValue = (model.Value - 32) * 5 / 9;
                }
            }
                var scales = new List<string> { "Celsius", "Fahrenheit" };
                ViewBag.Scales = new SelectList(scales, model.Scale);
                ViewBag.Scales = new SelectList(scales, model.ConvertToScale);
                return View("temp", model);
        }

    }
}
