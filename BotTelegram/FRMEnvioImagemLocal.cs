using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace BotTelegram
{
    public partial class FRMEnvioImagemLocal : Form
    {
        public FRMEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var Stream = new MemoryStream();
            imagem.Save(Stream, formato);
            Stream.Position = 0;
            return Stream;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncaminho_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\Users\\eduar\\Downloads\\";
                ofd.Filter = "Imagens (*jpg; *jpeg; *png) | *jpg; *jpeg; *png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                    txtCaminhoImagem.Text = ofd.FileName;
            }
        }

        private async void btnenviar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar uma imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegrambBot = new Telegram.Bot.TelegramBotClient("6092199078:AAGXV9_qDjTQjE7ZvlkxCe5A2SXgVzc3jj8");

                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio,ImageFormat.Jpeg);
                    await telegrambBot.SendPhotoAsync(chatId: "-1001835935465", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
                    MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao enviar mensagem!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                txtMensagem.Text = string.Empty;
                txtCaminhoImagem.Text = string.Empty;
            }
        }
    }
}
