namespace calc2
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
            this.mskRes = new System.Windows.Forms.MaskedTextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskRes
            // 
            this.mskRes.Location = new System.Drawing.Point(122, 86);
            this.mskRes.Name = "mskRes";
            this.mskRes.Size = new System.Drawing.Size(281, 20);
            this.mskRes.TabIndex = 34;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(365, 240);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(38, 33);
            this.btnMult.TabIndex = 33;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.parametros);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(284, 240);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 33);
            this.btnIgual.TabIndex = 32;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(122, 240);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(203, 240);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 33);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(365, 201);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(38, 33);
            this.btnDiv.TabIndex = 29;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.parametros);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(284, 201);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 33);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(122, 201);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 33);
            this.btn7.TabIndex = 27;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(203, 201);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 33);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.gerarNum);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(365, 162);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(38, 33);
            this.btnMenos.TabIndex = 25;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.parametros);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(284, 162);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 33);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(122, 162);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 33);
            this.btn4.TabIndex = 23;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(203, 162);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 33);
            this.btn5.TabIndex = 22;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.gerarNum);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(365, 121);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(38, 33);
            this.btnMais.TabIndex = 21;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.parametros);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(284, 121);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 33);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(122, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 33);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.gerarNum);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(203, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 33);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.gerarNum);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 339);
            this.Controls.Add(this.mskRes);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.gerarNum);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskRes;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

