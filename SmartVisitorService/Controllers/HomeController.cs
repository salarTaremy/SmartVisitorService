using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SmartVisitorApi.Controllers
{
    public class HomeController : BaseControler
    {

        [Produces("application/json")]
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]")]
        public string Welcome()
        {
            SmartVisitor.Repositories.OrderRepository rep = new SmartVisitor.Repositories.OrderRepository("");

            rep.Create(new SmartVisitor.Entities.Order.Order { ID = 1 });


            return "Welcome To SmartVisitor Api ...";
        }
    }
}
