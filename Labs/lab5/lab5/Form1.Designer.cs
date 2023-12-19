namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.searchTimeTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loadTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 33);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(191, 46);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Выбрать файл";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(334, 244);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 46);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 25;
            this.wordListBox.Location = new System.Drawing.Point(12, 99);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(317, 129);
            this.wordListBox.TabIndex = 2;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 25;
            this.resultsListBox.Location = new System.Drawing.Point(12, 306);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(403, 179);
            this.resultsListBox.TabIndex = 3;
            // 
            // searchTimeTextBox
            // 
            this.searchTimeTextBox.Enabled = false;
            this.searchTimeTextBox.Location = new System.Drawing.Point(12, 500);
            this.searchTimeTextBox.Name = "searchTimeTextBox";
            this.searchTimeTextBox.Size = new System.Drawing.Size(305, 31);
            this.searchTimeTextBox.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 252);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(305, 31);
            this.searchTextBox.TabIndex = 5;
            // 
            // loadTimeTextBox
            // 
            this.loadTimeTextBox.Enabled = false;
            this.loadTimeTextBox.Location = new System.Drawing.Point(221, 41);
            this.loadTimeTextBox.Name = "loadTimeTextBox";
            this.loadTimeTextBox.Size = new System.Drawing.Size(305, 31);
            this.loadTimeTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.loadTimeTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchTimeTextBox);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.wordListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.browseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox loadTimeTextBox;

        private System.Windows.Forms.TextBox searchTextBox;

        private System.Windows.Forms.TextBox searchTimeTextBox;

        private System.Windows.Forms.ListBox resultsListBox;

        private System.Windows.Forms.ListBox wordListBox;

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.Button browseButton;

        #endregion
    }
}