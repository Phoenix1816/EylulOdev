namespace İrem_Eylül_Yüksel_2510225354
{
    partial class not_gösterici
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
            label1.Location = new Point(238, 96);
            label1.Name = "label1";
            label1.Size = new Size(272, 20);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİNİN ADI VE SOYADINI GİRİNİZ";
            // 
            // not_gösterici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "not_gösterici";
            Text = "not_gösterici";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}