using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// referencias mysql
using MySql.Data.MySqlClient;
using System.Data;
using MVC.Model;


namespace MVC.DAO
{
    class AutorDAO : DAO
    {
        
        public void Insert(Autor autor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Autor(nome,nacionalidade) values(@nome, @nacionalidade)";

                comando.Parameters.AddWithValue("@nome", autor.Nome);
                comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);

                ConexaoBanco.CRUD(comando);
            }  catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public static Autor BuscarPorId(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Autor WHERE AutorID=@id";
            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Autor autor = new Autor();

            if (dr.HasRows)
            {
                dr.Read();

                autor.AutorID = (int)dr["AutorID"];
                autor.Nacionalidade = (string)dr["Nacionalidade"];
                autor.Nome = (string)dr["Nome"];
            }
            else
            {
                autor.AutorID = 0;
                autor.Nacionalidade = "";
                autor.Nome = "";
            }
            return autor;
        }

        public void Update(Autor autor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Autor SET Nome=@nome, Nacionalidade=@nacionalidade WHERE AutorID=@autorId";

                comando.Parameters.AddWithValue("@nome", autor.Nome);
                comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);
                comando.Parameters.AddWithValue("@autorId", autor.AutorID);

                ConexaoBanco.CRUD(comando);
            } catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public void Delete(Autor autor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "DELETE FROM Autor WHERE AutorID=@autorId";

                comando.Parameters.AddWithValue("@autorId", autor.AutorID);

                ConexaoBanco.CRUD(comando);
            } catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }

        public IList<Autor> BuscaPorAutor(string nome)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Autor WHERE nome like @nome";

                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");
                MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

                // lista de "autor"
                IList<Autor> autores = new List<Autor>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Autor autor = new Autor();
                        autor.Nome = (string)dr["nome"];
                        autor.AutorID = (int)dr["AutorID"];
                        autor.Nacionalidade = (string)dr["nacionalidade"];

                        autores.Add(autor);
                    }
                }
                else { autores = null; }

                return autores;
            }
            catch (Exception ex) { throw new Exception(ErrorMessage + ex.Message); }
        }
    }
}