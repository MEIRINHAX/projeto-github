namespace M11_Ficha3
{
    partial class frmlistar
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
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipofuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.idade,
            this.telefone,
            this.tipofuncionario,
            this.lucro});
            this.dgvlista.Location = new System.Drawing.Point(1, 1);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(798, 314);
            this.dgvlista.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // idade
            // 
            this.idade.HeaderText = "idade";
            this.idade.Name = "idade";
            // 
            // telefone
            // 
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.Width = 150;
            // 
            // tipofuncionario
            // 
            this.tipofuncionario.HeaderText = "tipo funcionario";
            this.tipofuncionario.Name = "tipofuncionario";
            this.tipofuncionario.Width = 200;
            // 
            // lucro
            // 
            this.lucro.HeaderText = "lucro";
            this.lucro.Name = "lucro";
            // 
            // frmlistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 312);
            this.Controls.Add(this.dgvlista);
            this.Name = "frmlistar";
            this.Text = "frmlistar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipofuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn lucro;
    }
}