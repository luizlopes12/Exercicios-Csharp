namespace crud_clientes
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
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.btnConsultarPorRg = new System.Windows.Forms.Button();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.mskRgConsultar = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Location = new System.Drawing.Point(22, 87);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.Size = new System.Drawing.Size(442, 271);
            this.dgvConsultar.TabIndex = 8;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick_1);
            // 
            // btnConsultarPorRg
            // 
            this.btnConsultarPorRg.Location = new System.Drawing.Point(322, 30);
            this.btnConsultarPorRg.Name = "btnConsultarPorRg";
            this.btnConsultarPorRg.Size = new System.Drawing.Size(142, 38);
            this.btnConsultarPorRg.TabIndex = 7;
            this.btnConsultarPorRg.Text = "Consultar por RG";
            this.btnConsultarPorRg.UseVisualStyleBackColor = true;
            this.btnConsultarPorRg.Click += new System.EventHandler(this.btnConsultarPorRg_Click);
            // 
            // mskRg
            // 
            this.mskRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mskRg.Location = new System.Drawing.Point(163, 35);
            this.mskRg.Mask = "99.999.999-9";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(111, 26);
            this.mskRg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "RG do cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 407);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(378, 20);
            this.txtNome.TabIndex = 14;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(86, 436);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(378, 20);
            this.txtEnd.TabIndex = 15;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(322, 493);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(142, 50);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // mskRgConsultar
            // 
            this.mskRgConsultar.Enabled = false;
            this.mskRgConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskRgConsultar.Location = new System.Drawing.Point(86, 374);
            this.mskRgConsultar.Mask = "99.999.999-9";
            this.mskRgConsultar.Name = "mskRgConsultar";
            this.mskRgConsultar.Size = new System.Drawing.Size(112, 23);
            this.mskRgConsultar.TabIndex = 18;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(86, 466);
            this.mskTel.Mask = "(99) 9999-9999";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 20);
            this.mskTel.TabIndex = 19;
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 555);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskRgConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.btnConsultarPorRg);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "Alterar dados dos clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnConsultarPorRg;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox mskRgConsultar;
        private System.Windows.Forms.MaskedTextBox mskTel;
    }
}