﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// referencias mysql
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace MVC.DAO
{
    class ConexaoBanco
    {


        public static MySqlConnection Conectar()
        {
            string database = "projeto_mvc";
            string uid = "root";
            string password = "";

            string stringConexao = $"SERVER=127.0.0.1;DATABASE={database};UID={uid};PASSWORD={password}";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;
        }

        public static void CRUD(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static MySqlDataReader Selecionar(MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
