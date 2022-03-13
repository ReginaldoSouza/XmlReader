using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XmlReader.Classes;

namespace XmlReader
{
    public partial class frmInicial : Form
    {
        public List<XML> xml = new List<XML>();
        public frmInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog caminho = new OpenFileDialog
            {
                Filter = "XML Valida (*.xml)|*.xml;*.xml",
                Title = "XML Valida"
            };
            _ = caminho.ShowDialog();
            txtxml.Text = caminho.FileName;
        }
                
        private void button3_Click(object sender, EventArgs e)
        {
           // XML xml = new XML(txtxml.Text);
         
        }

       
    }
}
