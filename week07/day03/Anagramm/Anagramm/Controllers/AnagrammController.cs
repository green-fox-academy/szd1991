using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Anagramm.Controllers
{
    public class AnagrammController : Controller
    {
        IAnagram anagram;

        public AnagrammController(IAnagram anagram)
        {
            this.anagram = anagram;
        }

        [HttpGet("/")]
        public IActionResult Input()
        {
            return View();
        }

        [HttpPost("/result")]
        public IActionResult Result([FromForm] string firstWord, [FromForm] string secondWord)
        {
            anagram.SetFirstWord(firstWord);
            anagram.SetSecondWord(secondWord);

            return View(anagram);
        }
    }
}
