using Recibo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo.Util
{
    public class Invoice
    {
        public int Id { get; set; }
        public required string NomeRequerente { get; set; }
        public DateTime DataEmissao { get; set; }

        public required IEnumerable<Ato> AtosPraticados { get; set; }
        public decimal Total => AtosPraticados.Sum(x => x.Total);
    }
}
