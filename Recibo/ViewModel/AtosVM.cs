using System;
using Microsoft.EntityFrameworkCore;
using Recibo.Models;

namespace Recibo.ViewModel
{
    internal class AtosVM
    {
        private readonly Ato _ato;
        private readonly recibos_dbContext _context;

        public int AtoID => _ato.Id;

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal CustasIpesp { get; set; }

        public decimal CustasIss { get; set; }

        public decimal CustasOficial { get; set; }

        public decimal Total { get; set; }

        public AtosVM()
        {
            _context = new recibos_dbContext();
            _ato = new Ato();
            Nome = string.Empty;
            Descricao = string.Empty;
        }

        public void CreateAto(string nome, string descricao, decimal custasIpesp, decimal custasIss, decimal custasOficial)
        {
            this.Nome = nome ?? throw new Exception("O código do ato deve ser informado.");
            this.Descricao = descricao ?? throw new Exception("A descrição do ato deve ser informada.");
            this.CustasIpesp = custasIpesp;
            this.CustasIss = custasIss;
            this.CustasOficial = custasOficial;

            // Populate the _ato object with the provided values
            _ato.Nome = this.Nome;
            _ato.Descricao = this.Descricao;
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
                // Log or handle the exception as needed
                throw new Exception("An error occurred while saving the Ato to the database.", ex);
            }
        }

        public void DeleteAto(string nome) {
            Ato ato = _context.Atos.FirstOrDefault(a => a.Nome == nome) ?? throw new Exception("Ato não encontrado.");

            _context.Atos.Remove(ato);
            _context.SaveChanges();
        }
    }
}