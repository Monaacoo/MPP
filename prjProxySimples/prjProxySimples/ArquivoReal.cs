using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProxySimples
{
    public class ArquivoReal : IArquivo{

    private string NomeDoArquivo;
    public ArquivoReal(string _nomedoarquivo)
    {
        this.NomeDoArquivo = _nomedoarquivo;
        loadArquivo();
    }

    private void loadArquivo()
    {
        Console.WriteLine("Carregando: " + this.NomeDoArquivo);
    }

    public void getArquivo() {
        Console.WriteLine(this.NomeDoArquivo);
    }
    }
}
