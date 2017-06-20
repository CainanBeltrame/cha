using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Chaves_Medicina.Camadas.DAL
{
    public class Dal_Aluno
    {
        private string strCon = Conexao.getConexao();

        public void Insert(MODEL.Model_Alunos aluno)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "insert into Alunos values";
            sql = sql + "(@RA, @NOME, @EMAIL, @TELEFONE, @FK_TURMA);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@RA",aluno.ra);
            cmd.Parameters.AddWithValue("@NOME",aluno.nome);
            cmd.Parameters.AddWithValue("@EMAIL",aluno.email);
            cmd.Parameters.AddWithValue("@TELEFONE",aluno.telefone);
            cmd.Parameters.AddWithValue("@FK_TURMA",aluno.fk_Turma);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO ao inserir aluno...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public List<MODEL.Model_Alunos> SelectbyRA(int ra)
        {
            List<MODEL.Model_Alunos> lst_Aluno = new List<MODEL.Model_Alunos>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "select * from Alunos where RA_Aluno = @RA;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@RA", ra);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    MODEL.Model_Alunos aluno = new MODEL.Model_Alunos();

                    aluno.id = Convert.ToInt32(reader["ID_Aluno"]);
                    aluno.ra = Convert.ToInt32(reader["RA_Aluno"]);
                    aluno.nome = Convert.ToString(reader["Nome_Aluno"]);
                    aluno.email = Convert.ToString(reader["Email_Aluno"]);
                    aluno.telefone = Convert.ToString(reader["Email_Aluno"]);
                    aluno.fk_Turma = Convert.ToInt32(reader["FK_Turma"]);
                    lst_Aluno.Add(aluno);

                }
            }
            catch
            {
                Console.WriteLine("ERRO ao consultar aluno pelo RA....");
            }
            finally
            {
                conexao.Close();
            }
            return lst_Aluno;
        }
    }
}
