using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XmlReader.Classes
{
    public enum TipoErros
    {
        Extensao  = 0,
        TagPathSemValor = 1,
        TagVazia = 2,
        TagFechamIncorr = 3,
        ArquivoNaoSelecionado = 4,
        ArqNaoSelec = 5,
        ArquivoInvalido = 6
    }

} 