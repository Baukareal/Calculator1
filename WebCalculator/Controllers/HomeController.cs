using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Калькулятор;

namespace WebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "+", Text = "+" },
                new SelectListItem() { Value = "-", Text = "-" },
                new SelectListItem() { Value = "x", Text = "x" },
                new SelectListItem() { Value = "/", Text = "/" }
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(double value_1, double value_2, string sign)
        {
            TwoArgumentsFactory factory = new TwoArgumentsFactory();
            ITwoArgumentsCalculator calculator = factory.Create_Calculator(sign);
            double result = calculator.Calculate(value_1, value_2);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "+", Text = "+" },
                new SelectListItem() { Value = "-", Text = "-" },
                new SelectListItem() { Value = "x", Text = "x" },
                new SelectListItem() { Value = "/", Text = "/" }
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Calcualtor or something shit, I don't understand";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Anon4ig Plovecsky: vk.com/thebestplovec";

            return View();
        }
    }
}