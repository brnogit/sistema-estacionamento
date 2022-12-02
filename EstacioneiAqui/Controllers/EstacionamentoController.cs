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

        #region Criar
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
        #endregion

        #region Atualizar
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if(cliente == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Atualizar(Cliente cliente)
        {
            var clienteBanco = _context.Clientes.Find(cliente.Id);

            clienteBanco.NomeCliente = cliente.NomeCliente;
            clienteBanco.MarcaDoVeiculo = cliente.MarcaDoVeiculo;
            clienteBanco.ModeloDoVeiculo = cliente.ModeloDoVeiculo;
            clienteBanco.Placa = cliente.Placa;
            clienteBanco.Status = cliente.Status;
            clienteBanco.NumeroDaVaga = cliente.NumeroDaVaga;
            clienteBanco.NomeManobrista = cliente.NomeManobrista;
            clienteBanco.DataEntrada = cliente.DataEntrada;
            clienteBanco.DataSaida = cliente.DataSaida;
            clienteBanco.ValorPorHora = cliente.ValorPorHora;
            clienteBanco.ValorTotal = cliente.ValorTotal;

            _context.Clientes.Update(clienteBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if(cliente == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            if(cliente == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Deletar(Cliente cliente)
        {
            var clienteBanco = _context.Clientes.Find(cliente.Id);

            _context.Clientes.Remove(clienteBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}