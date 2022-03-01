namespace TarihGöster
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbTarihVarsayilan = new System.Windows.Forms.Label();
            this.lbTarihFormatli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "TarihGöster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTarihVarsayilan
            // 
            this.lbTarihVarsayilan.AutoSize = true;
            this.lbTarihVarsayilan.Location = new System.Drawing.Point(78, 72);
            this.lbTarihVarsayilan.Name = "lbTarihVarsayilan";
            this.lbTarihVarsayilan.Size = new System.Drawing.Size(79, 13);
            this.lbTarihVarsayilan.TabIndex = 1;
            this.lbTarihVarsayilan.Text = "VarsayılanTarih";
            // 
            // lbTarihFormatli
            // 
            this.lbTarihFormatli.AutoSize = true;
            this.lbTarihFormatli.Location = new System.Drawing.Point(78, 98);
            this.lbTarihFormatli.Name = "lbTarihFormatli";
            this.lbTarihFormatli.Size = new System.Drawing.Size(67, 13);
            this.lbTarihFormatli.TabIndex = 2;
            this.lbTarihFormatli.Text = "FormatlıTarih";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 254);
            this.Controls.Add(this.lbTarihFormatli);
            this.Controls.Add(this.lbTarihVarsayilan);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TarihGösterme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTarihVarsayilan;
        private System.Windows.Forms.Label lbTarihFormatli;
    }
}

