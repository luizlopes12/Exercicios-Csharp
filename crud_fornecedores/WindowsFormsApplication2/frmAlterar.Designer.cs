namespace WindowsFormsApplication2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarCnpj = new System.Windows.Forms.Button();
            this.mskConsultarCnpj = new System.Windows.Forms.MaskedTextBox();
            this.dgvAlterar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar dados do fornecedor";
            // 
            // btnConsultarCnpj
            // 
            this.btnConsultarCnpj.Location = new System.Drawing.Point(335, 85);
            this.btnConsultarCnpj.Name = "btnConsultarCnpj";
            this.btnConsultarCnpj.Size = new System.Drawing.Size(105, 27);
            this.btnConsultarCnpj.TabIndex = 8;
            this.btnConsultarCnpj.Text = "Consultar";
            this.btnConsultarCnpj.UseVisualStyleBackColor = true;
            this.btnConsultarCnpj.Click += new System.EventHandler(this.btnConsultarCnpj_Click);
            // 
            // mskConsultarCnpj
            // 
            this.mskConsultarCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskConsultarCnpj.Location = new System.Drawing.Point(170, 85);
            this.mskConsultarCnpj.Mask = "99.999.999/9999-99";
            this.mskConsultarCnpj.Name = "mskConsultarCnpj";
            this.mskConsultarCnpj.Size = new System.Drawing.Size(139, 23);
            this.mskConsultarCnpj.TabIndex = 7;
            this.mskConsultarCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskExcluirCnpj_MaskInputRejected);
            // 
            // dgvAlterar
            // 
            this.dgvAlterar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlterar.Location = new System.Drawing.Point(22, 120);
            this.dgvAlterar.Name = "dgvAlterar";
            this.dgvAlterar.Size = new System.Drawing.Size(440, 181);
            this.dgvAlterar.TabIndex = 6;
            this.dgvAlterar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlterar_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(37, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consultar por cnpj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 342);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 374);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(114, 407);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(157, 20);
            this.txtTel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConsultarCnpj);
            this.Controls.Add(this.mskConsultarCnpj);
            this.Controls.Add(this.dgvAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "Alterar dados";
            this.Load += new System.EventHandler(this.frmAlterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlterar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarCnpj;
        private System.Windows.Forms.MaskedTextBox mskConsultarCnpj;
        private System.Windows.Forms.DataGridView dgvAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}