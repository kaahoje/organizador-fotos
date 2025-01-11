using System.Collections.Generic;
using System.IO;

namespace OrganizadorDeFotos.Strategy
{
    internal class ArquivosDeOrigem
    {
        private string Path { get; set; }
        public Dictionary<string, FileInfo> ArquivoList { get; }
        public int TotalDeArquivos { get; private set; }
        public ArquivosDeOrigem(string path)
        {
            Path = path;
            ArquivoList = new Dictionary<string, FileInfo>();
        }
        public void Carregar()
        {
            CarregarDiretorio(Path);
            TotalDeArquivos = ArquivoList.Count;
        }

        private void CarregarDiretorio(string path)
        {
            var diretoriosDaPasta = Directory.GetDirectories(path);
            var arquivosDaPastaList = Directory.GetFiles(path);
            foreach (var pathArquivo in arquivosDaPastaList)
                ArquivoList.Add(pathArquivo, new FileInfo(pathArquivo));

            foreach (var pathDiretorio in diretoriosDaPasta)
                CarregarDiretorio(pathDiretorio);
        }
    }
}
