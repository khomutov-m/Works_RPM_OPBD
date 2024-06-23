using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task003
{
    public partial class MultiplicationTableForm : Form
    {
        public MultiplicationTableForm()
        {
            InitializeComponent();
        }

        private void MultiplicationTableButton_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            var workbook = excelApp.Workbooks.Add();
            var worksheet = workbook.Worksheets[1];
            int startRow = 10;
            int startColumn = 3;
            for (int i = 2; i <= 9; i++)
            {
                worksheet.Cells[i][2].Value = i;
                for (int j = 2; j <= 9; j++)
                {
                    worksheet.Cells[1][j+1].Value = j;
                    worksheet.Cells[i][j+1].Value = i * j;
                }
            }
        }
    }
}
