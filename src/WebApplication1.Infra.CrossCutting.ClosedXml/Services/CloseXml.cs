using ClosedXML.Excel;
using System;
using System.Data;
using WebApplication1.Infra.CrossCutting.ClosedXml.Dtos;
using WebApplication1.Infra.CrossCutting.ClosedXml.Interfaces;

namespace WebApplication1.Infra.CrossCutting.ClosedXml.Services
{
    public class CloseXml : ICloseXml
    {
        public void GerarXls(ClosedXmlDto closedXmlDto)
        {
            try
            {
                var table = new DataTable();

                foreach (var coluna in closedXmlDto.Colunas)
                {
                    table.Columns.Add(coluna);
                }

                var workbook = new XLWorkbook();
                workbook.Worksheets.Add(table, "relatorio");
                workbook.SaveAs(@"C:\dev\Estudos\back\exemplo-xls\teste.xlsx");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
