namespace ProjetoTelaSplash
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.pgbCarrega = new System.Windows.Forms.ProgressBar();
            this.timeSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagem
            // 
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(235, 163);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(51, 40);
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // pgbCarrega
            // 
            this.pgbCarrega.Location = new System.Drawing.Point(48, 232);
            this.pgbCarrega.Name = "pgbCarrega";
            this.pgbCarrega.Size = new System.Drawing.Size(428, 10);
            this.pgbCarrega.TabIndex = 1;
            // 
            // timeSplash
            // 
            this.timeSplash.Enabled = true;
            this.timeSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 376);
            this.Controls.Add(this.pgbCarrega);
            this.Controls.Add(this.pbImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.ProgressBar pgbCarrega;
        private System.Windows.Forms.Timer timeSplash;
    }
}