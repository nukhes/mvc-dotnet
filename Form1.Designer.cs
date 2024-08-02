namespace MVC
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
            this.boxAutor = new System.Windows.Forms.GroupBox();
            this.btnBuscaAutor = new System.Windows.Forms.Button();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutorId = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAutorId = new System.Windows.Forms.Label();
            this.boxLivro = new System.Windows.Forms.GroupBox();
            this.txtAutorLivroId = new System.Windows.Forms.TextBox();
            this.lblAutorId2 = new System.Windows.Forms.Label();
            this.txtDataPub = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            this.btnGravarAutor = new System.Windows.Forms.Button();
            this.btnGravarLivro = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnBuscaLivro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscaLivroPorNome = new System.Windows.Forms.Button();
            this.btnBuscaAutorPorNome = new System.Windows.Forms.Button();
            this.boxAutor.SuspendLayout();
            this.boxLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxAutor
            // 
            this.boxAutor.Controls.Add(this.btnBuscaAutorPorNome);
            this.boxAutor.Controls.Add(this.btnBuscaAutor);
            this.boxAutor.Controls.Add(this.txtNacionalidade);
            this.boxAutor.Controls.Add(this.txtNome);
            this.boxAutor.Controls.Add(this.txtAutorId);
            this.boxAutor.Controls.Add(this.lblNacionalidade);
            this.boxAutor.Controls.Add(this.lblNome);
            this.boxAutor.Controls.Add(this.lblAutorId);
            this.boxAutor.Location = new System.Drawing.Point(12, 12);
            this.boxAutor.Name = "boxAutor";
            this.boxAutor.Size = new System.Drawing.Size(444, 188);
            this.boxAutor.TabIndex = 0;
            this.boxAutor.TabStop = false;
            this.boxAutor.Text = "Autor";
            // 
            // btnBuscaAutor
            // 
            this.btnBuscaAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnBuscaAutor.Location = new System.Drawing.Point(163, 31);
            this.btnBuscaAutor.Name = "btnBuscaAutor";
            this.btnBuscaAutor.Size = new System.Drawing.Size(32, 44);
            this.btnBuscaAutor.TabIndex = 7;
            this.btnBuscaAutor.Text = "🔎";
            this.btnBuscaAutor.UseVisualStyleBackColor = true;
            this.btnBuscaAutor.Click += new System.EventHandler(this.btnBuscaAutor_Click);
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(49, 147);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(220, 20);
            this.txtNacionalidade.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(49, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtAutorId
            // 
            this.txtAutorId.Location = new System.Drawing.Point(49, 45);
            this.txtAutorId.Name = "txtAutorId";
            this.txtAutorId.Size = new System.Drawing.Size(108, 20);
            this.txtAutorId.TabIndex = 4;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Location = new System.Drawing.Point(46, 131);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(75, 13);
            this.lblNacionalidade.TabIndex = 3;
            this.lblNacionalidade.Text = "Nacionalidade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblAutorId
            // 
            this.lblAutorId.AutoSize = true;
            this.lblAutorId.Location = new System.Drawing.Point(46, 29);
            this.lblAutorId.Name = "lblAutorId";
            this.lblAutorId.Size = new System.Drawing.Size(18, 13);
            this.lblAutorId.TabIndex = 1;
            this.lblAutorId.Text = "ID";
            // 
            // boxLivro
            // 
            this.boxLivro.Controls.Add(this.btnBuscaLivroPorNome);
            this.boxLivro.Controls.Add(this.btnBuscaLivro);
            this.boxLivro.Controls.Add(this.txtAutorLivroId);
            this.boxLivro.Controls.Add(this.lblAutorId2);
            this.boxLivro.Controls.Add(this.txtDataPub);
            this.boxLivro.Controls.Add(this.txtTitulo);
            this.boxLivro.Controls.Add(this.txtLivroId);
            this.boxLivro.Controls.Add(this.label1);
            this.boxLivro.Controls.Add(this.label2);
            this.boxLivro.Controls.Add(this.label3);
            this.boxLivro.Location = new System.Drawing.Point(12, 251);
            this.boxLivro.Name = "boxLivro";
            this.boxLivro.Size = new System.Drawing.Size(444, 246);
            this.boxLivro.TabIndex = 7;
            this.boxLivro.TabStop = false;
            this.boxLivro.Text = "Livro";
            // 
            // txtAutorLivroId
            // 
            this.txtAutorLivroId.Location = new System.Drawing.Point(49, 196);
            this.txtAutorLivroId.Name = "txtAutorLivroId";
            this.txtAutorLivroId.Size = new System.Drawing.Size(201, 20);
            this.txtAutorLivroId.TabIndex = 8;
            // 
            // lblAutorId2
            // 
            this.lblAutorId2.AutoSize = true;
            this.lblAutorId2.Location = new System.Drawing.Point(46, 180);
            this.lblAutorId2.Name = "lblAutorId2";
            this.lblAutorId2.Size = new System.Drawing.Size(61, 13);
            this.lblAutorId2.TabIndex = 7;
            this.lblAutorId2.Text = "ID do Autor";
            // 
            // txtDataPub
            // 
            this.txtDataPub.Location = new System.Drawing.Point(49, 147);
            this.txtDataPub.Name = "txtDataPub";
            this.txtDataPub.Size = new System.Drawing.Size(201, 20);
            this.txtDataPub.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(49, 95);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtLivroId
            // 
            this.txtLivroId.Location = new System.Drawing.Point(49, 45);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(108, 20);
            this.txtLivroId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de Publicação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // btnNovoAutor
            // 
            this.btnNovoAutor.Location = new System.Drawing.Point(12, 206);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(84, 32);
            this.btnNovoAutor.TabIndex = 8;
            this.btnNovoAutor.Text = "Novo Autor";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            this.btnNovoAutor.Click += new System.EventHandler(this.btnNovoAutor_Click);
            // 
            // btnGravarAutor
            // 
            this.btnGravarAutor.Location = new System.Drawing.Point(102, 206);
            this.btnGravarAutor.Name = "btnGravarAutor";
            this.btnGravarAutor.Size = new System.Drawing.Size(84, 32);
            this.btnGravarAutor.TabIndex = 9;
            this.btnGravarAutor.Text = "Gravar Autor";
            this.btnGravarAutor.UseVisualStyleBackColor = true;
            this.btnGravarAutor.Click += new System.EventHandler(this.btnGravarAutor_Click);
            // 
            // btnGravarLivro
            // 
            this.btnGravarLivro.Location = new System.Drawing.Point(102, 503);
            this.btnGravarLivro.Name = "btnGravarLivro";
            this.btnGravarLivro.Size = new System.Drawing.Size(84, 32);
            this.btnGravarLivro.TabIndex = 11;
            this.btnGravarLivro.Text = "Gravar Livro";
            this.btnGravarLivro.UseVisualStyleBackColor = true;
            this.btnGravarLivro.Click += new System.EventHandler(this.btnGravarLivro_Click);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(12, 503);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(84, 32);
            this.btnNovoLivro.TabIndex = 10;
            this.btnNovoLivro.Text = "Novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(192, 206);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(84, 32);
            this.btnBuscarAutor.TabIndex = 12;
            this.btnBuscarAutor.Text = "Buscar Autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.Location = new System.Drawing.Point(282, 206);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(84, 32);
            this.btnEditarAutor.TabIndex = 13;
            this.btnEditarAutor.Text = "Editar Autor";
            this.btnEditarAutor.UseVisualStyleBackColor = true;
            this.btnEditarAutor.Click += new System.EventHandler(this.btnEditarAutor_Click);
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.Location = new System.Drawing.Point(372, 206);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(84, 32);
            this.btnExcluirAutor.TabIndex = 14;
            this.btnExcluirAutor.Text = "Excluir Autor";
            this.btnExcluirAutor.UseVisualStyleBackColor = true;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.Location = new System.Drawing.Point(192, 503);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(84, 32);
            this.btnBuscarLivro.TabIndex = 15;
            this.btnBuscarLivro.Text = "Buscar Livro";
            this.btnBuscarLivro.UseVisualStyleBackColor = true;
            this.btnBuscarLivro.Click += new System.EventHandler(this.BtnBuscarLivro_Click);
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.Location = new System.Drawing.Point(282, 503);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(84, 32);
            this.btnEditarLivro.TabIndex = 16;
            this.btnEditarLivro.Text = "Editar Livro";
            this.btnEditarLivro.UseVisualStyleBackColor = true;
            this.btnEditarLivro.Click += new System.EventHandler(this.BtnEditarLivro_Click);
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(372, 503);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(84, 32);
            this.btnExcluirLivro.TabIndex = 17;
            this.btnExcluirLivro.Text = "Excluir Livro";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLivro.Click += new System.EventHandler(this.BtnExcluirLivro_Click);
            // 
            // btnBuscaLivro
            // 
            this.btnBuscaLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnBuscaLivro.Location = new System.Drawing.Point(163, 29);
            this.btnBuscaLivro.Name = "btnBuscaLivro";
            this.btnBuscaLivro.Size = new System.Drawing.Size(32, 50);
            this.btnBuscaLivro.TabIndex = 8;
            this.btnBuscaLivro.Text = "🔎";
            this.btnBuscaLivro.UseVisualStyleBackColor = true;
            this.btnBuscaLivro.Click += new System.EventHandler(this.BtnBuscaLivro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(466, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 485);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnBuscaLivroPorNome
            // 
            this.btnBuscaLivroPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBuscaLivroPorNome.Location = new System.Drawing.Point(201, 28);
            this.btnBuscaLivroPorNome.Name = "btnBuscaLivroPorNome";
            this.btnBuscaLivroPorNome.Size = new System.Drawing.Size(68, 51);
            this.btnBuscaLivroPorNome.TabIndex = 9;
            this.btnBuscaLivroPorNome.Text = "🔎Nome";
            this.btnBuscaLivroPorNome.UseVisualStyleBackColor = true;
            // 
            // btnBuscaAutorPorNome
            // 
            this.btnBuscaAutorPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBuscaAutorPorNome.Location = new System.Drawing.Point(201, 31);
            this.btnBuscaAutorPorNome.Name = "btnBuscaAutorPorNome";
            this.btnBuscaAutorPorNome.Size = new System.Drawing.Size(68, 44);
            this.btnBuscaAutorPorNome.TabIndex = 10;
            this.btnBuscaAutorPorNome.Text = "🔎Nome";
            this.btnBuscaAutorPorNome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluirLivro);
            this.Controls.Add(this.btnEditarLivro);
            this.Controls.Add(this.btnBuscarLivro);
            this.Controls.Add(this.btnExcluirAutor);
            this.Controls.Add(this.btnEditarAutor);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnGravarLivro);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.btnGravarAutor);
            this.Controls.Add(this.btnNovoAutor);
            this.Controls.Add(this.boxLivro);
            this.Controls.Add(this.boxAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Projeto MVC";
            this.boxAutor.ResumeLayout(false);
            this.boxAutor.PerformLayout();
            this.boxLivro.ResumeLayout(false);
            this.boxLivro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxAutor;
        private System.Windows.Forms.Label lblAutorId;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAutorId;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox boxLivro;
        private System.Windows.Forms.TextBox txtDataPub;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutorLivroId;
        private System.Windows.Forms.Label lblAutorId2;
        private System.Windows.Forms.Button btnNovoAutor;
        private System.Windows.Forms.Button btnGravarAutor;
        private System.Windows.Forms.Button btnGravarLivro;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.Button btnBuscaAutor;
        private System.Windows.Forms.Button btnExcluirAutor;
        private System.Windows.Forms.Button btnBuscarLivro;
        private System.Windows.Forms.Button btnEditarLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnBuscaLivro;
        private System.Windows.Forms.Button btnBuscaAutorPorNome;
        private System.Windows.Forms.Button btnBuscaLivroPorNome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

