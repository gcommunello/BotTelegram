using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegram
{
    public partial class FRMPrincipal : Form
    {
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void envioDeMensagemComImagemDaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void envioDeMensagemComImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envioDeMensagemSimplesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FRMEnvioTexto1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemDaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FRMEnvioMensagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FRMEnvioImagemLocal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMensagemComEmojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMensagemComEmoji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMensagemComTemporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMensagemComTemporizador();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
