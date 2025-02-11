using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recibo.Models;

namespace Recibo.ViewModel
{
    public class ReciboDefinitivoVM
    {
        private readonly recibos_dbContext _context;
        private readonly ReciboDefinitivo _recibo;
        private readonly ILogger<ReciboDefinitivoVM> _logger;

        public string Requerente { get; set; }
        public string? Cpf { get; set; }
        public DateTime? Data => _recibo.Data;

        public ObservableCollection<ReciboAto> Atos { get; } = new();

        public string? CodigoAto { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }

        public ReciboDefinitivoVM(ILogger<ReciboDefinitivoVM> logger)
        {
            _context = new recibos_dbContext();
            _recibo = new ReciboDefinitivo { Data = DateTime.Now };
            Requerente = string.Empty;
            Cpf = string.Empty;
            _logger = logger;
        }

        /// <summary>
        /// Adiciona um Ato ao Recibo.
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
            var reciboAto = new ReciboAto
            {
                Ato = ato,
                Quantidade = Quantidade,
                Descricao = Descricao,
                Recibo = _recibo,
                ReciboId = _recibo.Id,
                AtoId = ato.Id
            };

            Atos.Add(reciboAto);
            _recibo.ReciboAtos.Add(reciboAto);
        }

        public void EditAto(int index)
        {
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

            var ato = _context.Atos.FirstOrDefault(a => a.Codigo == CodigoAto) ?? throw new ArgumentException("Ato inexistente");

            var reciboAto = Atos[index];
            reciboAto.Ato = ato;
            reciboAto.Descricao = Descricao;
            reciboAto.Quantidade = Quantidade;
            reciboAto.AtoId = ato.Id;

            _recibo.ReciboAtos.Remove(reciboAto);
            Atos.Remove(reciboAto);
            _recibo.ReciboAtos.Add(reciboAto);
            Atos.Add(reciboAto);
        }

        public void RemoveAto(int index)
        {
            if (index < 0 || index >= Atos.Count)
            {
                throw new ArgumentException("Índice inválido");
            }

            var reciboAto = Atos[index];
            _recibo.ReciboAtos.Remove(reciboAto);
            Atos.Remove(reciboAto);
        }

        public void SaveChanges()
        {
            _recibo.Requerente = Requerente;
            _recibo.Cpf = Cpf;

            if (_recibo.Id == 0)
            {
                _context.Recibos.Add(_recibo);
            }
            else
            {
                _context.Recibos.Update(_recibo);
            }

            try
            {
                _context.SaveChanges();

                foreach (var ra in Atos)
                {
                    ra.ReciboId = _recibo.Id;
                    ra.AtoId = ra.Ato.Id;

                    ra.Recibo = _recibo;
                    ra.Ato = _context.Atos.Find(ra.AtoId);

                    var existingAto = _context.ReciboAtos.FirstOrDefault(a => a.Id == ra.Id);

                    if (existingAto == null)
                    {
                        _context.ReciboAtos.Add(ra);
                    }
                    else
                    {
                        _context.Entry(existingAto).CurrentValues.SetValues(ra);
                    }
                }

                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var entries = ex.Entries;
                foreach (var entry in entries)
                {
                    var entityType = entry.Entity.GetType().Name;
                    var state = entry.State.ToString();
                    var originalValues = entry.OriginalValues.Properties
                        .ToDictionary(p => p.Name, p => entry.OriginalValues[p]?.ToString());
                    var currentValues = entry.CurrentValues.Properties
                        .ToDictionary(p => p.Name, p => entry.CurrentValues[p]?.ToString());

                    _logger.LogError($"Entity Type: {entityType}, State: {state}");
                    _logger.LogError("Original Values: " + string.Join(", ", originalValues.Select(kv => $"{kv.Key}: {kv.Value}")));
                    _logger.LogError("Current Values: " + string.Join(", ", currentValues.Select(kv => $"{kv.Key}: {kv.Value}")));
                }
                throw new Exception("Ocorreu um erro ao salvar o Recibo Definitivo no banco de dados.", ex);
            }
            catch (ValidationException ex)
            {
                throw new Exception("Os dados fornecidos são inválidos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado ao salvar o Recibo Definitivo.", ex);
            }
        }

        public ObservableCollection<ReciboAto> GetAtosByReciboId(int reciboId)
        {
            var atos = _context.ReciboAtos
                               .Where(ra => ra.ReciboId == reciboId)
                               .Include(ra => ra.Ato)
                               .ToList();

            return new ObservableCollection<ReciboAto>(atos);
        }

        /// <summary>
        /// Preenche automaticamente os atributos equivalentes no ReciboDefinitivo usando o Id do ReciboProvisorio.
        /// </summary>
        /// <param name="reciboProvisorioId">Id do ReciboProvisorio</param>
        public void FillFromReciboProvisorio(int reciboProvisorioId)
        {
            var reciboProvisorio = _context.RecibosProvisorios
                                           .Include(rp => rp.ReciboProvisorioAtos)
                                           .ThenInclude(rpa => rpa.Ato)
                                           .FirstOrDefault(rp => rp.Id == reciboProvisorioId);

            if (reciboProvisorio == null)
            {
                throw new ArgumentException("Recibo Provisório não encontrado.");
            }

            Requerente = reciboProvisorio.Requerente;
            Cpf = reciboProvisorio.Cpf;

            _recibo.ReciboProvisorioId = reciboProvisorio.Id;
            _recibo.Requerente = reciboProvisorio.Requerente;
            _recibo.Cpf = reciboProvisorio.Cpf;

            foreach (var reciboProvisorioAto in reciboProvisorio.ReciboProvisorioAtos)
            {
                var reciboAto = new ReciboAto
                {
                    Ato = reciboProvisorioAto.Ato,
                    Quantidade = reciboProvisorioAto.Quantidade,
                    Descricao = reciboProvisorioAto.Descricao,
                    Recibo = _recibo,
                    ReciboId = _recibo.Id,
                    AtoId = reciboProvisorioAto.AtoId
                };

                Atos.Add(reciboAto);
                _recibo.ReciboAtos.Add(reciboAto);
            }
        }
    }
}