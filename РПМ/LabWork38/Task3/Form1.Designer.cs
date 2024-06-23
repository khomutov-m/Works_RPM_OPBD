namespace Task3
{
    partial class Task2
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
            previousButton = new Button();
            label = new Label();
            pageTextBox = new TextBox();
            label1 = new Label();
            lastButton = new Button();
            firstButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            nextButton.Location = new Point(694, 371);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(29, 23);
            nextButton.TabIndex = 1;
            nextButton.Text = "->";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(659, 371);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(29, 23);
            previousButton.TabIndex = 2;
            previousButton.Text = "<-";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += PreviousButton_Click;
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
            // pageTextBox
            // 
            pageTextBox.Location = new Point(355, 415);
            pageTextBox.Name = "pageTextBox";
            pageTextBox.Size = new Size(22, 23);
            pageTextBox.TabIndex = 5;
            pageTextBox.TextChanged += PageTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 397);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 6;
            label1.Text = "Номер страницы";
            // 
            // lastButton
            // 
            lastButton.Location = new Point(729, 371);
            lastButton.Name = "lastButton";
            lastButton.Size = new Size(32, 23);
            lastButton.TabIndex = 7;
            lastButton.Text = "->|";
            lastButton.UseVisualStyleBackColor = true;
            lastButton.Click += LastButton_Click;
            // 
            // firstButton
            // 
            firstButton.Location = new Point(621, 371);
            firstButton.Name = "firstButton";
            firstButton.Size = new Size(32, 23);
            firstButton.TabIndex = 8;
            firstButton.Text = "|<-";
            firstButton.UseVisualStyleBackColor = true;
            firstButton.Click += FirstButton_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(firstButton);
            Controls.Add(lastButton);
            Controls.Add(label1);
            Controls.Add(pageTextBox);
            Controls.Add(label);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(dataGridView);
            Name = "Task2";
            Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button nextButton;
        private Button previousButton;
        private Label label;
        private TextBox pageTextBox;
        private Label label1;
        private Button lastButton;
        private Button firstButton;
    }
}
