using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestClosedXML
{
    public class GerenciaProduto
    {
        public static List<Produto> _oProduto = new List<Produto>();

        public static void PreencheLista(Produto produto)
        {
            _oProduto.Add(produto);
        }

        public static void PopulaExcel()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Produtos");
                var currentRow = 1;

                #region Header
                worksheet.Cell(currentRow, 1).Value = "Loja";
                worksheet.Cell(currentRow, 2).Value = "Nome do Produto";
                worksheet.Cell(currentRow, 3).Value = "Valor à Vista";
                worksheet.Cell(currentRow, 4).Value = "Cashback";
                #endregion

                #region Body

                foreach (var produto in _oProduto)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = produto.Loja;
                    worksheet.Cell(currentRow, 2).Value = produto.Nome;
                    worksheet.Cell(currentRow, 3).Value = produto.Valor;
                    worksheet.Cell(currentRow, 4).Value = produto.Cashback;
                }

                #endregion

                workbook.SaveAs("C:\\Users\\...\\Documents\\Produtos.xlsx");

            }
        }
    }
}
