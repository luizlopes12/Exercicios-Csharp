namespace Funcionarios_Slash
{
    partial class frmAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterar));
            this.label5 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvFuncionarioAlterar = new System.Windows.Forms.DataGridView();
            this.btnConsultarRg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskConsultarRg = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "RG";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(72, 405);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(154, 20);
            this.txtSal.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Salario";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 353);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(313, 352);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(153, 44);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvFuncionarioAlterar
            // 
            this.dgvFuncionarioAlterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarioAlterar.Location = new System.Drawing.Point(29, 157);
            this.dgvFuncionarioAlterar.Name = "dgvFuncionarioAlterar";
            this.dgvFuncionarioAlterar.Size = new System.Drawing.Size(437, 189);
            this.dgvFuncionarioAlterar.TabIndex = 23;
            this.dgvFuncionarioAlterar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarioAlterar_CellContentClick);
            // 
            // btnConsultarRg
            // 
            this.btnConsultarRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConsultarRg.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarRg.Image")));
            this.btnConsultarRg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRg.Location = new System.Drawing.Point(327, 80);
            this.btnConsultarRg.Name = "btnConsultarRg";
            this.btnConsultarRg.Size = new System.Drawing.Size(139, 45);
            this.btnConsultarRg.TabIndex = 22;
            this.btnConsultarRg.Text = "Consultar RG";
            this.btnConsultarRg.UseVisualStyleBackColor = true;
            this.btnConsultarRg.Click += new System.EventHandler(this.btnConsultarRg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "consultar por RG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alterar dados dos empregados";
            // 
            // txtDataAd
            // 
            this.txtDataAd.Location = new System.Drawing.Point(72, 379);
            this.txtDataAd.Name = "txtDataAd";
            this.txtDataAd.Size = new System.Drawing.Size(154, 20);
            this.txtDataAd.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Data";
            // 
            // mskConsultarRg
            // 
            this.mskConsultarRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mskConsultarRg.Location = new System.Drawing.Point(171, 89);
            this.mskConsultarRg.Mask = "99.999.999-9";
            this.mskConsultarRg.Name = "mskConsultarRg";
            this.mskConsultarRg.Size = new System.Drawing.Size(141, 24);
            this.mskConsultarRg.TabIndex = 33;
            // 
            // txtRg
            // 
            this.txtRg.Enabled = false;
            this.txtRg.Location = new System.Drawing.Point(72, 431);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(154, 20);
            this.txtRg.TabIndex = 34;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 478);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.mskConsultarRg);
            this.Controls.Add(this.txtDataAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvFuncionarioAlterar);
            this.Controls.Add(this.btnConsultarRg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "Alterar dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarioAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvFuncionarioAlterar;
        private System.Windows.Forms.Button btnConsultarRg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskConsultarRg;
        private System.Windows.Forms.TextBox txtRg;
    }
}