using System;
using System.Collections.ObjectModel;
using Recibo.Models;

namespace Recibo.ViewModel
{
    internal class ReciboDefinitivoVM
    {
        private readonly ReciboDefinitivo _recibo;

        public int ReciboID => _recibo.Id;

        public string Requerente { get; set; }
        public DateTime? Data => _recibo.Data;

        public ObservableCollection<ReciboAto> Atos { get; }

        public string? NomeAto { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public ReciboDefinitivoVM()
        {
            _recibo = new ReciboDefinitivo { Data = DateTime.Now };
            Atos = new ObservableCollection<ReciboAto>(_recibo.ReciboAtos);
            Requerente = string.Empty;
        }

        /// <summary>
        /// Adiciona um Ato ao Recibo.
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
            var reciboAto = new ReciboAto
            {
                Ato = ato,
                Quantidade = Quantidade,
                Descricao = Descricao,
                Recibo = _recibo
            };
            Atos.Add(reciboAto);
            _recibo.ReciboAtos.Add(reciboAto);
        }

        public void RemoveAto(ReciboAto ato)
        {
            if (ato != null && Atos.Contains(ato))
            {
                Atos.Remove(ato);
                _recibo.ReciboAtos.Remove(ato);
            }
        }
    }
}