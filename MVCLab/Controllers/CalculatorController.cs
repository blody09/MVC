using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CalculationForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ResultForm(double num1, double num2, string math) // add view here
        {
            double result = 0; // @model double is talking to this int result!
            if (math == "Add")
            {
                result = num1 + num2;
            }
            else if (math == "Sub")
            {
                result = num1 - num2;
            }
            else if (math == "Multiply")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            return View(result); // return whatever the IAR was named + our int var Result "Result",
        }
    }
}