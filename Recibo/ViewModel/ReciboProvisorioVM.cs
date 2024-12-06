using System;
using System.Collections.ObjectModel;
using Recibo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Recibo.ViewModel
{
    internal class ReciboProvisorioVM
    {
        private readonly ReciboProvisorio _reciboProvisorio;
        private readonly recibos_dbContext _context;

        public int ReciboProvisorioID => _reciboProvisorio.Id;

        public string Requerente { get; set; }

        public DateTime? Data => _reciboProvisorio.Data;

        public ObservableCollection<ReciboProvisorioAto> Atos { get; }

        public string? NomeAto { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public ReciboProvisorioVM(DbContextOptions<recibos_dbContext> options)
        {
            _context = new recibos_dbContext(options);
            _reciboProvisorio = new ReciboProvisorio { Data = DateTime.Now, Requerente = "" };
            Atos = new ObservableCollection<ReciboProvisorioAto>(_reciboProvisorio.ReciboProvisorioAtos);
        }

        /// <summary>
        /// Adiciona um Ato ao ReciboProvisorio.
        /// </summary>
        /// <exception cref="ArgumentException">Lançado quando o Ato não é informado ou quando a quantidade não é maior que 0</exception>
        public void AddAto()
        {
            if (string.IsNullOrEmpty(NomeAto))
            {
                throw new ArgumentException("Ato não informado");
            }
            if (Quantidade <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero");
            }

            var ato = new Ato { Nome = NomeAto };
            var reciboProvisorioAto = new ReciboProvisorioAto
            {
                Ato = ato,
                Quantidade = Quantidade,
                Descricao = Descricao,
                ReciboProvisorio = _reciboProvisorio
            };
            Atos.Add(reciboProvisorioAto);
            _reciboProvisorio.ReciboProvisorioAtos.Add(reciboProvisorioAto);
        }

        public void RemoveAto(ReciboProvisorioAto ato)
        {
            if (ato != null && Atos.Contains(ato))
            {
                Atos.Remove(ato);
                _reciboProvisorio.ReciboProvisorioAtos.Remove(ato);
            }
        }

        public void SaveChanges()
        {
            _context.RecibosProvisorios.Add(_reciboProvisorio);
            _context.SaveChanges();
        }
    }
}
