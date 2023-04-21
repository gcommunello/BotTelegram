using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace BotTelegram
{
    public partial class FrmMensagemComTemporizador : Form
    {
        private List<string> lstMensagens;
        private int posicaoEnvio;

        public FrmMensagemComTemporizador()
        {
            InitializeComponent();

            lstMensagens = new List<string>();
            btnEnviarMensagens.Enabled = false;
        }

        private void PreparaEnvio()
        {
            posicaoEnvio = 0;
            inicializarProgressBar();
            inicializarTimerControle();
        }

        private void inicializarProgressBar()
        {
            pgbStatusEnvio.Value = 0;
            pgbStatusEnvio.Maximum = lstMensagens.Count;
        }

        private void inicializarTimerControle() 
        {
            var minutos = Convert.ToInt32(txtTempo.Text.Trim());

            timerControle.Interval = minutos * 60 * 1000;
            timerControle.Enabled = true;

            this.timerControle.Tick += new EventHandler(timerControle_Tick);
            this.BackColor = Color.Red;
        }

        private void pararTimerControle() 
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(timerControle_Tick);
            this.BackColor = SystemColors.Control;
            btnEnviarMensagens.Enabled = true;
        }

        private void AtualizarProgressoEnvio()
        {
            pgbStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}", posicaoEnvio,lstMensagens.Count);
        }

        private async void timerControle_Tick(object sender, EventArgs e)
        {
            try
            {
                var telegrambBot = new Telegram.Bot.TelegramBotClient("6092199078:AAGXV9_qDjTQjE7ZvlkxCe5A2SXgVzc3jj8");
                var mensagemAtual = lstMensagens[posicaoEnvio];

                await telegrambBot.SendTextMessageAsync(chatId: "-1001835935465", text: mensagemAtual, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);

                posicaoEnvio++;

                AtualizarProgressoEnvio();

                if (posicaoEnvio == lstMensagens.Count)
                    pararTimerControle();
            }
            catch (Exception ex)
            {
                pararTimerControle();
                MessageBox.Show("Erro ao enviar mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCarregarMensagens_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregarMensagens.Enabled = false;
                var arquivoMensagens = "Mensagens.txt";

                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                using (StreamReader sr = new StreamReader(arquivoMensagens))
                {
                    var strLinha = string.Empty;

                    while ((strLinha = sr.ReadLine()) != null)
                    {
                        if (!strLinha.Trim().Equals(string.Empty))
                        {
                            lstMensagens.Add(strLinha.Trim());
                            lbMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }
                if (lstMensagens.Count > 0)
                    btnEnviarMensagens.Enabled = true;
            }
            catch (Exception ex)
            {
                btnCarregarMensagens.Enabled = true;
                btnEnviarMensagens.Enabled = false;
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                MessageBox.Show("Erro ao carregar arquivo" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviarMensagens_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Você deve informar o tempo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnEnviarMensagens.Enabled = false;

            if (lstMensagens.Count == 0)
                MessageBox.Show("Nenhuma mensagem carregada do arquivo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                PreparaEnvio();
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
