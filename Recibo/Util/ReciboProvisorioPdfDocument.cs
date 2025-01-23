using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Recibo.Models;

namespace Recibo.Util
{
public class ReciboProvisorioPdfDocument : IDocument
    {
        private readonly ReciboProvisorio _reciboProvisorio;

        public ReciboProvisorioPdfDocument(ReciboProvisorio reciboProvisorio)
        {
            _reciboProvisorio = reciboProvisorio;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(1, Unit.Centimetre);
                page.Content().Element(ComposeContent);
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Text($"RECIBO PROVISÓRIO Nº {_reciboProvisorio.Id}/2025").AlignRight().FontSize(12).FontFamily("Century Gothic");
                column.Item().Text($"Oficial de Registro Civil das Pessoas Naturais de Itu - SP   |   CNPJ: 50.365.998/0001/04").Bold().FontSize(11).AlignCenter().FontFamily("Century Gothic");
                column.Item().Text($"Praça Duque de Caxias, 46 - Centro  |  (11) 4023-7711  |  (11) 4022-4744  |  itu@arpensp.org.br").FontSize(11).AlignCenter().FontFamily("Century Gothic");
                column.Item().Text("");
                column.Item().Text($"Interessado: {_reciboProvisorio.Requerente}").FontSize(10).FontFamily("Century Gothic");
                column.Item().Text($"Total: {_reciboProvisorio.Total:C}").FontSize(10).FontFamily("Century Gothic");

                column.Item().Text("Atos praticados:").Bold().AlignCenter().FontSize(10).FontFamily("Century Gothic");
                foreach (var ato in _reciboProvisorio.ReciboProvisorioAtos)
                {
                    column.Item().Text($"{ato.Quantidade} - {ato.AtoNome} ({ato.Descricao}): {ato.Total:C}").FontSize(10).FontFamily("Century Gothic");
                }
            });
        }
    }
}
