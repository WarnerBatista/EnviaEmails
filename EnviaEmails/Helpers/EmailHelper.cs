using EnviaEmails.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EnviaEmails.Helpers
{
    public class EmailHelper
    {
        public static bool EnviarEmail(string msg, DestinatarioModel destinatarioModel, RemetenteModel model)
        {
            var cliente = new SmtpClient(model.Smtp, model.Porta /* TLS */)
            {
                EnableSsl = false
            };
            var remetente = new MailAddress(model.Email, model.Nome);
            var destinatario = new MailAddress(destinatarioModel.Email, destinatarioModel.Nome);
            using (var mensagem = new MailMessage(remetente, destinatario))
            {
                if (!string.IsNullOrEmpty(model.Anexo))
                {
                    mensagem.Attachments.Add(new Attachment(model.Anexo));
                }
                if (!string.IsNullOrEmpty(model.ReplicarTo))
                {
                    mensagem.ReplyToList.Add(model.ReplicarTo);
                }
                mensagem.IsBodyHtml = true;
                mensagem.Body = msg;
                mensagem.Subject = model.Assunto;
                var credenciais = new NetworkCredential(
                    model.Login, /* login */
                    model.Senha, /* senha */
                    "");
                cliente.Credentials = credenciais;
                try
                {
                    cliente.Send(mensagem);
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cliente.Dispose();
                }
            }
            return false;
        }

        public static string GerarMd5(string valor)
        {
            var sb = new StringBuilder();
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(valor);
                byte[] hash = md5.ComputeHash(inputBytes);
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string FormatarEmail(string conteudo)
        {
            var html = $@"<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.0 Transitional//EN'>
            <html xmlns='http://www.w3.org/1999/xhtml'>
            <head id='Head1'>
                <title></title>
            </head>
            <body style='font-family: sans-serif;'>
                 {conteudo}
            </body>
            </html>";
            return html;
        }

    }
}
