using Excel = Microsoft.Office.Interop.Excel;

object templatePath = Path.Combine(Environment.CurrentDirectory, "Template.xlsx");
var excelApp = new Excel.Application();
excelApp.Visible = true;

var workBook = excelApp.Workbooks.Add(templatePath);
Console.WriteLine("Введите путь к каталогу");
var directoryName = Console.ReadLine();
var directory = new DirectoryInfo(directoryName);
var files = directory.GetFiles("*", SearchOption.AllDirectories);
var worksheet = workBook.Worksheets[1];

for (int i = 1; i <= files.Length; i++)
{
    worksheet.Cells[1][i + 1] = i;
    worksheet.Cells[2][i + 1] = files[i - 1].Name;
    worksheet.Cells[3][i + 1] = $"{files[i - 1].Length} Б";
}
worksheet.Columns.Autofit();
worksheet.Rows.Autofit();
worksheet = workBook.Worksheets[2];
var subdirectory = directory.GetDirectories("*", SearchOption.AllDirectories);
for (int i = 1;i <= files.Length; i++)
{
    worksheet.Cells[1][i + 1] = i;
    worksheet.Cells[2][i + 1] = files[i - 1].Name;
}
worksheet.Columns.Autofit();
worksheet.Rows.Autofit();

