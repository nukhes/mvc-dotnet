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
    }
}
