using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace ProjetoI4.Models
{
    public class UsuarioBD
    {
         private const string DadosConexao = "Database=expresso;Data Source=localhost;User Id=root;";

        public static Usuario ValidarLogin(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Usuario WHERE Login=@Login AND Senha=@Senha" ;
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            Comando.Parameters.AddWithValue("@Login",usuario.Login);
            Comando.Parameters.AddWithValue("@Senha",usuario.Senha);
            MySqlDataReader Reader = Comando.ExecuteReader();


            Usuario UsuarioEncontrado = null;
           

            if(Reader.Read())
            {
                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Conta")))
                    UsuarioEncontrado.Conta = Reader.GetString("Conta");
            }else{
                 UsuarioEncontrado = null;
            }
            Conexao.Close();
            return UsuarioEncontrado;
        }
    }
}