namespace BotTelegram
{
    partial class FrmMensagemComTemporizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensagens = new System.Windows.Forms.ListBox();
            this.btnCarregarMensagens = new System.Windows.Forms.Button();
            this.btnEnviarMensagens = new System.Windows.Forms.Button();
            this.pgbStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagens:";
            // 
            // lbMensagens
            // 
            this.lbMensagens.BackColor = System.Drawing.SystemColors.Info;
            this.lbMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagens.FormattingEnabled = true;
            this.lbMensagens.Location = new System.Drawing.Point(14, 38);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(565, 95);
            this.lbMensagens.TabIndex = 1;
            // 
            // btnCarregarMensagens
            // 
            this.btnCarregarMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarMensagens.Location = new System.Drawing.Point(423, 145);
            this.btnCarregarMensagens.Name = "btnCarregarMensagens";
            this.btnCarregarMensagens.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarMensagens.TabIndex = 2;
            this.btnCarregarMensagens.Text = "Carregar Mensagens";
            this.btnCarregarMensagens.UseVisualStyleBackColor = true;
            this.btnCarregarMensagens.Click += new System.EventHandler(this.btnCarregarMensagens_Click);
            // 
            // btnEnviarMensagens
            // 
            this.btnEnviarMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMensagens.Location = new System.Drawing.Point(503, 145);
            this.btnEnviarMensagens.Name = "btnEnviarMensagens";
            this.btnEnviarMensagens.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarMensagens.TabIndex = 3;
            this.btnEnviarMensagens.Text = "Enviar";
            this.btnEnviarMensagens.UseVisualStyleBackColor = true;
            this.btnEnviarMensagens.Click += new System.EventHandler(this.btnEnviarMensagens_Click);
            // 
            // pgbStatusEnvio
            // 
            this.pgbStatusEnvio.Location = new System.Drawing.Point(14, 181);
            this.pgbStatusEnvio.Name = "pgbStatusEnvio";
            this.pgbStatusEnvio.Size = new System.Drawing.Size(567, 23);
            this.pgbStatusEnvio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status de Envio";
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.Location = new System.Drawing.Point(19, 211);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(559, 16);
            this.lblStatusEnvio.TabIndex = 6;
            this.lblStatusEnvio.Text = "Aguardando Envio";
            this.lblStatusEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempo.Location = new System.Drawing.Point(503, 10);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(78, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo:";
            // 
            // FrmMensagemComTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgbStatusEnvio);
            this.Controls.Add(this.btnEnviarMensagens);
            this.Controls.Add(this.btnCarregarMensagens);
            this.Controls.Add(this.lbMensagens);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMensagemComTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envo de Mensagem Com Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMensagens;
        private System.Windows.Forms.Button btnCarregarMensagens;
        private System.Windows.Forms.Button btnEnviarMensagens;
        private System.Windows.Forms.ProgressBar pgbStatusEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatusEnvio;
        private System.Windows.Forms.Timer timerControle;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
    }
}