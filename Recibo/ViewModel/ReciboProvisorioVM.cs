using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recibo.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Recibo.ViewModel
{
    public class ReciboProvisorioVM
    {
        private readonly recibos_dbContext _context;
        private readonly Models.Recibo _reciboProvisorio;
        private readonly ILogger<ReciboProvisorioVM> _logger;


        public string Requerente { get; set; }
        public string? Cpf { get; set; }

        public DateTime? Data => _reciboProvisorio.Data;

        public ObservableCollection<ReciboProvisorioAto> Atos { get; } = new();

        public string? CodigoAto { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public ReciboProvisorioVM(ILogger<ReciboProvisorioVM> logger)
        {
            _context = new recibos_dbContext();
            _reciboProvisorio = new Models.Recibo();
            Requerente = string.Empty;
            Cpf = string.Empty;
            _logger = logger;
        }

        /// <summary>
        /// Adiciona um Ato ao ReciboProvisorio.
        /// </summary>
        /// <exception cref="ArgumentException">Lançado quando o Ato não é informado ou quando a quantidade não é maior que 0</exception>
        public void AddAto()
        {
            if (string.IsNullOrEmpty(CodigoAto))
            {
                throw new ArgumentException("O código do Ato não foi informado.");
            }
            if (Quantidade <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero.");
            }

            var ato = _context.Atos.FirstOrDefault(a => a.Codigo == CodigoAto) ?? throw new ArgumentException("Ato inexistente");
            var reciboProvisorioAto = new ReciboProvisorioAto
            {
                Ato = ato,
                Quantidade = Quantidade,
                Descricao = Descricao,
                ReciboProvisorio = _reciboProvisorio,
                ReciboProvisorioId = _reciboProvisorio.Id,
                AtoId = ato.Id
            };

            reciboProvisorioAto.ReciboProvisorio = _reciboProvisorio;
            reciboProvisorioAto.Ato = ato;
            reciboProvisorioAto.AtoId = ato.Id;

            Atos.Add(reciboProvisorioAto);
            _reciboProvisorio.ReciboProvisorioAtos.Add(reciboProvisorioAto);
        }

        public void EditAto(int index)
        {
            // Check if the index, ato and quantidade is valid
            if (index < 0 || index >= Atos.Count)
            {
                throw new ArgumentException("Índice inválido");
            }
            if (string.IsNullOrEmpty(CodigoAto))
            {
                throw new ArgumentException("Ato não informado");
            }
            if (Quantidade <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero");
            }

            // Check if the Ato exists
            var ato = _context.Atos.FirstOrDefault(a => a.Codigo == CodigoAto) ?? throw new ArgumentException("Ato inexistente");

            // Update the ReciboProvisorioAto
            var reciboProvisorioAto = Atos[index];
            reciboProvisorioAto.Ato = ato;
            reciboProvisorioAto.Descricao = Descricao;
            reciboProvisorioAto.Quantidade = Quantidade;
            reciboProvisorioAto.AtoId = ato.Id;

            // Update the ReciboProvisorio
            _reciboProvisorio.ReciboProvisorioAtos.Remove(reciboProvisorioAto);
            Atos.Remove(reciboProvisorioAto);
            _reciboProvisorio.ReciboProvisorioAtos.Add(reciboProvisorioAto);
            Atos.Add(reciboProvisorioAto);
        }

        public void RemoveAto(int index)
        {
            // Check if the index is valid
            if (index < 0 || index >= Atos.Count)
            {
                throw new ArgumentException("Índice inválido");
            }

            // Remove the ReciboProvisorioAto from the ReciboProvisorio
            var reciboProvisorioAto = Atos[index];
            _reciboProvisorio.ReciboProvisorioAtos.Remove(reciboProvisorioAto);
            Atos.Remove(reciboProvisorioAto);
        }

        public void SaveChanges()
        {
            // Ensure the Requerente is set
            _reciboProvisorio.Requerente = Requerente;
            _reciboProvisorio.Cpf = Cpf;

            // Check if the ReciboProvisorio already exists in the context
            if (_reciboProvisorio.Id == 0)
            {
                _context.RecibosProvisorios.Add(_reciboProvisorio);
            }
            else
            {
                _context.RecibosProvisorios.Update(_reciboProvisorio);
            }

            try
            {
                // Save changes to ensure ReciboProvisorio gets an ID
                _context.SaveChanges();

                // Now add or update ReciboProvisorioAtos
                foreach (var rpa in Atos)
                {
                    // Ensure the ReciboProvisorioId is set
                    rpa.ReciboProvisorioId = _reciboProvisorio.Id;
                    rpa.AtoId = rpa.Ato.Id;

                    // Ensure the navigation properties are set
                    rpa.ReciboProvisorio = _reciboProvisorio;
                    rpa.Ato = _context.Atos.Find(rpa.AtoId);

                    // Check if the entity is already being tracked by the context
                    var existingAto = _context.ReciboProvisorioAtos
                                              .FirstOrDefault(a => a.Id == rpa.Id);

                    if (existingAto == null)
                    {
                        _context.ReciboProvisorioAtos.Add(rpa);
                    }
                    else
                    {
                        _context.Entry(existingAto).CurrentValues.SetValues(rpa);
                    }
                }

                // Save changes again to persist ReciboProvisorioAtos
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Log detailed information
                var entries = ex.Entries;
                foreach (var entry in entries)
                {
                    // Log entry details
                    var entityType = entry.Entity.GetType().Name;
                    var state = entry.State.ToString();
                    var originalValues = entry.OriginalValues.Properties
                        .ToDictionary(p => p.Name, p => entry.OriginalValues[p]?.ToString());
                    var currentValues = entry.CurrentValues.Properties
                        .ToDictionary(p => p.Name, p => entry.CurrentValues[p]?.ToString());

                    // Log the details using the logger instance
                    _logger.LogError($"Entity Type: {entityType}, State: {state}");
                    _logger.LogError("Original Values: " + string.Join(", ", originalValues.Select(kv => $"{kv.Key}: {kv.Value}")));
                    _logger.LogError("Current Values: " + string.Join(", ", currentValues.Select(kv => $"{kv.Key}: {kv.Value}")));
                }
                throw new Exception("Ocorreu um erro ao salvar o Recibo Provisório no banco de dados.", ex);
            }
            catch (ValidationException ex)
            {
                // Handle validation exceptions
                throw new Exception("Os dados fornecidos são inválidos.", ex);
            }
            catch (Exception ex)
            {
                // Handle all other exceptions
                throw new Exception("Ocorreu um erro inesperado ao salvar o Recibo Provisório.", ex);
            }
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
