namespace WinFormsApp2
{
    partial class Task1
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
            dataGridView = new DataGridView();
            nextButton = new Button();
            label = new Label();
            numericUpDown = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(776, 353);
            dataGridView.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(759, 371);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(29, 23);
            nextButton.TabIndex = 1;
            nextButton.Text = "+3";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 375);
            label.Name = "label";
            label.Size = new Size(27, 15);
            label.TabIndex = 3;
            label.Text = "text";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(328, 393);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(44, 23);
            numericUpDown.TabIndex = 4;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 375);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Размер страницы";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(numericUpDown);
            Controls.Add(label);
            Controls.Add(nextButton);
            Controls.Add(dataGridView);
            Name = "Task1";
            Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button nextButton;
        private Label label;
        private NumericUpDown numericUpDown;
        private Label label1;
    }
}
