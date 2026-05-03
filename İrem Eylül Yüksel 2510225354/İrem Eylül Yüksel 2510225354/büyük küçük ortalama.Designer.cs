namespace İrem_Eylül_Yüksel_2510225354
{
    partial class büyük_küçük_ortalama
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 108);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "SAYI GRUBU GİRİNİZ";
            // 
            // inputTextBox
            // 
            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(50, 140);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(500, 27);
            inputTextBox.TabIndex = 1;
            inputTextBox.PlaceholderText = "Örnek: 1, 2, 3 veya 1 2 3";
            // 
            // computeButton
            // 
            computeButton = new Button();
            computeButton.Location = new Point(570, 138);
            computeButton.Name = "computeButton";
            computeButton.Size = new Size(90, 30);
            computeButton.TabIndex = 2;
            computeButton.Text = "Hesapla";
            computeButton.UseVisualStyleBackColor = true;
            computeButton.Click += computeButton_Click;
            // 
            // resultLabel
            // 
            resultLabel = new Label();
            resultLabel.AutoSize = false;
            resultLabel.Location = new Point(50, 180);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(610, 200);
            resultLabel.TabIndex = 3;
            resultLabel.Text = string.Empty;
            // 
            // büyük_küçük_ortalama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(inputTextBox);
            Controls.Add(computeButton);
            Controls.Add(resultLabel);
            Name = "büyük_küçük_ortalama";
            Text = "büyük_küçük_ortalama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Button computeButton;
        private Label resultLabel;
    }
}