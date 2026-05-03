namespace İrem_Eylül_Yüksel_2510225354
{
    partial class sıralama_büyükten_küçüğe
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
            label1.Location = new Point(136, 71);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
            label1.TabIndex = 0;
            label1.Text = "SIRALAMAK İSTEDİĞİNİZ SAYI GRUBUNU GİRİNİZ";
            // 
            // inputTextBox
            // 
            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(50, 110);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(600, 27);
            inputTextBox.TabIndex = 1;
            inputTextBox.PlaceholderText = "Örnek: 5, 3, 10, 1";
            // 
            // sortButton
            // 
            sortButton = new Button();
            sortButton.Location = new Point(660, 108);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(90, 30);
            sortButton.TabIndex = 2;
            sortButton.Text = "Sırala";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // resultListBox
            // 
            resultListBox = new ListBox();
            resultListBox.Location = new Point(50, 150);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(700, 240);
            resultListBox.TabIndex = 3;
            // 
            // sıralama_büyükten_küçüğe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(inputTextBox);
            Controls.Add(sortButton);
            Controls.Add(resultListBox);
            Name = "sıralama_büyükten_küçüğe";
            Text = "sıralama_büyükten_küçüğe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Button sortButton;
        private ListBox resultListBox;
    }
}