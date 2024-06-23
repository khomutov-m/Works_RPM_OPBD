using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class CreateDocumentForm : Form
    {
        public CreateDocumentForm()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            var word = new Word.Application();
            word.Visible = true;
            var document = word.Documents.Add(Path.Combine(Environment.CurrentDirectory, "Шаблон.docx"));
            int lastPart = 0;
            for (int i = 0; i + 255 < SourceTextBox.Text.Length; lastPart = i += 255)
            {
                document.Content.Find.Execute(FindText: "ТекстИзПоляВвода", ReplaceWith: $"{SourceTextBox.Text.Substring(i, 239)}ТекстИзПоляВвода");
            }
            document.Content.Find.Execute(FindText: "ТекстИзПоляВвода", ReplaceWith: SourceTextBox.Text.Substring(lastPart));
            document.Content.Find.Execute(FindText: "дд.мм.гггг чч:мм", ReplaceWith: DateTime.Now);
            var table = document.Tables[1];
            int count = Convert.ToInt32(CountTaskTextBox.Text);
            for (int i = 1; i < count; i++)
            {
                table.Rows.Add();
                table.Cell(i + 1, 1).Range.Text = i.ToString();
            }
            table.Cell(count + 2, 1).Range.Text = count.ToString();

            WordSaveFileDialog.Filter = "Word document|*.docx|PDF document|*.pdf";
            if (WordSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string format = Path.GetExtension(WordSaveFileDialog.FileName);
                if (format == ".pdf")
                    document.SaveAs(WordSaveFileDialog.FileName, Word.WdSaveFormat.wdFormatPDF);
                else
                    document.SaveAs(WordSaveFileDialog.FileName);
            }
        }
    }
}
