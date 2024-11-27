using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MVC.Model;
using MVC.DAO;
using MVC.BO;

namespace MVC.DAO
{
    class LivroDAO : DAO
    {

        public void Insert(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Livro(Titulo, DtPublicacao, AutorID) values(@titulo, @dtPub, @autorID)";

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@dtPub", livro.Datapub);
                comando.Parameters.AddWithValue("autorID", livro.Autor.AutorID);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Update(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Livro SET Titulo=@titulo, DtPublicacao=@dtPub WHERE LivroID=@livroID";

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@dtPub", livro.Datapub);
                comando.Parameters.AddWithValue("livroID", livro.LivroId);


                //debug
                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
            
        }

        public void Delete(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Livro WHERE LivroID=@livroID";

                comando.Parameters.AddWithValue("livroID", livro.LivroId);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public Livro BuscarPorId(int id)
        {
            try
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
                }
                else
                {
                    livro = null;
                }
                return livro;
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
        public IList<Livro> BuscaPorLivro(string titulo)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Livro WHERE Titulo like @titulo";

                comando.Parameters.AddWithValue("@titulo", "%" + titulo + "%");
                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                // lista de "autor"
                IList<Livro> livros = new List<Livro>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Titulo, DtPublicacao, AutorID
                        Livro livro = new Livro();
                        livro.Titulo = (string)dr["Titulo"];
                        livro.LivroId = (int)dr["LivroID"];
                        livro.Autor.AutorID = (int)dr["AutorID"];

                        livros.Add(livro);
                    }
                }
                else { livros = null; }

                return livros;
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
    }
}
