using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace BotTelegram
{
    public partial class FRMEnvioMensagemWeb : Form
    {
        public FRMEnvioMensagemWeb()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da Mensagem para envio", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var telegrambBot = new Telegram.Bot.TelegramBotClient("6092199078:AAGXV9_qDjTQjE7ZvlkxCe5A2SXgVzc3jj8");
                WebRequest imagemRequest = WebRequest.Create(txtURL.Text.Trim());
                
                using (var imagemResponse = imagemRequest.GetResponse()) 
                { 
                    var stream = imagemResponse.GetResponseStream();
                    await telegrambBot.SendPhotoAsync(chatId: "-1001835935465", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
                    MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtURL.Text = string.Empty;
            }
        }
    }
}