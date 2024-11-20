using MVC.DAO;
using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BO
{
    class LivroBO : BO
    {
        public void Gravar(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

            if (livro.Autor != null)
            {
                try
                {
                    livroDAO.Insert(livro);
                }
                catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
            }
        }

        public void Editar(Livro livro)
        {
            try
            {
                LivroDAO livroDAO = new LivroDAO();
                livroDAO.Update(livro);
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Deletar(Livro livro)
        {
            try
            {
                LivroDAO livroDAO = new LivroDAO();
                livroDAO.Delete(livro);
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Buscar(Livro livro)
        {
            try
            {
                LivroDAO livroDAO = new LivroDAO();

                // usar o var elimina a necessidade de criar uma classe pra esse resultado
                var resultadoBusca = livroDAO.BuscarPorId(livro.LivroId);

                livro.Titulo = resultadoBusca.Titulo;
                livro.Autor = resultadoBusca.Autor;
                livro.Datapub = resultadoBusca.Datapub;
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public IList<Livro> BuscarPorTitulo(Livro livro)
        {
            LivroDAO livroDAO = new LivroDAO();

            try
            {
                if (livro.Titulo != "")
                {
                    IList<Livro> livroTemp = livroDAO.BuscaPorLivro(livro.Titulo);
                    return livroTemp;
                }
                else { return null; }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
    }
}
