using MVC.DAO;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BO
{
    class LivroBO
    {
        public void Gravar(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

            if (livro.Autor != null)
            {
                if (livro.LivroId != 0)
                {
                    livroDAO.Update(livro);
                } else
                {
                    livroDAO.Insert(livro);
                }
            }
        }

        public void Editar(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

                livroDAO.Update(livro);
        }

        public void Deletar(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

            if (livro.LivroId > 0)
            {
                livroDAO.Delete(livro);
            }
        }

        public void Buscar(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

            if (livro.LivroId > 0)
            {
                // usar o var elimina a necessidade de criar uma classe pra esse resultado
                var resultadoBusca = livroDAO.BuscarPorId(livro.LivroId);

                livro.Titulo = resultadoBusca.Titulo;
                livro.Autor = resultadoBusca.Autor;
                livro.Datapub = resultadoBusca.Datapub;
            }
        }
    }
}
