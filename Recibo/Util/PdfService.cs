using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using Recibo.Models;
using System.IO;

namespace Recibo.Util
{
    public class PdfService
    {
        private readonly recibos_dbContext _context;

        public PdfService(recibos_dbContext context)
        {
            _context = context;
        }

        public void GenerateReciboProvisorioPdf(int reciboProvisorioId, string outputPath)
        {
            var reciboProvisorio = _context.RecibosProvisorios
                .Include(r => r.ReciboProvisorioAtos)
                .FirstOrDefault(r => r.Id == reciboProvisorioId);

            if (reciboProvisorio != null)
            {
                var document = new ReciboProvisorioPdfDocument(reciboProvisorio);
                document.GeneratePdf(outputPath);
            }
        }
    }
}
