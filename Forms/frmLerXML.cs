using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlReader.Dto;
using System.Xml;
using XmlReader.Classes;

namespace XmlReader.Forms
{
    public partial class frmLerXML : Form
    {
        public List<DTOXML> lstxml;
        public frmLerXML()
        {
            InitializeComponent();
            ConfigurarForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog caminho = new OpenFileDialog
            {
                Filter = "XML Valida (*.xml)|*.xml;*.xml",
                Title = "XML Valida"
            };
            _ = caminho.ShowDialog();
            txtxml.Text = caminho.FileName;
            SetarTxtXML();
        }

        void DrawGrid()
        {
            tabControlXML.SelectedTab = tabPageXML;
            dataGridViewXML.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSlateGray;
            dataGridViewXML.Columns[1].Name = "Caminho";
            dataGridViewXML.Columns[3].Name = "Valor";
            dataGridViewXML.Columns[1].HeaderText = "Valor";
            dataGridViewXML.Columns[3].HeaderText = "Caminho";
            dataGridViewXML.Columns[0].Visible = false;
            dataGridViewXML.Columns[2].Visible = false;
            dataGridViewXML.Columns[1].Width = 200;
            dataGridViewXML.Columns[3].Width = 800;
            dataGridViewXML.Columns["Caminho"].DisplayIndex = 1;
            dataGridViewXML.Columns["Valor"].DisplayIndex = 0;
        }

        void DrawGridErros()
        {
            tabControlXML.SelectedTab = TabPageErros;
            dataGridViewErros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSlateGray;
            dataGridViewErros.Columns[0].Name = "Tipo de Erro";
            dataGridViewErros.Columns[1].Name = "Instrução";
            dataGridViewErros.Columns[2].Name = "Conteúdo";



            dataGridViewErros.Columns[0].Width = 400;
            dataGridViewErros.Columns[1].Width = 400;
            dataGridViewErros.Columns[2].Width = 400;




        }

        void ConfigurarForm()
        {
            txtxml.BorderStyle = BorderStyle.None;

            txtxml.Enabled = false;

            SetarTxtXML();

        }

        void SetarTxtXML()
        {
            if (string.IsNullOrEmpty(txtxml.Text))
                txtxml.Text = "Nenhum Arquivo escolhido";

        }

        private void BtnEscolherArquivo_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageXML_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    PesquisarXML();

        //}

        void PesquisarXML()
        {
            List<DTOXML> lstxmlPesquisar;
            XML xml = new XML();
            lstxmlPesquisar = xml.Pesquisar(txtpesquisar.Text.Trim(), lstxml);
            dataGridViewXML.DataSource = null;

            dataGridViewXML.DataSource = lstxmlPesquisar;
            DrawGrid();
        }

        private void txtpesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarXML();
        }

        private void BtnEscolherArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog caminho = new OpenFileDialog
            {
                Filter = "XML Valida (*.xml)|*.xml;*.xml",
                Title = "XML Valida"
            };
            _ = caminho.ShowDialog();
            txtxml.Text = caminho.FileName;
            lblTotalRegistros.Visible = false;
            lblTotalRegistros.Text = "";
            SetarTxtXML();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DTOXML listaxml = new DTOXML();
            XML xml = new XML(txtxml.Text);

            dataGridViewErros.DataSource = null;
            dataGridViewXML.DataSource = null;
            txtpesquisar.Enabled = false;

            if (txtxml.Text.Contains("Nenhum Arquivo escolhido"))
            {
                xml.ErrosImportacao.Add(new Erros
                {
                    TipoErro = (int)TipoErros.ArquivoNaoSelecionado,
                    Instrucao = xml.Mensagens((int)TipoErros.ArquivoNaoSelecionado),
                    Conteudo = ""
                });
            }

            try
            {
                lstxml = xml.LerXML();
            }
            catch
            {
                if (xml.ErrosImportacao.Count == 0)
                    xml.ErrosImportacao.Add(new Erros
                    {
                        TipoErro = (int)TipoErros.ArquivoInvalido,
                        Instrucao = xml.Mensagens((int)TipoErros.ArquivoInvalido),
                        Conteudo = ""
                    });
            }

            xml.ValidarXML();

            if (xml.ErrosImportacao.Count > 0)
            {
                dataGridViewErros.DataSource = xml.ErrosImportacao;
                DrawGridErros();
                return;

            }

            dataGridViewXML.DataSource = lstxml;
            DrawGrid();
            txtpesquisar.Enabled = true;
            lblTotalRegistros.Visible = true;
            lblTotalRegistros.Text = "Total de Registros : "+ lstxml.Count().ToString();

        }

        private void txtpesquisar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtpesquisar_TextChanged_2(object sender, EventArgs e)
        {
          
            PesquisarXML();
        }

        private void txtpesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
