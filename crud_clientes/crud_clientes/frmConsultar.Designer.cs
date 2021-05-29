namespace crud_clientes
{
    partial class frmConsultar
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
            this.btnConsultarPorRg = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvConsultar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // mskRg
            // 
            this.mskRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mskRg.Location = new System.Drawing.Point(192, 56);
            this.mskRg.Mask = "99.999.999-9";
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(111, 26);
            this.mskRg.TabIndex = 0;
            this.mskRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskRg_MaskInputRejected);
            // 
            // btnConsultarPorRg
            // 
            this.btnConsultarPorRg.Location = new System.Drawing.Point(326, 51);
            this.btnConsultarPorRg.Name = "btnConsultarPorRg";
            this.btnConsultarPorRg.Size = new System.Drawing.Size(142, 38);
            this.btnConsultarPorRg.TabIndex = 1;
            this.btnConsultarPorRg.Text = "Consultar por RG";
            this.btnConsultarPorRg.UseVisualStyleBackColor = true;
            this.btnConsultarPorRg.Click += new System.EventHandler(this.btnConsultarPorRg_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(26, 51);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(141, 38);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvConsultar
            // 
            this.dgvConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar.Location = new System.Drawing.Point(26, 95);
            this.dgvConsultar.Name = "dgvConsultar";
            this.dgvConsultar.Size = new System.Drawing.Size(442, 271);
            this.dgvConsultar.TabIndex = 3;
            this.dgvConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 378);
            this.Controls.Add(this.dgvConsultar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnConsultarPorRg);
            this.Controls.Add(this.mskRg);
            this.Name = "frmConsultar";
            this.Text = "Consultar cliente";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskRg;
        private System.Windows.Forms.Button btnConsultarPorRg;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvConsultar;
    }
}