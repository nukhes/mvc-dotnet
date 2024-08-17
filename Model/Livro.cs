using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Livro
    {
        private int livroId;
        private string titulo;
        private DateTime datapub;
        private Autor autor;

        public int LivroId { get => livroId; set => livroId = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime Datapub { get => datapub; set => datapub = value; }
        public Autor Autor { get => autor; set => autor = value; }

        public Livro()
        {
            Autor = new Autor();
        }
    }
}
