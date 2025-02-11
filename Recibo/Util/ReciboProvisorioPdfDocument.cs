using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Recibo.Models;

namespace Recibo.Util
{
    public class ReciboProvisorioPdfDocument : IDocument
    {
        private readonly Models.Recibo _reciboProvisorio;

        public ReciboProvisorioPdfDocument(Models.Recibo reciboProvisorio)
        {
            _reciboProvisorio = reciboProvisorio;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(1, Unit.Centimetre);
                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
            });
        }

        void ComposeHeader(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Text($"RECIBO PROVISÓRIO Nº {_reciboProvisorio.Id}/2025").AlignRight().FontSize(12).FontFamily("Century Gothic");
                column.Item().Text($"Oficial de Registro Civil das Pessoas Naturais   |   CNPJ: 11.111.111/1111-11").Bold().FontSize(11).AlignCenter().FontFamily("Century Gothic");
                column.Item().Text($"Rua Tal, 123 - Centro  |  (99) 9999-9999  |  (11) 1111-1111  |  itu@cartorio.org.br").FontSize(11).AlignCenter().FontFamily("Century Gothic");
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text("");
                        column.Item().Text($"Interessado: {_reciboProvisorio.Requerente}").FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Total: {_reciboProvisorio.Total:C}").FontSize(10).FontFamily("Century Gothic");
                    });

                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text("");
                        column.Item().Text("");
                        column.Item().Text($"Data: {_reciboProvisorio.Data}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                    });
                });

                column.Item().Text("Atos praticados:").Bold().AlignCenter().FontSize(12).FontFamily("Century Gothic");

                column.Item().PaddingVertical(40).Column(column =>
                {
                        column.Item().Element(ComposeTable);
                });

                column.Item().AlignRight().Text($"Total de atos praticados: {_reciboProvisorio.ReciboProvisorioAtos.Sum(x => x.Total)}").Bold().AlignCenter().FontSize(10).FontFamily("Century Gothic");
                column.Item().Text("");
                column.Item().Text("");
                column.Item().Text("");
                column.Item().AlignCenter().Text("_______________________________________________").Bold().FontSize(12).FontFamily("Century Gothic");
                column.Item().AlignCenter().Text("Kauê Felippe Tiburcio").Bold().FontSize(11).FontFamily("Century Gothic");
                column.Item().AlignCenter().Text("Escrevente Autorizado").Bold().FontSize(10).FontFamily("Century Gothic");
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(); // Quantidade
                    columns.RelativeColumn(); // Nome do ato
                    columns.RelativeColumn(); // Descricao do ato
                    columns.RelativeColumn(); // Custas ISS
                    columns.RelativeColumn(); // Custas IPESP
                    columns.RelativeColumn(); // Custas Oficial
                    columns.RelativeColumn(); // Custas total
                });

                table.Header(header =>
                {
                    header.Cell().Element(CellStyling).Text("Quant.");
                    header.Cell().Element(CellStyling).Text("Ato");
                    header.Cell().Element(CellStyling).Text("Descrição");
                    header.Cell().Element(CellStyling).AlignRight().Text("ISS");
                    header.Cell().Element(CellStyling).AlignRight().Text("IPESP");
                    header.Cell().Element(CellStyling).AlignRight().Text("Oficial");
                    header.Cell().Element(CellStyling).AlignRight().Text("Total");

                    static IContainer CellStyling(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var ato in _reciboProvisorio.ReciboProvisorioAtos)
                {
                    table.Cell().Element(CellStyling).Text($"{ato.Quantidade}");
                    table.Cell().Element(CellStyling).Text($"{ato.AtoNome}");
                    table.Cell().Element(CellStyling).Text($"{ato.Descricao}");
                    table.Cell().Element(CellStyling).AlignRight().Text($"{ato.Ato.CustasIss:C}");
                    table.Cell().Element(CellStyling).AlignRight().Text($"{ato.Ato.CustasIpesp:C}");
                    table.Cell().Element(CellStyling).AlignRight().Text($"{ato.Ato.CustasOficial:C}");
                    table.Cell().Element(CellStyling).AlignRight().Text($"{ato.Total:C}");

                    static IContainer CellStyling(IContainer container)
                    {
                        return container.PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
                    }
                }
            });
        }
    }
}
