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
                var resultadoBusca = AutorDAO.BuscarPorId(autor.AutorID);
            }
        }
    }
}
