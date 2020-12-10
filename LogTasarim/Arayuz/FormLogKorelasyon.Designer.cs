namespace LogTasarim
{
    partial class FormLogKorelasyon
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
            this.AppName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.AppName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.AppName.Location = new System.Drawing.Point(13, 9);
            this.AppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(653, 47);
            this.AppName.TabIndex = 8;
            this.AppName.Text = "Form Log Korelasyon Sayfası";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogKorelasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AppName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogKorelasyon";
            this.Text = "Log Parsing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppName;
    }
}