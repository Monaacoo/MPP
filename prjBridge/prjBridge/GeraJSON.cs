using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public class GeraJSON : IGeraArquivo
    {
        public void GravaArquivo(Funcionario funcionario)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();

            using(StreamWriter sw = new StreamWriter(@"funcionario.json"))
            using(JsonWriter writer = new JsonTextWriter(sw))
            {
                jsonSerializer.Serialize(writer, funcionario);
            }

            Console.WriteLine($"Salario para o Funcionario: {funcionario.Name} " + 
                $"gerado com sucesso em: funcionario.json\n");
        }
    }
}
