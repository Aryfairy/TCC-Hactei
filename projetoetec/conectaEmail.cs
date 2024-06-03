using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace projetoetec
{
    class conectaEmail
    {

        public static bool valid;
        public void EnviarEmail(string destinatario, string titulo, string mensagem)
        {
            // Verificar se o endereço de e-mail é válido

            if (IsValidEmail(destinatario))
            {

                // Enviar e-mail apenas se o endereço de e-mail for válido
                Email(destinatario, titulo, mensagem);
                valid = true;
            }
            else
            {
                // Mostrar mensagem de erro se o endereço de e-mail for inválido
                MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }


        }
        public string CodigoEmail()
        {
            // Gerar um código alfanumérico aleatório de 6 caracteres
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // Método para validar endereço de e-mail usando expressão regular
        public bool IsValidEmail(string email)
        {
            try
            {
                // Utilize uma expressão regular para validar o formato do endereço de e-mail
                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        public void Email(string destinatario, string titulo, string mensagem)
        {
            // Configurações do servidor SMTP
            string smtpHost = "smtp.gmail.com"; // Substitua pelo seu servidor SMTP
            int smtpPort = 587; // Substitua pela porta do seu servidor SMTP
            string smtpUsername = "vinepesil@gmail.com"; // Substitua pelo seu e-mail
            string smtpPassword = "eren gqkk njkx hvua"; // Substitua pela sua senha

            // Criando o e-mail de confirmação
            MailMessage mailMensagem = new MailMessage();
            mailMensagem.From = new MailAddress(smtpUsername);
            mailMensagem.To.Add(destinatario);
            mailMensagem.Subject = titulo;
            mailMensagem.Body = mensagem;

            // Configurando o cliente SMTP
            SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            smtpClient.EnableSsl = true; // Habilitar SSL se o servidor SMTP exigir

            try
            {
                smtpClient.Send(mailMensagem);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
