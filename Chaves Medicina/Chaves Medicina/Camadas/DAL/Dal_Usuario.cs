using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Chaves_Medicina.Camadas.DAL
{
    class Dal_Usuario
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Model_Usuario> login(string nick, string senha)
        {
            List<MODEL.Model_Usuario> lstLogin = new List<MODEL.Model_Usuario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Usuario where Nick_Usuario = @NICK and Pass_Usuario = @PASS;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@NICK", nick);
            cmd.Parameters.AddWithValue("@PASS", senha);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Model_Usuario usuario = new MODEL.Model_Usuario();

                    usuario.id = Convert.ToInt32(reader["ID_Usuario"]);
                    usuario.nome = Convert.ToString(reader["Nome_Usuario"]);
                    usuario.email = Convert.ToString(reader["Email_Usuario"]);
                    usuario.telefone = Convert.ToString(reader["Telefone_Usuario"]);
                    usuario.nick = Convert.ToString(reader["Nick_Usuario"]);
                    usuario.pass = Convert.ToString(reader["Pass_Usuario"]);
                    lstLogin.Add(usuario);
                }
            }
            catch
            {
                Console.WriteLine("Erro - sql select usuario.....");
            }
            finally
            {
                conexao.Close();
            }
            return lstLogin;
        }

        public List<MODEL.Model_Usuario> NomeByID(int id)
        {
            List<MODEL.Model_Usuario> lstNome = new List<MODEL.Model_Usuario>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Usuario where ID_Usuario = @ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", id);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while(reader.Read())
                {
                    MODEL.Model_Usuario Usuario = new MODEL.Model_Usuario();

                    Usuario.nome = Convert.ToString(reader["Nome_Usuario"]);
                    Usuario.nick = Convert.ToString(reader["Nick_Usuario"]);

                    lstNome.Add(Usuario);
                }
            }
            catch
            {
                Console.WriteLine("ERRO - SQL - CONSULTA...");
            }
            finally
            {
                conexao.Close();
            }
            return lstNome;
        }
    }
}
