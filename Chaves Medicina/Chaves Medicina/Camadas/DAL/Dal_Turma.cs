using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Chaves_Medicina.Camadas.DAL
{
    public class Dal_Turma
    {
        private string strCon = Conexao.getConexao();

        public void Insert(MODEL.Model_Turma turma)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Turma values ";
            sql = sql + "(@DESC)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@DESC", turma.Descricao);
            conexao.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro ao inserir turma....");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Model_Turma> SelectbyDesc(string desc)
        {
            List<MODEL.Model_Turma> lst_Turma = new List<MODEL.Model_Turma>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Turma where Desc_Turma = @DESC";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@DESC", desc);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    MODEL.Model_Turma turma = new MODEL.Model_Turma();

                    turma.id = Convert.ToInt32(reader["ID_Turma"]);
                    turma.Descricao = Convert.ToInt32(reader["Desc_Turma"]);

                    lst_Turma.Add(turma);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao consultar turma pela Descrição");
            }
            finally
            {
                conexao.Close();
            }

            return lst_Turma;

        }

        public List<MODEL.Model_Turma> Select()
        {
            List<MODEL.Model_Turma> lst_Turma = new List<MODEL.Model_Turma>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Turma;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Model_Turma turma = new MODEL.Model_Turma();

                    turma.Descricao = Convert.ToInt32(reader["Desc_Turma"]);

                    lst_Turma.Add(turma);
                }
            }
            catch
            {
                Console.WriteLine("Erro ao consultar turma pela Descrição");
            }
            finally
            {
                conexao.Close();
            }

            return lst_Turma;
        }
    }
}
