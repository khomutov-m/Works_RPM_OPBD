namespace Task5
{
    partial class ChangeTextForm
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
            this.changedTextBox = new System.Windows.Forms.TextBox();
            this.changeTextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changedTextBox
            // 
            this.changedTextBox.Location = new System.Drawing.Point(12, 12);
            this.changedTextBox.Multiline = true;
            this.changedTextBox.Name = "changedTextBox";
            this.changedTextBox.Size = new System.Drawing.Size(678, 387);
            this.changedTextBox.TabIndex = 0;
            // 
            // changeTextButton
            // 
            this.changeTextButton.Location = new System.Drawing.Point(12, 405);
            this.changeTextButton.Name = "changeTextButton";
            this.changeTextButton.Size = new System.Drawing.Size(103, 27);
            this.changeTextButton.TabIndex = 1;
            this.changeTextButton.Text = "Замена";
            this.changeTextButton.UseVisualStyleBackColor = true;
            this.changeTextButton.Click += new System.EventHandler(this.ChangeTextButton_Click);
            // 
            // ChangeTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 460);
            this.Controls.Add(this.changeTextButton);
            this.Controls.Add(this.changedTextBox);
            this.Name = "ChangeTextForm";
            this.Text = "ChangeTextForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox changedTextBox;
        private System.Windows.Forms.Button changeTextButton;
    }
}

