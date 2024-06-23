namespace Task1
{
    partial class CreateDocumentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.CountTaskTextBox = new System.Windows.Forms.TextBox();
            this.CreateDocumentButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.WordSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(1, 1);
            this.SourceTextBox.Multiline = true;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(800, 232);
            this.SourceTextBox.TabIndex = 0;
            // 
            // CountTaskTextBox
            // 
            this.CountTaskTextBox.Location = new System.Drawing.Point(137, 278);
            this.CountTaskTextBox.Name = "CountTaskTextBox";
            this.CountTaskTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountTaskTextBox.TabIndex = 1;
            // 
            // CreateDocumentButton
            // 
            this.CreateDocumentButton.Location = new System.Drawing.Point(62, 343);
            this.CreateDocumentButton.Name = "CreateDocumentButton";
            this.CreateDocumentButton.Size = new System.Drawing.Size(175, 23);
            this.CreateDocumentButton.TabIndex = 2;
            this.CreateDocumentButton.Text = "Создать документ по шаблону";
            this.CreateDocumentButton.UseVisualStyleBackColor = true;
            this.CreateDocumentButton.Click += new System.EventHandler(this.CreateDocumentButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(10, 278);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(111, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Количество заданий";
            // 
            // CreateDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CreateDocumentButton);
            this.Controls.Add(this.CountTaskTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.Name = "CreateDocumentForm";
            this.Text = "CreateDocumentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox CountTaskTextBox;
        private System.Windows.Forms.Button CreateDocumentButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.SaveFileDialog WordSaveFileDialog;
    }
}

