namespace M11_Ficha3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txttele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Funcionário:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(121, 13);
            this.txtnome.Multiline = true;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(177, 31);
            this.txtnome.TabIndex = 3;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(121, 63);
            this.txtidade.Multiline = true;
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(177, 31);
            this.txtidade.TabIndex = 4;
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "N1",
            "N2",
            "N3"});
            this.cbotipo.Location = new System.Drawing.Point(246, 189);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(146, 21);
            this.cbotipo.TabIndex = 5;
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(48, 236);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(103, 32);
            this.btninserir.TabIndex = 6;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnlistar
            // 
            this.btnlistar.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistar.Location = new System.Drawing.Point(169, 236);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(103, 32);
            this.btnlistar.TabIndex = 7;
            this.btnlistar.Text = "Listar";
            this.btnlistar.UseVisualStyleBackColor = true;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Segoe Script", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(287, 236);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(103, 32);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(121, 118);
            this.txttele.Multiline = true;
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(177, 31);
            this.txttele.TabIndex = 10;
            this.txttele.TextChanged += new System.EventHandler(this.txttele_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(432, 301);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "´9+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.Label label4;
    }
}

