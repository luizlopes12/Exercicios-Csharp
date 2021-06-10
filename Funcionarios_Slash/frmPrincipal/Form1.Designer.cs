namespace frmPrincipal
{
    partial class Form1
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
            this.mskRg = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskRg
            // 
            this.mskRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskRg.Location = new System.Drawing.Point(116, 97);
            this.mskRg.Mask = "99.999.999-9";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(100, 23);
            this.mskRg.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 20);
            this.txtNome.TabIndex = 1;
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mskData.Location = new System.Drawing.Point(116, 153);
            this.mskData.Mask = "99/99/9999";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(100, 23);
            this.mskData.TabIndex = 2;
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSal.Location = new System.Drawing.Point(116, 183);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(100, 23);
            this.txtSal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data de admissão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RG:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(116, 230);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 37);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpar.Location = new System.Drawing.Point(347, 334);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 369);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskRg);
            this.Name = "Form1";
            this.Text = "Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}

