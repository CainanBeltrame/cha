using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Chaves_Medicina.Camadas.DAL
{
    public class Dal_Movimento
    {
        private string strCon = Conexao.getConexao();

        public void InsertMovimento(MODEL.Model_Movimento movimento)
        {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "insert into Movimento values ";
            sql = sql + "(@DATA,@TIPO,@USUARIO,@ALUNO,@CHAVE);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@DATA",movimento.data);
            cmd.Parameters.AddWithValue("@TIPO",movimento.tipo);
            cmd.Parameters.AddWithValue("@USUARIO",movimento.fk_Usuario);
            cmd.Parameters.AddWithValue("@ALUNO", movimento.fk_Aluno);
            cmd.Parameters.AddWithValue("@CHAVE",movimento.fk_Chave);

            conexao.Open();



            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("ERRO AO ADICIONAR MOVIMENTO");
            }
            finally
            {
                conexao.Close();
            }


        }

        

    }
}
