namespace LivrariaBoaLeitura
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
            this.lblAutorId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataPub = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdAutor2 = new System.Windows.Forms.TextBox();
            this.lblAutorId2 = new System.Windows.Forms.Label();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            this.btnGravarAutor = new System.Windows.Forms.Button();
            this.btnGravarLivro = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.boxAutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxAutor
            // 
            this.boxAutor.Controls.Add(this.txtNacionalidade);
            this.boxAutor.Controls.Add(this.txtNome);
            this.boxAutor.Controls.Add(this.txtId);
            this.boxAutor.Controls.Add(this.lblNacionalidade);
            this.boxAutor.Controls.Add(this.lblNome);
            this.boxAutor.Controls.Add(this.lblAutorId);
            this.boxAutor.Location = new System.Drawing.Point(12, 12);
            this.boxAutor.Name = "boxAutor";
            this.boxAutor.Size = new System.Drawing.Size(303, 188);
            this.boxAutor.TabIndex = 0;
            this.boxAutor.TabStop = false;
            this.boxAutor.Text = "Autor";
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(46, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(201, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(49, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(49, 147);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(201, 20);
            this.txtNacionalidade.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdAutor2);
            this.groupBox1.Controls.Add(this.lblAutorId2);
            this.groupBox1.Controls.Add(this.txtDataPub);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtLivroId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autor";
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
            this.txtLivroId.Size = new System.Drawing.Size(201, 20);
            this.txtLivroId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de Públicação";
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
            // txtIdAutor2
            // 
            this.txtIdAutor2.Location = new System.Drawing.Point(49, 196);
            this.txtIdAutor2.Name = "txtIdAutor2";
            this.txtIdAutor2.Size = new System.Drawing.Size(201, 20);
            this.txtIdAutor2.TabIndex = 8;
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
            // btnNovoAutor
            // 
            this.btnNovoAutor.Location = new System.Drawing.Point(321, 12);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(111, 32);
            this.btnNovoAutor.TabIndex = 8;
            this.btnNovoAutor.Text = "Novo Autor";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            // 
            // btnGravarAutor
            // 
            this.btnGravarAutor.Location = new System.Drawing.Point(321, 45);
            this.btnGravarAutor.Name = "btnGravarAutor";
            this.btnGravarAutor.Size = new System.Drawing.Size(111, 32);
            this.btnGravarAutor.TabIndex = 9;
            this.btnGravarAutor.Text = "Gravar Autor";
            this.btnGravarAutor.UseVisualStyleBackColor = true;
            // 
            // btnGravarLivro
            // 
            this.btnGravarLivro.Location = new System.Drawing.Point(321, 239);
            this.btnGravarLivro.Name = "btnGravarLivro";
            this.btnGravarLivro.Size = new System.Drawing.Size(111, 32);
            this.btnGravarLivro.TabIndex = 11;
            this.btnGravarLivro.Text = "Gravar Livro";
            this.btnGravarLivro.UseVisualStyleBackColor = true;
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(321, 206);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(111, 32);
            this.btnNovoLivro.TabIndex = 10;
            this.btnNovoLivro.Text = "Novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnGravarLivro);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.btnGravarAutor);
            this.Controls.Add(this.btnNovoAutor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxAutor);
            this.Name = "Form1";
            this.Text = "]";
            this.boxAutor.ResumeLayout(false);
            this.boxAutor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxAutor;
        private System.Windows.Forms.Label lblAutorId;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDataPub;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdAutor2;
        private System.Windows.Forms.Label lblAutorId2;
        private System.Windows.Forms.Button btnNovoAutor;
        private System.Windows.Forms.Button btnGravarAutor;
        private System.Windows.Forms.Button btnGravarLivro;
        private System.Windows.Forms.Button btnNovoLivro;
    }
}

