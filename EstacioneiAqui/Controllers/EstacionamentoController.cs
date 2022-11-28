using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacioneiAqui.Context;
using EstacioneiAqui.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacioneiAqui.Controllers
{
    public class EstacionamentoController : Controller
    {
        private readonly EstacionamentoContext _context;
        public EstacionamentoController(EstacionamentoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
    }
}