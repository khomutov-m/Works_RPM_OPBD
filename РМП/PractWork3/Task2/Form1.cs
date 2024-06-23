using Word = Microsoft.Office.Interop.Word;
namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            var word = new Word.Application();
            word.Visible = true;
            var document = word.Documents.Add();
            document.Paragraphs[1].Range.Text = SourceTextBox.Text;
            document.Range().Font.Size = 14;
            document.Range().Font.Name = "Times New Roman";
            document.Range().ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            document.Paragraphs.Add();
            document.Tables.Add(document.Paragraphs.Add().Range, 2, 2);
        }
    }
}
