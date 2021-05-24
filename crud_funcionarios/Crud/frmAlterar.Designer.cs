namespace Crud
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvEmpregadoAlterar = new System.Windows.Forms.DataGridView();
            this.btnConsultarCpf = new System.Windows.Forms.Button();
            this.mskConsultaCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(311, 337);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(139, 44);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar dados";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvEmpregadoAlterar
            // 
            this.dgvEmpregadoAlterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregadoAlterar.Location = new System.Drawing.Point(13, 142);
            this.dgvEmpregadoAlterar.Name = "dgvEmpregadoAlterar";
            this.dgvEmpregadoAlterar.Size = new System.Drawing.Size(437, 189);
            this.dgvEmpregadoAlterar.TabIndex = 10;
            this.dgvEmpregadoAlterar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpregadoAlterar_CellContentClick);
            // 
            // btnConsultarCpf
            // 
            this.btnConsultarCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCpf.Location = new System.Drawing.Point(311, 70);
            this.btnConsultarCpf.Name = "btnConsultarCpf";
            this.btnConsultarCpf.Size = new System.Drawing.Size(139, 35);
            this.btnConsultarCpf.TabIndex = 9;
            this.btnConsultarCpf.Text = "Consultar CPF";
            this.btnConsultarCpf.UseVisualStyleBackColor = true;
            this.btnConsultarCpf.Click += new System.EventHandler(this.btnConsultarCpf_Click);
            // 
            // mskConsultaCpf
            // 
            this.mskConsultaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskConsultaCpf.Location = new System.Drawing.Point(167, 75);
            this.mskConsultaCpf.Mask = "000.000.000-00";
            this.mskConsultaCpf.Name = "mskConsultaCpf";
            this.mskConsultaCpf.Size = new System.Drawing.Size(114, 23);
            this.mskConsultaCpf.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "consultar por cpf:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alterar dados dos empregados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 382);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 13;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(81, 426);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(154, 20);
            this.txtSobrenome.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sobrenome";
            // 
            // mskCpf
            // 
            this.mskCpf.Enabled = false;
            this.mskCpf.Location = new System.Drawing.Point(81, 469);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(154, 20);
            this.mskCpf.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CPF";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 614);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvEmpregadoAlterar);
            this.Controls.Add(this.btnConsultarCpf);
            this.Controls.Add(this.mskConsultaCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "Alterar dados dos empregados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregadoAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvEmpregadoAlterar;
        private System.Windows.Forms.Button btnConsultarCpf;
        private System.Windows.Forms.MaskedTextBox mskConsultaCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label5;
    }
}