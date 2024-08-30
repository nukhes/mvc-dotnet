using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Autor
    {
        private int autorID;
        private string nome;
        private string nacionalidade;

        public int AutorID { get => autorID; set => autorID = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
    }
}
