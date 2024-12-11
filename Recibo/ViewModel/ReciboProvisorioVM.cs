using Microsoft.EntityFrameworkCore;
using Recibo.Models;
using System.Collections.ObjectModel;

namespace Recibo.ViewModel
{
    internal class ReciboProvisorioVM
    {
        private readonly ReciboProvisorio _reciboProvisorio;
        private readonly recibos_dbContext _context;

        public int ReciboProvisorioID => _reciboProvisorio.Id;

        public string Requerente { get; set; }

        public DateTime? Data => _reciboProvisorio.Data;

        public ObservableCollection<ReciboProvisorioAto> Atos { get; } = new ObservableCollection<ReciboProvisorioAto>();

        public string? CodigoAto { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public ReciboProvisorioVM()
        {
            _context = new recibos_dbContext();
            _reciboProvisorio = new ReciboProvisorio { Data = DateTime.Now };
            Requerente = string.Empty;
        }

        /// <summary>
        /// Adiciona um Ato ao ReciboProvisorio.
        /// </summary>
        /// <exception cref="ArgumentException">Lançado quando o Ato não é informado ou quando a quantidade não é maior que 0</exception>
        public void AddAto()
        {
            if (string.IsNullOrEmpty(CodigoAto))
            {
                throw new ArgumentException("Ato não informado");
            }
            if (Quantidade <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero");
            }

            var ato = _context.Atos.FirstOrDefault(a => a.Codigo == CodigoAto) ?? throw new ArgumentException("Ato inexistente");
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
                _context.ReciboProvisorioAtos.Remove(ato);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.RecibosProvisorios.Add(_reciboProvisorio);
            foreach (var ato in Atos)
            {
                _context.ReciboProvisorioAtos.Add(ato);
            }
            _context.SaveChanges();
        }

        public ObservableCollection<ReciboProvisorioAto> GetAtosByReciboProvisorioId(int reciboProvisorioId)
        {
            var atos = _context.ReciboProvisorioAtos
                               .Where(rpa => rpa.ReciboProvisorioId == reciboProvisorioId)
                               .Include(rpa => rpa.Ato)
                               .ToList();

            return new ObservableCollection<ReciboProvisorioAto>(atos);
        }
    }
}
