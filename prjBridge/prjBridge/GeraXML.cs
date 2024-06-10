using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prjBridge
{
    public class GeraXML : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionario));
        private FileStream fileStream;

        public void GravaArquivo(Funcionario funcionario)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, funcionario);

            Console.WriteLine($"Salario para o funcionario : {funcionario.Name} " +
                $"gerado com sucesso em: {nomeArquivo}\n");
        }
    }
}
