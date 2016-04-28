using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebApplication.Controllers
{
    public class TimeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DateTime model = DateTime.Now;
            return View(model);
        }

        public string TimeMessage(string message = "The time is")
        {
            return $"{message} {DateTime.Now.ToBinary()}";
        }
    }
}
