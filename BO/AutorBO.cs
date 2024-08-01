using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.Model;
using MVC.DAO;

namespace MVC.BO
{
    class AutorBO
    {
        public void Gravar(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();

            if ((autor.Nome != "") && (autor.Nacionalidade != ""))
            {
                autorDAO.Insert(autor);
            }
        }

        public void Editar(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();

            if ((autor.Nome != "") && (autor.Nacionalidade != ""))
            {
                autorDAO.Update(autor);
            }
        }

        public void Buscar(Autor autor)
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

        public void Deletar(Autor autor)
        {
            AutorDAO autorDAO = new AutorDAO();

            if (autor.AutorID > 0)
            {
                autorDAO.Delete(autor);
            }
        }
    }
}
