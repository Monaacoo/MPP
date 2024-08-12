using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStrategy
{
    public class CompressaoGZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado" +
                $"\nUm arquivo com extensão .GZip foi criado");
        }
    }
}
