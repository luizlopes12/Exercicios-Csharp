﻿namespace crud_clientes
{
    partial class frmExcluir
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarPorRg = new System.Windows.Forms.Button();
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RG do cliente:";
            // 
            // btnConsultarPorRg
            // 
            this.btnConsultarPorRg.Location = new System.Drawing.Point(325, 42);
            this.btnConsultarPorRg.Name = "btnConsultarPorRg";
            this.btnConsultarPorRg.Size = new System.Drawing.Size(142, 38);
            this.btnConsultarPorRg.TabIndex = 3;
            this.btnConsultarPorRg.Text = "Consultar por RG";
            this.btnConsultarPorRg.UseVisualStyleBackColor = true;
            this.btnConsultarPorRg.Click += new System.EventHandler(this.btnConsultarPorRg_Click);
            // 
            // mskRg
            // 
            this.mskRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mskRg.Location = new System.Drawing.Point(166, 47);
            this.mskRg.Mask = "99.999.999-9";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(111, 26);
            this.mskRg.TabIndex = 2;
            this.mskRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskRg_MaskInputRejected);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Location = new System.Drawing.Point(25, 99);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.Size = new System.Drawing.Size(442, 271);
            this.dgvConsultar.TabIndex = 4;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultar_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(325, 397);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(142, 51);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 460);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.btnConsultarPorRg);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.label1);
            this.Name = "frmExcluir";
            this.Text = "Excluir dados dos clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPorRg;
        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.DataGridView dgvConsultar;
        private System.Windows.Forms.Button btnExcluir;
    }
}