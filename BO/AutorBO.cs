using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.Model;
using MVC.DAO;

namespace MVC.BO
{
    class AutorBO : BO
    {
        public void Gravar(Autor autor)
        {
            try
            {
                if ((autor.Nome != "") && (autor.Nacionalidade != ""))
                {
                    AutorDAO autorDAO = new AutorDAO();
                    autorDAO.Insert(autor);
                }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
    

        public void Editar(Autor autor)
        {
            try
            {
                AutorDAO autorDAO = new AutorDAO();

                if ((autor.Nome != "") && (autor.Nacionalidade != ""))
                {
                    autorDAO.Update(autor);
                }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Buscar(Autor autor)
        {
            try
            {
                AutorDAO autorDAO = new AutorDAO();

                if (autor.AutorID >= 0)
                {
                    // usar o var elimina a necessidade de criar uma classe pra esse resultado
                    var resultadoBusca = AutorDAO.BuscarPorId(autor.AutorID);

                    autor.Nome = resultadoBusca.Nome;
                    autor.Nacionalidade = resultadoBusca.Nacionalidade;
                }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Deletar(Autor autor)
        {
            try
            {
                AutorDAO autorDAO = new AutorDAO();

                if (autor.AutorID > 0)
                {
                    autorDAO.Delete(autor);
                }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public IList<Autor> BuscarPorNome(Autor autor)
        {
            try
            {
                AutorDAO autorDAO = new AutorDAO();

                if (autor.Nome != "")
                {
                    IList<Autor> autorTemp = autorDAO.BuscaPorAutor(autor.Nome);
                    return autorTemp;
                }
                else { return null; }
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
    }
}
