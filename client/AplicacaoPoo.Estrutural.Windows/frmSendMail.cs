using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));
                mensagem.To.Add(new MailboxAddress("Rychard", "rocharychard31@gmail.com"));
                mensagem.ReplyTo.Add(new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));
                mensagem.Subject = txtAssunto.Text;

                mensagem.Body = new TextPart("plain")
                {
                    Text = txtMensagem.Text
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("user_senai_temp@faceli.edu.br", "senai@2022");

                    client.Send(mensagem);
                    client.Disconnect(true);
                    
                }
                button1.Enabled = true;
                MessageBox.Show("Mensagem enviada com sucesso!");
            }
            
            catch (Exception ex)
            {
                // A variável ex é responsável por armazenar
                // qualquer erro que ocorra ao tentar enviar o email.
                MessageBox.Show(ex.Message);
                throw;
            }
           

        }
    }
}