namespace Task003
{
    partial class MultiplicationTableForm
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
            this.MultiplicationTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultiplicationTableButton
            // 
            this.MultiplicationTableButton.Location = new System.Drawing.Point(267, 167);
            this.MultiplicationTableButton.Name = "MultiplicationTableButton";
            this.MultiplicationTableButton.Size = new System.Drawing.Size(140, 65);
            this.MultiplicationTableButton.TabIndex = 0;
            this.MultiplicationTableButton.Text = "Таблица умножения";
            this.MultiplicationTableButton.UseVisualStyleBackColor = true;
            this.MultiplicationTableButton.Click += new System.EventHandler(this.MultiplicationTableButton_Click);
            // 
            // MultiplicationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MultiplicationTableButton);
            this.Name = "MultiplicationTableForm";
            this.Text = "MultiplicationTableForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MultiplicationTableButton;
    }
}

