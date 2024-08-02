using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MVC.Model;
using MVC.DAO;

namespace MVC.DAO
{
    class LivroDAO
    {
        public void Insert(Livro livro)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Livro(Titulo, DtPublicacao, AutorID) values(@titulo, @dtPub, @autorID)";

            comando.Parameters.AddWithValue("@titulo", livro.Titulo);
            comando.Parameters.AddWithValue("@dtPub", livro.Datapub);
            comando.Parameters.AddWithValue("autorID", livro.Autor.AutorID);

            ConexaoBanco.CRUD(comando);
        }

        public void Update(Livro livro)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Livro SET Titulo=@titulo, DtPublicacao=@dtPub, AutorID=@autorID WHERE LivroID=@livroID";
            
            comando.Parameters.AddWithValue("@titulo", livro.Titulo);
            comando.Parameters.AddWithValue("@dtPub", livro.Datapub);
            comando.Parameters.AddWithValue("autorID", livro.Autor.AutorID);
            comando.Parameters.AddWithValue("livroID", livro.LivroId);


            //debug
            ConexaoBanco.CRUD(comando);
            
        }

        public void Delete(Livro livro)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Livro WHERE LivroID=@livroID";

            comando.Parameters.AddWithValue("livroID", livro.LivroId);

            ConexaoBanco.CRUD(comando);
        }

        public Livro BuscarPorId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Livro WHERE LivroID=@id";

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Livro livro = new Livro();
            AutorDAO autorDAO = new AutorDAO();

            if (dr.HasRows)
            {
                dr.Read();
                livro.Titulo = (string)dr["Titulo"];
                livro.LivroId = (int)dr["LivroID"];
                livro.Datapub = (DateTime)dr["DtPublicacao"];
                livro.Autor = AutorDAO.BuscarPorId((int)dr["AutorID"]);
            } else
            {
                livro = null;
            }
            return livro;
        }
    }
}
