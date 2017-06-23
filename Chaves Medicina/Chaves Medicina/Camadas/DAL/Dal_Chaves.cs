using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Chaves_Medicina.Camadas.DAL
{
    public class Dal_Chaves
    {
        private string strCon = Conexao.getConexao();

        public void Insert(MODEL.Model_Chaves chave)
        {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "insert into Chave values ";
            sql = sql + "(@desc, @situacao, @armario);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc", chave.desc);
            cmd.Parameters.AddWithValue("@situacao", chave.situacao);
            cmd.Parameters.AddWithValue("@armario", chave.armario);
            conexao.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção da chave ...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Model_Chaves> SelectByNumero(string number)
        {
            List<MODEL.Model_Chaves> lst_chave = new List<MODEL.Model_Chaves>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Chave where Desc_Chave = @desc";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc", number);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    MODEL.Model_Chaves chave = new MODEL.Model_Chaves();

                    chave.id = Convert.ToInt32(reader["ID_Chave"]);
                    chave.desc = Convert.ToString(reader["Desc_Chave"]);
                    chave.situacao = Convert.ToString(reader["Situacao_Chave"]);
                    chave.armario = Convert.ToInt32(reader["Numero_Armario"]);
                    lst_chave.Add(chave);

                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta pelo numero da chave...");
            }
            finally
            {
                conexao.Close();
            }

            return lst_chave;
        }

        public List<MODEL.Model_Chaves> SelectbyDispo()
        {
            List<MODEL.Model_Chaves> lst_chave = new List<MODEL.Model_Chaves>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Chave where Situacao_Chave = 'DISPONIVEL';";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Model_Chaves chave = new MODEL.Model_Chaves();

                    chave.id = Convert.ToInt32(reader["ID_Chave"]);
                    chave.desc = Convert.ToString(reader["Desc_Chave"]);
                    chave.situacao = Convert.ToString(reader["Situacao_Chave"]);
                    chave.armario = Convert.ToInt32(reader["Numero_Armario"]);
                    lst_chave.Add(chave);

                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta pelo numero da chave...");
            }
            finally
            {
                conexao.Close();
            }

            return lst_chave;
        }

        public List<MODEL.Model_Chaves> SelectbyAlugada()
        {
            List<MODEL.Model_Chaves> lst_chave = new List<MODEL.Model_Chaves>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Chave where Situacao_Chave = 'OCUPADA';";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Model_Chaves chave = new MODEL.Model_Chaves();

                    chave.id = Convert.ToInt32(reader["ID_Chave"]);
                    chave.desc = Convert.ToString(reader["Desc_Chave"]);
                    chave.situacao = Convert.ToString(reader["Situacao_Chave"]);
                    chave.armario = Convert.ToInt32(reader["Numero_Armario"]);
                    lst_chave.Add(chave);

                }
            }
            catch
            {
                Console.WriteLine("Falha na consulta pelo numero da chave...");
            }
            finally
            {
                conexao.Close();
            }

            return lst_chave;
        }

        public void MudaStats(int Number,int stats)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            
            if (stats == 1)
            {
                string sql = "update Chave set Situacao_Chave = 'OCUPADA' where Desc_Chave = @NUMBER;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@NUMBER", Number);
                conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("ERRO ao Alterar status da chave....");
                }
                finally
                {
                    conexao.Close();
                }
            }
            else
            {
                string sql = "update Chave set Situacao_Chave = 'DISPONIVEL' where Desc_Chave = @NUMBER;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@NUMBER", Number);
                conexao.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("ERRO ao Alterar status da chave....");
                }
                finally
                {
                    conexao.Close();
                }
            }

            


        }
    }
}
