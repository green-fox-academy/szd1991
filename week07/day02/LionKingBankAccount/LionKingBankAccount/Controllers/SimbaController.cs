using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LionKingBankAccount.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LionKingBankAccount.Controllers
{
    [Route("accounts")]
    public class SimbaController : Controller
    {
        // GET: /<controller>/
        [Route("simba")]
        public IActionResult Simba()
        {
            var simba = new BankAccount("Simba", 2000f, "Lion", "ChimpBone");
            
            return View(simba);
        }
    }
}
