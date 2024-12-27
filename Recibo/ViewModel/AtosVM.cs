using Microsoft.EntityFrameworkCore;
using Recibo.Models;

namespace Recibo.ViewModel
{
    internal class AtosVM
    {
        private readonly Ato _ato;
        private readonly recibos_dbContext _context;

        public int AtoID => _ato.Id;

        public string Codigo { get; set; }

        public string Nome { get; set; }

        public decimal CustasIpesp { get; set; }

        public decimal CustasIss { get; set; }

        public decimal CustasOficial { get; set; }

        public decimal Total { get; set; }

        public AtosVM()
        {
            _context = new recibos_dbContext();
            _ato = new Ato();
            Codigo = string.Empty;
            Nome = string.Empty;
        }

        public void CreateAto(string codigo, string nome, decimal custasIpesp, decimal custasIss, decimal custasOficial)
        {
            this.Codigo = codigo ?? throw new Exception("O código do ato deve ser informado.");
            this.Nome = nome ?? throw new Exception("A descrição do ato deve ser informada.");
            this.CustasIpesp = custasIpesp;
            this.CustasIss = custasIss;
            this.CustasOficial = custasOficial;

            // Populate the _ato object with the provided values
            _ato.Codigo = this.Codigo;
            _ato.Nome = this.Nome;
            _ato.CustasIpesp = this.CustasIpesp;
            _ato.CustasIss = this.CustasIss;
            _ato.CustasOficial = this.CustasOficial;

            SaveAto();
        }

        private void SaveAto()
        {
            try
            {
                _context.Atos.Add(_ato);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Ocorreu um erro ao salvar o ato no banco de dados.", ex);
            }
        }

        public void DeleteAto(string codigo)
        {
            Ato ato = _context.Atos.FirstOrDefault(a => a.Codigo == codigo) ?? throw new Exception("Ato não encontrado.");

            _context.Atos.Remove(ato);
            _context.SaveChanges();
        }
    }
}