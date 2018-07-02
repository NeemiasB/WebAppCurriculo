using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCurriculo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCurriculo.Controllers
{
    public class CurriculoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View(new Curriculo());
        }

        [HttpPost]
        public IActionResult Cadastro(Curriculo curriculo)
        {
            return View(curriculo);
        }
    }
}
