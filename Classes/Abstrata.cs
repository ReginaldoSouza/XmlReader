using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlReader.Dto;


namespace XmlReader.Classes
{


    public class Abstrata
    {

        public TipoErros Erros { get; set; }

        public virtual List<DTOXML> Pesquisar(string valor, List<DTOXML> x)
        {
            return new List<DTOXML>();
        }

        public virtual List<DTOXML> LerXML()
        {
            return new List<DTOXML>();
        }

        public virtual string ValidarXML()
        {
            return "";
        }

        public string Mensagens(int erro)
        {
            string mensagem = "";

            if (erro == 4)
                mensagem = "Arquivo não foi selecionado. Por Favor verifique!";
            else if (erro == 3)
                mensagem = "Tag sem fechamento. Por favor verifique as linhas indicadas";
            else if (erro == 2)
                mensagem = "Tag sem valor. Por favor ajuste o arquivo.";
            else if (erro == 1)
                mensagem = "Tag Caminho. Por favor verifique.";
            else
                mensagem = "Arquivo inválido!";

            return mensagem;
        }

        public static string removerAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }

        public static string FormatarData(string texto)
        {

            string valororiginal = texto, retorno;
            texto = $"{texto.Substring(8, 2)}{"/"}{texto.Substring(5, 2)}{"/"}{texto.Substring(0, 4)}";

            DateTime DataF;

            var convertido = DateTime
                .TryParseExact(texto,
                                "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out DataF);
    
            return  convertido ?  DataF.ToString("dd/MM/yyyy") :  valororiginal;

        }

    }
}
