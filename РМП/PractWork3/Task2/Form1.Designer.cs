namespace Task2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SourceTextBox = new TextBox();
            CreateDocumentButton = new Button();
            SuspendLayout();
            // 
            // SourceTextBox
            // 
            SourceTextBox.Location = new Point(1, 0);
            SourceTextBox.Multiline = true;
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(800, 352);
            SourceTextBox.TabIndex = 0;
            // 
            // CreateDocumentButton
            // 
            CreateDocumentButton.Location = new Point(64, 373);
            CreateDocumentButton.Name = "CreateDocumentButton";
            CreateDocumentButton.Size = new Size(161, 33);
            CreateDocumentButton.TabIndex = 1;
            CreateDocumentButton.Text = "Создать документ";
            CreateDocumentButton.UseVisualStyleBackColor = true;
            CreateDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateDocumentButton);
            Controls.Add(SourceTextBox);
            Name = "Form1";
            Text = "CreateDocumentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SourceTextBox;
        private Button CreateDocumentButton;
    }
}
