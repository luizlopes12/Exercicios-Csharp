namespace Funcionarios_Slash
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvEmpregadoExcluir = new System.Windows.Forms.DataGridView();
            this.btnConsultarCpf = new System.Windows.Forms.Button();
            this.mskConsultaRg = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(309, 337);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(139, 44);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir Empregado";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvEmpregadoExcluir
            // 
            this.dgvEmpregadoExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregadoExcluir.Location = new System.Drawing.Point(11, 142);
            this.dgvEmpregadoExcluir.Name = "dgvEmpregadoExcluir";
            this.dgvEmpregadoExcluir.Size = new System.Drawing.Size(437, 189);
            this.dgvEmpregadoExcluir.TabIndex = 10;
            // 
            // btnConsultarCpf
            // 
            this.btnConsultarCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCpf.Location = new System.Drawing.Point(309, 70);
            this.btnConsultarCpf.Name = "btnConsultarCpf";
            this.btnConsultarCpf.Size = new System.Drawing.Size(139, 35);
            this.btnConsultarCpf.TabIndex = 9;
            this.btnConsultarCpf.Text = "Consultar CPF";
            this.btnConsultarCpf.UseVisualStyleBackColor = true;
            this.btnConsultarCpf.Click += new System.EventHandler(this.btnConsultarCpf_Click);
            // 
            // mskConsultaRg
            // 
            this.mskConsultaRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskConsultaRg.Location = new System.Drawing.Point(173, 75);
            this.mskConsultaRg.Mask = "00.000.000-0";
            this.mskConsultaRg.Name = "mskConsultaRg";
            this.mskConsultaRg.Size = new System.Drawing.Size(114, 23);
            this.mskConsultaRg.TabIndex = 8;
            this.mskConsultaRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskConsultaCpf_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "consultar por cpf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Excluir dados dos empregados";
            // 
            // frmExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 399);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEmpregadoExcluir);
            this.Controls.Add(this.btnConsultarCpf);
            this.Controls.Add(this.mskConsultaRg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExcluir";
            this.Text = "Excluir dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvEmpregadoExcluir;
        private System.Windows.Forms.Button btnConsultarCpf;
        private System.Windows.Forms.MaskedTextBox mskConsultaRg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}