using MVC.BO;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            boxAutor.Enabled = false;
            btnBuscaAutor.Visible = false;

            boxLivro.Enabled = false;
        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            boxAutor.Enabled = true;
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            boxLivro.Enabled= true;
        }

        private void btnGravarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;

            autorBO.Gravar(autor);
            SuccessMessage("Autor Cadastrado com sucesso!");

            ResetBoxAutor(false);
        }

        private void btnGravarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBo = new LivroBO();
            livro.Titulo = txtTitulo.Text;
            livro.Datapub = Convert.ToDateTime(txtDataPub.Text);
            livro.Autor.AutorID = Convert.ToInt16(txtAutorLivroId.Text);

            livroBo.Gravar(livro);
            SuccessMessage("Livro Cadastrado com sucesso!");

            boxLivro.Enabled = false;
            txtTitulo.Clear();
            txtDataPub.Clear();
            txtAutorLivroId.Clear();
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                Autor autor = new Autor();
                AutorBO autorBO = new AutorBO();
                autor.AutorID = Convert.ToInt16(txtAutorId.Text);
                autor.Nome = txtNome.Text;
                autor.Nacionalidade = txtNacionalidade.Text;

                autorBO.Editar(autor);
                SuccessMessage("Autor Editado com sucesso!");

                ResetBoxAutor(false);
            } catch (Exception)
            {
                ErrorMessage("Autor não encontrado.");
            }
        }

        private void ResetBoxAutor(bool isEnabled)
        {
            boxAutor.Enabled = isEnabled;
            txtAutorId.Clear();
            txtNome.Clear();
            txtNacionalidade.Clear();
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            btnBuscaAutor.Visible = true;
            txtAutorId.Enabled = true;
            boxAutor.Enabled = true;
            btnEditarAutor.Enabled = true;
            btnNovoAutor.Enabled = false;
            btnGravarAutor.Enabled = false;
        }

        private void btnBuscaAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            try
            {
                autor.AutorID = Convert.ToInt16(txtAutorId.Text);
                autorBO.Buscar(autor);

                if (autor.Nome == "")
                {
                    ErrorMessage("Autor não encontrado.");
                    ResetBoxAutor(true);
                } else
                {
                    txtNome.Text = autor.Nome;
                    txtNacionalidade.Text = autor.Nacionalidade;
                }
            } catch
            {
                WarningMessage("Preencha os campos corretamente.");
            }
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WarningMessage(string message)
        {
            MessageBox.Show(message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SuccessMessage(string message)
        {
            MessageBox.Show(message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
