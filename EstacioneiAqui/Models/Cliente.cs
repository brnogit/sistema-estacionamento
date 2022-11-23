using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacioneiAqui.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string ModeloDoVeiculo { get; set; }
        public string MarcaDoVeiculo { get; set; }
        public string Placa { get; set; }
        public string Categoria { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal ValorPorHora { get; set; }
        public decimal ValorTotal { get; set; }
        public string NomeManobrista { get; set; }
    }
}