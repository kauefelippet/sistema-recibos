using System;
using Recibo.Models;

namespace Recibo.ViewModel
{
    internal class AtosVM
    {
        private readonly Ato _ato;

        public int AtoID => _ato.Id;

        public string Nome { get; set; }

        public decimal CustasIpesp { get; set; }

        public decimal CustasIss { get; set; }

        public decimal CustasOficial { get; set; }

        public decimal TotalCustas => CustasIpesp + CustasIss + CustasOficial;

        public AtosVM()
        {
            _ato = new Ato();
            Nome = string.Empty;
        }
    }
}