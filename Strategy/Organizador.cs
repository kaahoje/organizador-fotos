using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorDeFotos.Strategy
{
    internal class Organizador
    {
        private ArquivosDeOrigem Arquivos { get; set; }
        public string Destino { get; set; }
        public bool Substituir { get; set; }
        public bool ExcluirOriginal { get; set; }
        public int TipoOrganizacao { get; set; }
        public int NumeroArquivoAtual { get; set; }
        public Action Notificacao { get; set; }
        public string ArquivoAtual { get; set; }
        public decimal PorcentagemConcluida { get; set; }
        public Organizador(ArquivosDeOrigem arquivos, string destino)
        {
            Arquivos = arquivos;
            Destino = destino;
        }

        public void Organizar()
        {
            NumeroArquivoAtual = 0;
            foreach (var arquivo in Arquivos.ArquivoList)
            {
                NumeroArquivoAtual += 1;
                PorcentagemConcluida = (decimal)NumeroArquivoAtual / Arquivos.TotalDeArquivos * 100;
                ArquivoAtual = arquivo.Key;
                Notificacao?.Invoke();
                var arquivoDestino = PathArquivoDestino(arquivo);
                if (File.Exists(arquivoDestino))
                    if (!Substituir)
                        continue;

                File.Copy(arquivo.Key, arquivoDestino, true);
                if (ExcluirOriginal)
                    File.Delete(arquivo.Key);
            }

        }

        private string PathArquivoDestino(KeyValuePair<string, FileInfo> arquivo)
        {
            var nomeArquivo = Path.GetFileName(arquivo.Key);
            var dirDestino = CriarDiretorioDestino(arquivo.Value);
            if (!Directory.Exists(dirDestino))
                Directory.CreateDirectory(dirDestino);

            return $"{dirDestino}{nomeArquivo}";
        }

        public string CriarDiretorioDestino(FileInfo fileInfo)
        {
            switch (TipoOrganizacao)
            {
                case 1: // Organiza por mês
                    return $"{Destino}" +
                        $"\\{fileInfo.LastWriteTime.Year}" +
                        $"\\{fileInfo.LastWriteTime:MMM}\\";
                case 2: // Organiza por ano
                    return $"{Destino}" +
                        $"\\{fileInfo.LastWriteTime.Year}\\";
                default: // Organiza por dia
                    return $"{Destino}" +
                        $"\\{fileInfo.LastWriteTime.Year}" +
                        $"\\{fileInfo.LastWriteTime:MMM}" +
                        $"\\Dia {fileInfo.LastWriteTime.Day}\\";

            }
        }
    }
}
