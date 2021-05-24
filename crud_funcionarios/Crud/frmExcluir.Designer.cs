namespace Crud
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
            this.mskConsultaCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultarCpf = new System.Windows.Forms.Button();
            this.dgvEmpregadoExcluir = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excluir dados dos empregados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "consultar por cpf:";
            // 
            // mskConsultaCpf
            // 
            this.mskConsultaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskConsultaCpf.Location = new System.Drawing.Point(174, 110);
            this.mskConsultaCpf.Mask = "000.000.000-00";
            this.mskConsultaCpf.Name = "mskConsultaCpf";
            this.mskConsultaCpf.Size = new System.Drawing.Size(114, 23);
            this.mskConsultaCpf.TabIndex = 2;
            // 
            // btnConsultarCpf
            // 
            this.btnConsultarCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCpf.Location = new System.Drawing.Point(310, 105);
            this.btnConsultarCpf.Name = "btnConsultarCpf";
            this.btnConsultarCpf.Size = new System.Drawing.Size(139, 35);
            this.btnConsultarCpf.TabIndex = 3;
            this.btnConsultarCpf.Text = "Consultar CPF";
            this.btnConsultarCpf.UseVisualStyleBackColor = true;
            this.btnConsultarCpf.Click += new System.EventHandler(this.btnConsultarCpf_Click);
            // 
            // dgvEmpregadoExcluir
            // 
            this.dgvEmpregadoExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregadoExcluir.Location = new System.Drawing.Point(12, 177);
            this.dgvEmpregadoExcluir.Name = "dgvEmpregadoExcluir";
            this.dgvEmpregadoExcluir.Size = new System.Drawing.Size(437, 189);
            this.dgvEmpregadoExcluir.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(310, 372);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Empregado";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 428);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEmpregadoExcluir);
            this.Controls.Add(this.btnConsultarCpf);
            this.Controls.Add(this.mskConsultaCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExcluir";
            this.Text = "Excluir empregados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskConsultaCpf;
        private System.Windows.Forms.Button btnConsultarCpf;
        private System.Windows.Forms.DataGridView dgvEmpregadoExcluir;
        private System.Windows.Forms.Button btnExcluir;
    }
}