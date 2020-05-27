namespace Scanner
{
    partial class ScannerForm
    {



        private System.ComponentModel.IContainer components = null;

       


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

       



        private void InitializeComponent()
        {
            this.LexemeTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowTokensButton = new System.Windows.Forms.Button();
            this.TokensLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.RichTextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LexemeTextBox
            // 
            this.LexemeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LexemeTextBox.Location = new System.Drawing.Point(16, 15);
            this.LexemeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LexemeTextBox.Name = "LexemeTextBox";
            this.LexemeTextBox.Size = new System.Drawing.Size(532, 984);
            this.LexemeTextBox.TabIndex = 0;
            this.LexemeTextBox.Text = "Enter your code here";
            this.LexemeTextBox.TextChanged += new System.EventHandler(this.TextboxClicked);
            // 
            // ShowTokensButton
            // 
            this.ShowTokensButton.Location = new System.Drawing.Point(600, 191);
            this.ShowTokensButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowTokensButton.Name = "ShowTokensButton";
            this.ShowTokensButton.Size = new System.Drawing.Size(100, 28);
            this.ShowTokensButton.TabIndex = 1;
            this.ShowTokensButton.Text = "Tokenize";
            this.ShowTokensButton.UseVisualStyleBackColor = true;
            this.ShowTokensButton.Click += new System.EventHandler(this.ShowButtonClicked);
            // 
            // TokensLabel
            // 
            this.TokensLabel.AutoSize = true;
            this.TokensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokensLabel.Location = new System.Drawing.Point(740, 18);
            this.TokensLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TokensLabel.Name = "TokensLabel";
            this.TokensLabel.Size = new System.Drawing.Size(242, 25);
            this.TokensLabel.TabIndex = 2;
            this.TokensLabel.Text = "Tokens will be shown here";
            this.TokensLabel.Click += new System.EventHandler(this.LabelClicked);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(600, 314);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(4);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(100, 28);
            this.RestartButton.TabIndex = 3;
            this.RestartButton.Text = "Restart ";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButtonClicked);
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParseTextBox.Location = new System.Drawing.Point(1270, 13);
            this.ParseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(532, 984);
            this.ParseTextBox.TabIndex = 4;
            this.ParseTextBox.Text = "";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(1123, 191);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(100, 28);
            this.ParseButton.TabIndex = 5;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1882, 903);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ParseTextBox);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.TokensLabel);
            this.Controls.Add(this.ShowTokensButton);
            this.Controls.Add(this.LexemeTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScannerForm";
            this.Text = "Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      


        private System.Windows.Forms.RichTextBox LexemeTextBox;
        private System.Windows.Forms.Button ShowTokensButton;
        private System.Windows.Forms.Label TokensLabel;
        private System.Windows.Forms.Button RestartButton;

        #endregion

        private System.Windows.Forms.RichTextBox ParseTextBox;
        private System.Windows.Forms.Button ParseButton;
    }
}

