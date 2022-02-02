
namespace TSystems.Formulario.WindowsForms.UI
{
    partial class frmPrincipal
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
            this.BtnLer = new System.Windows.Forms.Button();
            this.BtnContar = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnLer
            // 
            this.BtnLer.Location = new System.Drawing.Point(311, 22);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(75, 23);
            this.BtnLer.TabIndex = 0;
            this.BtnLer.Text = "Ler";
            this.BtnLer.UseVisualStyleBackColor = true;
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(230, 54);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(75, 23);
            this.BtnContar.TabIndex = 1;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 26);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(28, 15);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "URL";
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(12, 54);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(45, 15);
            this.lblPalavra.TabIndex = 3;
            this.lblPalavra.Text = "Palavra";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(63, 22);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(242, 23);
            this.txtSite.TabIndex = 4;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(63, 51);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(161, 23);
            this.txtPalavra.TabIndex = 4;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 15;
            this.lstStatus.Location = new System.Drawing.Point(12, 97);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(374, 304);
            this.lstStatus.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 412);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.BtnContar);
            this.Controls.Add(this.BtnLer);
            this.Name = "frmPrincipal";
            this.Text = "Exemplo de Download Assíncrono";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.ListBox lstStatus;
    }
}

