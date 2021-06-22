using EnviaEmails.Helpers;
using EnviaEmails.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EnviaEmails
{
    public partial class PrincipalForm : Form
    {
        public DataTable _dtContatos { get; set; }
        public string[] _campos;
        public List<string> _headers;
        public string _html;
        public List<string> lstEmail { get; set; }
        List<string[]> _lines;
        public List<DestinatarioModel> lstDestinatarios { get; set; }
        public PrincipalForm()
        {
            InitializeComponent();
            _dtContatos = new DataTable();
            _headers = new List<string>();
            _lines = new List<string[]>();
            lstDestinatarios = new List<DestinatarioModel>();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ofdContatos.ShowDialog() == DialogResult.OK)
            {
                string path = ofdContatos.FileName;
                tbCaminho.Text = path;
                _lines = new List<string[]>();
                using (StreamReader reader = new StreamReader(path))
                {
                    _dtContatos.Columns.Clear() ;
                    _dtContatos.Clear();
                    _headers.Clear();
                    _campos = null;
                    dgvContatos.DataSource = null;
                    try
                    {
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (rbVirgula.Checked)
                                _campos = line.Split(',');
                            else
                                _campos = line.Split(';');

                            if (i == 0)
                            {
                                foreach (string campo in _campos)
                                {
                                    _dtContatos.Columns.Add(campo.ToUpper().Trim());
                                    _headers.Add(campo.ToUpper().Trim());
                                }
                            }
                            else
                                _lines.Add(_campos);
                            i++;
                        }
                        CarregarDataTable();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Falha ao Carregar o arquivo, vetifique o formato do arquivo e tente novamente!",
                            "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void CarregarListaDestinatarios()
        {
            lstDestinatarios = new List<DestinatarioModel>();
            foreach(string[] destinatario in _lines)
            {
                var destinatarioModel = new DestinatarioModel();
                int i = 0;
                foreach(string header in _headers)
                {
                    if (header == "EMAIL" || header == "E-MAIL")
                    {
                        destinatarioModel.Email = destinatario[i];
                    }
                    if (header == "NOME")
                    {
                        destinatarioModel.Nome = destinatario[i];
                    }
                    i++;
                }
                destinatarioModel.DadosDestinatario = destinatario;
                lstDestinatarios.Add(destinatarioModel);
            }
        }

        private void CarregarDataTable()
        {
            var j = 0;
            foreach (string[] contato in _lines)
            {
                var row = _dtContatos.NewRow();
                var i = 0;
                foreach (string header in _headers)
                {
                    row[header] = contato[i];
                    i++;
                }
                _dtContatos.Rows.Add(row);
                j++;
                if (j >= 4)
                    break;
            }
            dgvContatos.DataSource = _dtContatos;
        }

        private void btnSalvarRemetente_Click(object sender, EventArgs e)
        {
            RemetenteModel remetente = new RemetenteModel();
            try
            {
                ValidaCampo.Validar(tbRemetente, "Remetente");
                ValidaCampo.Validar(tbEmail, "EMail");
                ValidaCampo.Validar(tbLogin, "Login");
                ValidaCampo.Validar(tbSenha, "Senha");
                ValidaCampo.Validar(tbAssunto, "Assunto");
                ValidaCampo.Validar(tbSmtp, "SMTP");
                ValidaCampo.Validar(tbPorta, "Porta");
                remetente.Anexo = tbAnexo.Text;
                remetente.Email = tbEmail.Text;
                remetente.Assunto = tbAssunto.Text;
                remetente.Nome = tbRemetente.Text;
                remetente.Porta = Convert.ToInt32(tbPorta.Text);
                remetente.Login = tbLogin.Text;
                remetente.Senha = tbSenha.Text;
                remetente.Smtp = tbSmtp.Text;
                CarregarListaDestinatarios();
            }
            catch { }

            pictureBox1.Visible = true;
            Application.DoEvents();
            if (lstDestinatarios.Count > 0)
            {
                int numeroFalhas = 0;
                int enviados = 0;
                lblTotal.Text = lstDestinatarios.Count.ToString();
                lblEnviado.Text = "0";
                lblFalhado.Text = "0";
                lstDestinatarios.ForEach(x =>
                {
                    if (EmailHelper.EnviarEmail(VerificarVariaveis(_html, x.DadosDestinatario), x, remetente))
                    {
                        enviados++;
                        lblEnviado.Text = enviados.ToString();
                    }
                    else
                    {
                        numeroFalhas++;
                        lblFalhado.Text = numeroFalhas.ToString();
                    }
                    Application.DoEvents();
                });
            }
            pictureBox1.Visible = false; 
            Application.DoEvents();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var conteudo = richTextBox1.Text;
            _html = EmailHelper.FormatarEmail(conteudo);
            webBrowser1.DocumentText = _html;
        }

        private string VerificarVariaveis(string conteudo, string[] dados)
        {
            int i = 0;
            foreach (string header in _headers)
            {
                string oldValue = "{" + header + "}";
                conteudo = conteudo.Replace(oldValue, dados[i]);
                i++;
            }
            return conteudo;
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            if (ofdContatos.ShowDialog() == DialogResult.OK)
            {
                string path = ofdContatos.FileName;
                tbAnexo.Text = path;
            }
        }
    }
}
