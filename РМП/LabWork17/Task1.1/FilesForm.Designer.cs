namespace Task1._1
{
    partial class FilesForm
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
            DataFiles = new DataGridView();
            Task1Button = new Button();
            Task2Button = new Button();
            Task3Button = new Button();
            Task4Button = new Button();
            Task5Button = new Button();
            PathTextBox = new TextBox();
            FileNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataFiles).BeginInit();
            SuspendLayout();
            // 
            // DataFiles
            // 
            DataFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataFiles.Location = new Point(3, 3);
            DataFiles.Name = "DataFiles";
            DataFiles.Size = new Size(827, 393);
            DataFiles.TabIndex = 0;
            // 
            // Task1Button
            // 
            Task1Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task1Button.Location = new Point(34, 413);
            Task1Button.Name = "Task1Button";
            Task1Button.Size = new Size(75, 23);
            Task1Button.TabIndex = 1;
            Task1Button.Text = "Задание 1";
            Task1Button.UseVisualStyleBackColor = true;
            Task1Button.Click += Task1Button_Click;
            // 
            // Task2Button
            // 
            Task2Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task2Button.Location = new Point(145, 413);
            Task2Button.Name = "Task2Button";
            Task2Button.Size = new Size(75, 23);
            Task2Button.TabIndex = 2;
            Task2Button.Text = "Задание 2";
            Task2Button.UseVisualStyleBackColor = true;
            Task2Button.Click += Task2Button_Click;
            // 
            // Task3Button
            // 
            Task3Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task3Button.Location = new Point(259, 413);
            Task3Button.Name = "Task3Button";
            Task3Button.Size = new Size(75, 23);
            Task3Button.TabIndex = 3;
            Task3Button.Text = "Задание 3";
            Task3Button.UseVisualStyleBackColor = true;
            Task3Button.Click += Task3Button_Click;
            // 
            // Task4Button
            // 
            Task4Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task4Button.Location = new Point(371, 413);
            Task4Button.Name = "Task4Button";
            Task4Button.Size = new Size(75, 23);
            Task4Button.TabIndex = 4;
            Task4Button.Text = "Задание 4";
            Task4Button.UseVisualStyleBackColor = true;
            Task4Button.Click += Task4Button_Click;
            // 
            // Task5Button
            // 
            Task5Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Task5Button.Location = new Point(485, 413);
            Task5Button.Name = "Task5Button";
            Task5Button.Size = new Size(75, 23);
            Task5Button.TabIndex = 5;
            Task5Button.Text = "Задание 5";
            Task5Button.UseVisualStyleBackColor = true;
            Task5Button.Click += Task5Button_Click;
            // 
            // PathTextBox
            // 
            PathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PathTextBox.Location = new Point(596, 413);
            PathTextBox.Name = "PathTextBox";
            PathTextBox.Size = new Size(100, 23);
            PathTextBox.TabIndex = 6;
            PathTextBox.Text = "V:\\\\ispp21";
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FileNameTextBox.Location = new Point(730, 413);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(100, 23);
            FileNameTextBox.TabIndex = 7;
            // 
            // FilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 450);
            Controls.Add(FileNameTextBox);
            Controls.Add(PathTextBox);
            Controls.Add(Task5Button);
            Controls.Add(Task4Button);
            Controls.Add(Task3Button);
            Controls.Add(Task2Button);
            Controls.Add(Task1Button);
            Controls.Add(DataFiles);
            Name = "FilesForm";
            Text = "FilesForm";
            ((System.ComponentModel.ISupportInitialize)DataFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataFiles;
        private Button Task1Button;
        private Button Task2Button;
        private Button Task3Button;
        private Button Task4Button;
        private Button Task5Button;
        private TextBox PathTextBox;
        private TextBox FileNameTextBox;
    }
}
