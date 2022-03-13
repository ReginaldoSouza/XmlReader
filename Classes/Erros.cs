using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlReader.Dto;


namespace XmlReader.Classes
{
    public class Erros
    {
        public int TipoErro { get; set; } = 0;
        public string Instrucao { get; set; } = "";
        public string Conteudo { get; set; } = "";
    }
}
