using System;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;


namespace Chaves_Medicina
{
    public class Enviar_Email
    {
        /// <summary>
        /// Transmite uma mensagem de email sem anexos
        /// </summary>
        /// <param name="Destinatario">Destinatario (Recipient)</param>
        /// <param name="Remetente">Remetente (Sender)</param>
        /// <param name="Assunto">Assunto da mensagem (Subject)</param>
        /// <param name="enviaMensagem">Corpo da mensagem(Body)</param>
        /// <returns>Status da mensagem</returns>
        /// 

        public static string EnviaEmail(string email, string assunto, string enviaMensagem)
        {
            try
            {
                //valida email
                bool BvalidaEmail = validaEnderecoEmail(email);

                if (BvalidaEmail == false)
                {
                    return "Email invalido:" + email;

                }

                //cria uma mensagem
                MailMessage mensagemEmail = new MailMessage("programa_medicina_fema@hotmail.com", "cainan_programas@hotmail.com", assunto, enviaMensagem);

                SmtpClient client = new SmtpClient("smtp.live.com", 25);
                client.EnableSsl = true;
                NetworkCredential cred = new NetworkCredential("cainanbeltrame@hotmail.com", "C@inanBeltrame1994");

                client.Credentials = cred;

                //inclui credencial
                client.UseDefaultCredentials = true;

                //envia mensagem
                client.Send(mensagemEmail);

                return "Mensagem enviada para o responsavel... aguarde o retorno... Obreigado!";

            }
            catch (Exception ex)
            {
                string erro = ex.InnerException.ToString();
                return ex.Message.ToString() + erro;
            }
        }

        public static bool validaEnderecoEmail(string endereco_email)
        {
            try
            {
                //define a expressao regulada para validar o email
                string texto_validar = endereco_email;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                //testa email com expressao
                if (expressaoRegex.IsMatch(texto_validar))
                {
                    //email valido
                    return true;
                }
                else
                {
                    //email invalido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
