
namespace EnviaEmails
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpConfiguracao = new System.Windows.Forms.TabPage();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.tbAnexo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPorta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAssunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRemetente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpContatos = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.rbPontoVirgula = new System.Windows.Forms.RadioButton();
            this.rbVirgula = new System.Windows.Forms.RadioButton();
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbpMensagem = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbpPreview = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tbpEnvio = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFalhado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEnviado = new System.Windows.Forms.Label();
            this.btnSalvarRemetente = new System.Windows.Forms.Button();
            this.ofdContatos = new System.Windows.Forms.OpenFileDialog();
            this.tbReplicarTo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tbpConfiguracao.SuspendLayout();
            this.tbpContatos.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.tbpMensagem.SuspendLayout();
            this.tbpPreview.SuspendLayout();
            this.tbpEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1024, 113);
            this.pnlTopo.TabIndex = 0;
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpConfiguracao);
            this.tbcPrincipal.Controls.Add(this.tbpContatos);
            this.tbcPrincipal.Controls.Add(this.tbpMensagem);
            this.tbcPrincipal.Controls.Add(this.tbpPreview);
            this.tbcPrincipal.Controls.Add(this.tbpEnvio);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 113);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tbcPrincipal.Multiline = true;
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.Padding = new System.Drawing.Point(12, 6);
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1024, 522);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tbpConfiguracao
            // 
            this.tbpConfiguracao.Controls.Add(this.tbReplicarTo);
            this.tbpConfiguracao.Controls.Add(this.label15);
            this.tbpConfiguracao.Controls.Add(this.btnAnexo);
            this.tbpConfiguracao.Controls.Add(this.tbAnexo);
            this.tbpConfiguracao.Controls.Add(this.label14);
            this.tbpConfiguracao.Controls.Add(this.tbLogin);
            this.tbpConfiguracao.Controls.Add(this.label13);
            this.tbpConfiguracao.Controls.Add(this.tbPorta);
            this.tbpConfiguracao.Controls.Add(this.label6);
            this.tbpConfiguracao.Controls.Add(this.tbSmtp);
            this.tbpConfiguracao.Controls.Add(this.label5);
            this.tbpConfiguracao.Controls.Add(this.tbAssunto);
            this.tbpConfiguracao.Controls.Add(this.label4);
            this.tbpConfiguracao.Controls.Add(this.tbSenha);
            this.tbpConfiguracao.Controls.Add(this.label3);
            this.tbpConfiguracao.Controls.Add(this.tbEmail);
            this.tbpConfiguracao.Controls.Add(this.label2);
            this.tbpConfiguracao.Controls.Add(this.tbRemetente);
            this.tbpConfiguracao.Controls.Add(this.label1);
            this.tbpConfiguracao.Location = new System.Drawing.Point(4, 35);
            this.tbpConfiguracao.Margin = new System.Windows.Forms.Padding(2);
            this.tbpConfiguracao.Name = "tbpConfiguracao";
            this.tbpConfiguracao.Padding = new System.Windows.Forms.Padding(2);
            this.tbpConfiguracao.Size = new System.Drawing.Size(1016, 483);
            this.tbpConfiguracao.TabIndex = 0;
            this.tbpConfiguracao.Text = "Configurações";
            this.tbpConfiguracao.UseVisualStyleBackColor = true;
            // 
            // btnAnexo
            // 
            this.btnAnexo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnexo.Location = new System.Drawing.Point(791, 247);
            this.btnAnexo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(85, 38);
            this.btnAnexo.TabIndex = 16;
            this.btnAnexo.Text = "Importar";
            this.btnAnexo.UseVisualStyleBackColor = false;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // tbAnexo
            // 
            this.tbAnexo.Enabled = false;
            this.tbAnexo.Location = new System.Drawing.Point(104, 253);
            this.tbAnexo.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnexo.Multiline = true;
            this.tbAnexo.Name = "tbAnexo";
            this.tbAnexo.Size = new System.Drawing.Size(683, 25);
            this.tbAnexo.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 230);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Anexo";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(105, 188);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(217, 25);
            this.tbLogin.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(101, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Login";
            // 
            // tbPorta
            // 
            this.tbPorta.Location = new System.Drawing.Point(805, 188);
            this.tbPorta.Margin = new System.Windows.Forms.Padding(2);
            this.tbPorta.Multiline = true;
            this.tbPorta.Name = "tbPorta";
            this.tbPorta.Size = new System.Drawing.Size(71, 25);
            this.tbPorta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Porta";
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(572, 188);
            this.tbSmtp.Margin = new System.Windows.Forms.Padding(2);
            this.tbSmtp.Multiline = true;
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(217, 25);
            this.tbSmtp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SMTP";
            // 
            // tbAssunto
            // 
            this.tbAssunto.Location = new System.Drawing.Point(571, 66);
            this.tbAssunto.Margin = new System.Windows.Forms.Padding(2);
            this.tbAssunto.Multiline = true;
            this.tbAssunto.Name = "tbAssunto";
            this.tbAssunto.Size = new System.Drawing.Size(304, 25);
            this.tbAssunto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assunto";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(341, 188);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbSenha.Multiline = true;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(217, 25);
            this.tbSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(340, 66);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(217, 25);
            this.tbEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // tbRemetente
            // 
            this.tbRemetente.Location = new System.Drawing.Point(105, 66);
            this.tbRemetente.Margin = new System.Windows.Forms.Padding(2);
            this.tbRemetente.Multiline = true;
            this.tbRemetente.Name = "tbRemetente";
            this.tbRemetente.Size = new System.Drawing.Size(217, 25);
            this.tbRemetente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Remetente";
            // 
            // tbpContatos
            // 
            this.tbpContatos.Controls.Add(this.label10);
            this.tbpContatos.Controls.Add(this.gbOpcao);
            this.tbpContatos.Controls.Add(this.dgvContatos);
            this.tbpContatos.Controls.Add(this.label8);
            this.tbpContatos.Controls.Add(this.btnBuscar);
            this.tbpContatos.Controls.Add(this.tbCaminho);
            this.tbpContatos.Controls.Add(this.label7);
            this.tbpContatos.Location = new System.Drawing.Point(4, 35);
            this.tbpContatos.Margin = new System.Windows.Forms.Padding(2);
            this.tbpContatos.Name = "tbpContatos";
            this.tbpContatos.Padding = new System.Windows.Forms.Padding(2);
            this.tbpContatos.Size = new System.Drawing.Size(1016, 483);
            this.tbpContatos.TabIndex = 1;
            this.tbpContatos.Text = "Importar Contatos";
            this.tbpContatos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(34, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(947, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Amostra dos Contatos Importados";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.rbPontoVirgula);
            this.gbOpcao.Controls.Add(this.rbVirgula);
            this.gbOpcao.Location = new System.Drawing.Point(34, 64);
            this.gbOpcao.Margin = new System.Windows.Forms.Padding(2);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Padding = new System.Windows.Forms.Padding(2);
            this.gbOpcao.Size = new System.Drawing.Size(278, 81);
            this.gbOpcao.TabIndex = 9;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Selecione o tipo do arquivo:";
            // 
            // rbPontoVirgula
            // 
            this.rbPontoVirgula.AutoSize = true;
            this.rbPontoVirgula.Location = new System.Drawing.Point(19, 52);
            this.rbPontoVirgula.Margin = new System.Windows.Forms.Padding(2);
            this.rbPontoVirgula.Name = "rbPontoVirgula";
            this.rbPontoVirgula.Size = new System.Drawing.Size(236, 24);
            this.rbPontoVirgula.TabIndex = 1;
            this.rbPontoVirgula.Text = "Separado por Ponto e Virgula";
            this.rbPontoVirgula.UseVisualStyleBackColor = true;
            // 
            // rbVirgula
            // 
            this.rbVirgula.AutoSize = true;
            this.rbVirgula.Checked = true;
            this.rbVirgula.Location = new System.Drawing.Point(19, 24);
            this.rbVirgula.Margin = new System.Windows.Forms.Padding(2);
            this.rbVirgula.Name = "rbVirgula";
            this.rbVirgula.Size = new System.Drawing.Size(177, 24);
            this.rbVirgula.TabIndex = 0;
            this.rbVirgula.TabStop = true;
            this.rbVirgula.Text = "Separado por Virgula";
            this.rbVirgula.UseVisualStyleBackColor = true;
            // 
            // dgvContatos
            // 
            this.dgvContatos.AllowUserToAddRows = false;
            this.dgvContatos.AllowUserToDeleteRows = false;
            this.dgvContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(34, 206);
            this.dgvContatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.RowHeadersVisible = false;
            this.dgvContatos.RowHeadersWidth = 51;
            this.dgvContatos.RowTemplate.Height = 24;
            this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatos.Size = new System.Drawing.Size(947, 259);
            this.dgvContatos.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(2, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1012, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Selecione um arquivo do tipo .CSV para importar a lista de contatos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(756, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 38);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Importar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(387, 106);
            this.tbCaminho.Margin = new System.Windows.Forms.Padding(2);
            this.tbCaminho.Multiline = true;
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(366, 25);
            this.tbCaminho.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Local do arquivo";
            // 
            // tbpMensagem
            // 
            this.tbpMensagem.Controls.Add(this.richTextBox1);
            this.tbpMensagem.Controls.Add(this.label9);
            this.tbpMensagem.Location = new System.Drawing.Point(4, 35);
            this.tbpMensagem.Margin = new System.Windows.Forms.Padding(2);
            this.tbpMensagem.Name = "tbpMensagem";
            this.tbpMensagem.Size = new System.Drawing.Size(1016, 483);
            this.tbpMensagem.TabIndex = 2;
            this.tbpMensagem.Text = "Inserir Mensagem";
            this.tbpMensagem.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1016, 459);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1016, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Podera ser usado texto simples ou HTML";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpPreview
            // 
            this.tbpPreview.Controls.Add(this.webBrowser1);
            this.tbpPreview.Location = new System.Drawing.Point(4, 35);
            this.tbpPreview.Margin = new System.Windows.Forms.Padding(2);
            this.tbpPreview.Name = "tbpPreview";
            this.tbpPreview.Size = new System.Drawing.Size(1016, 483);
            this.tbpPreview.TabIndex = 3;
            this.tbpPreview.Text = "Preview";
            this.tbpPreview.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1016, 483);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tbpEnvio
            // 
            this.tbpEnvio.Controls.Add(this.pictureBox1);
            this.tbpEnvio.Controls.Add(this.label11);
            this.tbpEnvio.Controls.Add(this.lblFalhado);
            this.tbpEnvio.Controls.Add(this.lblTotal);
            this.tbpEnvio.Controls.Add(this.label12);
            this.tbpEnvio.Controls.Add(this.lblEnviado);
            this.tbpEnvio.Controls.Add(this.btnSalvarRemetente);
            this.tbpEnvio.Location = new System.Drawing.Point(4, 35);
            this.tbpEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.tbpEnvio.Name = "tbpEnvio";
            this.tbpEnvio.Size = new System.Drawing.Size(1016, 483);
            this.tbpEnvio.TabIndex = 4;
            this.tbpEnvio.Text = "Enviar";
            this.tbpEnvio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::EnviaEmails.Properties.Resources.gif_sending;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(592, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 221);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(351, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "E-Mails com Falha no envio.";
            // 
            // lblFalhado
            // 
            this.lblFalhado.AutoSize = true;
            this.lblFalhado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalhado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFalhado.Location = new System.Drawing.Point(313, 67);
            this.lblFalhado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFalhado.Name = "lblFalhado";
            this.lblFalhado.Size = new System.Drawing.Size(20, 24);
            this.lblFalhado.TabIndex = 19;
            this.lblFalhado.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(531, 30);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 24);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(351, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "E-Mails enviados de: ";
            // 
            // lblEnviado
            // 
            this.lblEnviado.AutoSize = true;
            this.lblEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEnviado.Location = new System.Drawing.Point(313, 30);
            this.lblEnviado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnviado.Name = "lblEnviado";
            this.lblEnviado.Size = new System.Drawing.Size(20, 24);
            this.lblEnviado.TabIndex = 16;
            this.lblEnviado.Text = "0";
            // 
            // btnSalvarRemetente
            // 
            this.btnSalvarRemetente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvarRemetente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRemetente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarRemetente.Location = new System.Drawing.Point(316, 125);
            this.btnSalvarRemetente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarRemetente.Name = "btnSalvarRemetente";
            this.btnSalvarRemetente.Size = new System.Drawing.Size(216, 38);
            this.btnSalvarRemetente.TabIndex = 15;
            this.btnSalvarRemetente.Text = "Enviar";
            this.btnSalvarRemetente.UseVisualStyleBackColor = false;
            this.btnSalvarRemetente.Click += new System.EventHandler(this.btnSalvarRemetente_Click);
            // 
            // ofdContatos
            // 
            this.ofdContatos.DefaultExt = "csv";
            this.ofdContatos.InitialDirectory = "C:\\Users\\warne\\Documenos";
            // 
            // tbReplicarTo
            // 
            this.tbReplicarTo.Location = new System.Drawing.Point(104, 127);
            this.tbReplicarTo.Margin = new System.Windows.Forms.Padding(2);
            this.tbReplicarTo.Multiline = true;
            this.tbReplicarTo.Name = "tbReplicarTo";
            this.tbReplicarTo.Size = new System.Drawing.Size(218, 25);
            this.tbReplicarTo.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Replicar respostas para";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 635);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.pnlTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de envios de e-mails";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpConfiguracao.ResumeLayout(false);
            this.tbpConfiguracao.PerformLayout();
            this.tbpContatos.ResumeLayout(false);
            this.tbpContatos.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbOpcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.tbpMensagem.ResumeLayout(false);
            this.tbpPreview.ResumeLayout(false);
            this.tbpEnvio.ResumeLayout(false);
            this.tbpEnvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpConfiguracao;
        private System.Windows.Forms.TabPage tbpContatos;
        private System.Windows.Forms.TabPage tbpMensagem;
        private System.Windows.Forms.TabPage tbpPreview;
        private System.Windows.Forms.TabPage tbpEnvio;
        private System.Windows.Forms.TextBox tbPorta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAssunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRemetente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdContatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.RadioButton rbPontoVirgula;
        private System.Windows.Forms.RadioButton rbVirgula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalvarRemetente;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblEnviado;
        public System.Windows.Forms.Label lblFalhado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.TextBox tbAnexo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbReplicarTo;
        private System.Windows.Forms.Label label15;
    }
}

