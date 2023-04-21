using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace BotTelegram
{
    public partial class FrmMensagemComEmoji : Form
    {
        public FrmMensagemComEmoji()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a mensagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegrambBot = new Telegram.Bot.TelegramBotClient("6092199078:AAGXV9_qDjTQjE7ZvlkxCe5A2SXgVzc3jj8");
                var strMensagem = txtMensagem.Text.Trim();

                if (strMensagem.Contains(":rainbow_flag:"))
                    strMensagem = strMensagem.Replace(":rainbow_flag:", char.ConvertFromUtf32(0x1F308));

                await telegrambBot.SendTextMessageAsync(chatId: "-1001835935465", text: strMensagem, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }
        }
    }
}
