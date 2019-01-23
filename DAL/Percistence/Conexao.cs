﻿using System;
using MySql.Data.MySqlClient;
namespace DAL.Percistence
{
    public class Conexao
    {
        protected MySqlConnection connection;
        protected MySqlCommand command;
        protected MySqlDataReader dataReader;
        protected string connectionString;



        protected void AbrirConexao(){
            try{
                string serverName = "localhost";
                string userName = "root";
                string dbName = "clinicasistema";
                string port = "3306";
                string password = "12345678";

                connectionString = "server=" + serverName
                                 + ";user=" + userName
                                 + ";database=" + dbName
                                 + ";port=" + port
                                 + ";password" + password
                                 + ";";//abrir a conexáo com o banco de dados criando a connectionString

                connection = new MySqlConnection(connectionString);
                connection.Open();

            }catch(Exception erro){
                throw new Exception(erro.Message);
            }
        }

        public Conexao()
        {
        }
    }
}
