using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace ProjetoI4.Models
{
    public class PacotesBD
    {
        private const string DadosConexao = "Database=expresso;Data Source=localhost;User Id=root;";

       
        public static void Inserir_FretamentoeTurismo (FretamentoeTurismo t){
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            
            conexao.Open();
            string query = "INSERT INTO FretamentoeTurismo (Nome,Email,Celular,Telefone,CidadeOrigem,CidadeDestino,DataIda,DataVolta,Descricao) VALUES (@Nome, @Email,@Celular, @Telefone,@CidadeOrigem,@CidadeDestino,@DataIda,@DataVolta,@Descricao );";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Nome", t.Nome);
            comando.Parameters.AddWithValue("@Email", t.Email);
            comando.Parameters.AddWithValue("@Celular", t.Celular);
            comando.Parameters.AddWithValue("@Telefone", t.Telefone);
            comando.Parameters.AddWithValue("@CidadeOrigem", t.CidadeOrigem);
            comando.Parameters.AddWithValue("@CidadeDestino", t.CidadeDestino);
            comando.Parameters.AddWithValue("@DataIda", t.DataIda);
            comando.Parameters.AddWithValue("@DataVolta", t.DataVolta);
            comando.Parameters.AddWithValue("@Descricao", t.Descricao);
            comando.ExecuteNonQuery();
            conexao.Close();
       }


        public static void Inserir_FaleConosco (FaleConosco f){
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            
            conexao.Open();
            string query = "INSERT INTO FaleConosco (Nome,Email,Telefone,Mensagem ) VALUES (@Nome, @Email, @Telefone,@mensagem);";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Nome", f.Nome);
            comando.Parameters.AddWithValue("@Email", f.Email);
            comando.Parameters.AddWithValue("@Telefone", f.Telefone);
            comando.Parameters.AddWithValue("@Mensagem", f.Mensagem);
            comando.ExecuteNonQuery();
            conexao.Close();
       }
       
       
       
        public static List<Pacotes> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Pacotes;";
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Pacotes> Lista = new List<Pacotes>();

            while (Reader.Read())
            {
                Pacotes pacotep = new Pacotes();
                pacotep.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    pacotep.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                    pacotep.Origem = Reader.GetString("Origem");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    pacotep.Destino = Reader.GetString("Destino");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Saida")))
                    pacotep.Saida = Reader.GetString("Saida");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Valor")))
                    pacotep.Valor = Reader.GetDouble("Valor");
                
                Lista.Add(pacotep);    
            }
            Conexao.Close();
            return Lista;
            }
        public static void Inserir (Pacotes Pacote){
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            
            conexao.Open();
            string query = "INSERT INTO Pacotes (Nome, Origem, Destino,Saida, Valor) VALUES (@Nome, @Origem, @Destino,@Saida, @Valor);";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Nome", Pacote.Nome);
            comando.Parameters.AddWithValue("@Origem", Pacote.Origem);
            comando.Parameters.AddWithValue("@Destino", Pacote.Destino);
            comando.Parameters.AddWithValue("@Saida", Pacote.Saida);
            comando.Parameters.AddWithValue("@Valor", Pacote.Valor);
            comando.ExecuteNonQuery();
            conexao.Close();
       }
       public static void Atualizar(Pacotes Pacote){
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            
            conexao.Open();
            string query = "UPDATE Pacotes SET   Nome=@Nome, Origem=@Origem, Destino=@Destino, Saida=@Saida,  Valor=@Valor WHERE Id=@Id";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Nome", Pacote.Nome);
            comando.Parameters.AddWithValue("@Origem", Pacote.Origem);
            comando.Parameters.AddWithValue("@Destino", Pacote.Destino);
            comando.Parameters.AddWithValue("@Saida", Pacote.Saida);
            comando.Parameters.AddWithValue("@Valor", Pacote.Valor);
            comando.Parameters.AddWithValue("@Id", Pacote.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
       }
       public static void Remover (int Id){
         MySqlConnection conexao = new MySqlConnection(DadosConexao);
            
            conexao.Open();
            string query = "DELETE FROM  Pacotes WHERE id=@id;" ;
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Id", Id);
            comando.ExecuteNonQuery();
            conexao.Close();
    }
    public static Pacotes BuscarPorId(int Id){
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();
            string query = "    SELECT * FROM  Pacotes WHERE Id=@Id; ";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.Parameters.AddWithValue("@Id",Id);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            Pacotes pacotep = new Pacotes();
            
            if(leitor.Read()){
                
                pacotep.Id = leitor.GetInt32("Id");
                if(!leitor.IsDBNull(leitor.GetOrdinal("Nome")))
                pacotep.Nome = leitor.GetString("Nome");
                if(!leitor.IsDBNull(leitor.GetOrdinal("Origem")))
                pacotep.Origem = leitor.GetString("Origem");
                if(!leitor.IsDBNull(leitor.GetOrdinal("Destino")))
                pacotep.Destino = leitor.GetString("Destino");
                if(!leitor.IsDBNull(leitor.GetOrdinal("Saida")))
                pacotep.Saida = leitor.GetString("Saida");
                if(!leitor.IsDBNull(leitor.GetOrdinal("Valor")))
                pacotep.Valor = leitor.GetDouble("Valor");
                
            }
            conexao.Close();
            return pacotep;
        }

    }
}