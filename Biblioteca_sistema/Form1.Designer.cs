
namespace Biblioteca_sistema
{
    partial class FormBiblioteca_sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiblioteca_sistema));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxEditora = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgsistema_biblioteca = new System.Windows.Forms.DataGridView();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btInserir = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgsistema_biblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrição";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(135, 24);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(119, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(298, 23);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 3;
            // 
            // textBoxEditora
            // 
            this.textBoxEditora.Location = new System.Drawing.Point(450, 23);
            this.textBoxEditora.Name = "textBoxEditora";
            this.textBoxEditora.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditora.TabIndex = 4;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(614, 24);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoria.TabIndex = 5;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(135, 92);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgsistema_biblioteca
            // 
            this.dgsistema_biblioteca.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgsistema_biblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsistema_biblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaAutor,
            this.ColunaEditora,
            this.ColunaCategoria,
            this.ColunaDescricao});
            this.dgsistema_biblioteca.Location = new System.Drawing.Point(27, 162);
            this.dgsistema_biblioteca.Name = "dgsistema_biblioteca";
            this.dgsistema_biblioteca.Size = new System.Drawing.Size(903, 276);
            this.dgsistema_biblioteca.TabIndex = 11;
            this.dgsistema_biblioteca.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsistema_biblioteca_CellContentClick);
            // 
            // ColunaID
            // 
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.ReadOnly = true;
            this.ColunaID.Width = 30;
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.Width = 200;
            // 
            // ColunaAutor
            // 
            this.ColunaAutor.HeaderText = "Autor";
            this.ColunaAutor.Name = "ColunaAutor";
            this.ColunaAutor.Width = 150;
            // 
            // ColunaEditora
            // 
            this.ColunaEditora.HeaderText = "Editora";
            this.ColunaEditora.Name = "ColunaEditora";
            this.ColunaEditora.Width = 115;
            // 
            // ColunaCategoria
            // 
            this.ColunaCategoria.HeaderText = "Categoria";
            this.ColunaCategoria.Name = "ColunaCategoria";
            this.ColunaCategoria.Width = 115;
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.HeaderText = "Descrição ";
            this.ColunaDescricao.Name = "ColunaDescricao";
            this.ColunaDescricao.Width = 250;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(27, 92);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 7;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(781, 23);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(149, 20);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(251, 92);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(48, 24);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(37, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluir.Location = new System.Drawing.Point(360, 92);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormBiblioteca_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dgsistema_biblioteca);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxEditora);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBiblioteca_sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FormBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsistema_biblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxEditora;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgsistema_biblioteca;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
    }
}
