namespace WindowsFormsApplication2
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvExcluir = new System.Windows.Forms.DataGridView();
            this.mskExcluirCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarCnpj = new System.Windows.Forms.Button();
            this.btnExcluirCnpj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(109, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir dados do fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultar por cnpj:";
            // 
            // dgvExcluir
            // 
            this.dgvExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcluir.Location = new System.Drawing.Point(15, 126);
            this.dgvExcluir.Name = "dgvExcluir";
            this.dgvExcluir.Size = new System.Drawing.Size(440, 181);
            this.dgvExcluir.TabIndex = 2;
            // 
            // mskExcluirCnpj
            // 
            this.mskExcluirCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskExcluirCnpj.Location = new System.Drawing.Point(163, 91);
            this.mskExcluirCnpj.Mask = "99.999.999/9999-99";
            this.mskExcluirCnpj.Name = "mskExcluirCnpj";
            this.mskExcluirCnpj.Size = new System.Drawing.Size(139, 23);
            this.mskExcluirCnpj.TabIndex = 3;
            // 
            // btnConsultarCnpj
            // 
            this.btnConsultarCnpj.Location = new System.Drawing.Point(328, 91);
            this.btnConsultarCnpj.Name = "btnConsultarCnpj";
            this.btnConsultarCnpj.Size = new System.Drawing.Size(105, 27);
            this.btnConsultarCnpj.TabIndex = 4;
            this.btnConsultarCnpj.Text = "Consultar";
            this.btnConsultarCnpj.UseVisualStyleBackColor = true;
            this.btnConsultarCnpj.Click += new System.EventHandler(this.btnConsultarCnpj_Click);
            // 
            // btnExcluirCnpj
            // 
            this.btnExcluirCnpj.Location = new System.Drawing.Point(328, 331);
            this.btnExcluirCnpj.Name = "btnExcluirCnpj";
            this.btnExcluirCnpj.Size = new System.Drawing.Size(105, 43);
            this.btnExcluirCnpj.TabIndex = 5;
            this.btnExcluirCnpj.Text = "Excluir dados";
            this.btnExcluirCnpj.UseVisualStyleBackColor = true;
            this.btnExcluirCnpj.Click += new System.EventHandler(this.btnExcluirCnpj_Click);
            // 
            // frmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 386);
            this.Controls.Add(this.btnExcluirCnpj);
            this.Controls.Add(this.btnConsultarCnpj);
            this.Controls.Add(this.mskExcluirCnpj);
            this.Controls.Add(this.dgvExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExcluir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvExcluir;
        private System.Windows.Forms.MaskedTextBox mskExcluirCnpj;
        private System.Windows.Forms.Button btnConsultarCnpj;
        private System.Windows.Forms.Button btnExcluirCnpj;
    }
}