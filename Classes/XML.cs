using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XmlReader.Dto;


namespace XmlReader.Classes
{
    public class XML : Abstrata
    {
        public string Element { get; set; } = "";
        public string Path { get; set; } = "";
        public string Value { get; set; } = "";
        public string EndElement { get; set; } = "";
        public string Arquivo { get; set; }
        public bool BuscaExata { get; set; } = false;
        public List<DTOXML> xml = new List<DTOXML>();

        public List<Erros> ErrosImportacao = new List<Erros>();

        public XML(string arquivo)
        {
            Arquivo = arquivo;

        }

        public XML()
        {
        }

        public override List<DTOXML> Pesquisar(string valor, List<DTOXML> lista)
        {

            valor = removerAcentos(valor);
            var lst = lista.Where(x => removerAcentos(x.Value.ToUpper().Trim()) == valor.ToUpper().Trim()).ToList();

            if (lst.Count == 0)
                lst = lista.Where(x => removerAcentos(x.Value.ToUpper().Trim()).Contains(valor.ToUpper().Trim())).ToList();

            if (lst.Count == 0)
                lst = lista.Where(x => removerAcentos(x.Path.ToUpper().Trim()).Contains(valor.ToUpper().Trim())).ToList();

            return lst;
        }

        public void ValidarXML()
        {

            foreach (var lista in xml)
            {
                var SemFechament = xml.Where(x => x.Element.ToString().Trim().ToUpper() == lista.EndElement.ToString().Trim().ToUpper()).ToList();

                if (SemFechament.Count == 0)
                {
                    ErrosImportacao.Add(new Erros
                    {
                        TipoErro = (int)TipoErros.TagFechamIncorr,
                        Instrucao = Mensagens((int)TipoErros.TagFechamIncorr),
                        Conteudo = lista.Element
                    });
                }

                var SemValor = xml.Where(x => (!string.IsNullOrEmpty(x.Path)) && string.IsNullOrEmpty(x.Value)).ToList();
                if (SemValor.Count > 0)
                {
                    ErrosImportacao.Add(new Erros
                    {
                        TipoErro = (int)TipoErros.TagVazia,
                        Instrucao = Mensagens((int)TipoErros.TagVazia),
                        Conteudo = lista.Element
                    });
                }

                var SemPath = xml.Where(x => string.IsNullOrEmpty(x.Path) && (!string.IsNullOrEmpty(x.Value))).ToList();
                if (SemPath.Count > 0)
                {
                    ErrosImportacao.Add(new Erros
                    {
                        TipoErro = (int)TipoErros.TagVazia,
                        Instrucao = Mensagens((int)TipoErros.TagVazia),
                        Conteudo = lista.Element
                    });
                }
            }
        }
        public override List<DTOXML> LerXML()
        {
            int pos = -1, indice = 0, indicePosElem = 0;
            string elemento = "", path = "";
            bool campodata = false;
            XmlTextReader reader = new XmlTextReader(Arquivo);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        elemento = reader.Name;

                        path += string.IsNullOrEmpty(path) ? reader.Name : "/" + reader.Name;
                        pos++;

                        xml.Add(new DTOXML()
                        {
                            Element = elemento.Trim()
                        });
 
                        break;

                    case XmlNodeType.Text:

                        xml[xml.FindLastIndex(x => x.Element == elemento)].Value = reader.Value;
                        xml[pos].Path = path.Trim();
                        break;

                    case XmlNodeType.EndElement:

                        indice = xml.FindLastIndex(x => x.Element == reader.Name);
                        if (indice >= 0)
                            xml[indice].EndElement = reader.Name.Trim();

                        indicePosElem = path.LastIndexOf(reader.Name);
                        if (indicePosElem > 0)
                            path = path.Substring(0, indicePosElem - 1);
                        break;
                }
            }

            return xml.Where(x => !string.IsNullOrEmpty(x.Path)).ToList();
        }

    }
}
