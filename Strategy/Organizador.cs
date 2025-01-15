using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace OrganizadorDeFotos.Strategy
{
    internal class Organizador
    {
        private ArquivosDeOrigem Arquivos { get; set; }
        public string Destino { get; set; }
        public string Origem { get; set; }
        public bool Substituir { get; set; }
        public bool ExcluirOriginal { get; set; }
        public int TipoOrganizacao { get; set; }
        public int NumeroArquivoAtual { get; set; }
        public bool SepararMidia { get; set; }
        public Action Notificacao { get; set; }
        public string ArquivoAtual { get; set; }
        public decimal PorcentagemConcluida { get; set; }
        public Organizador(ArquivosDeOrigem arquivos, string origem, string destino)
        {
            Arquivos = arquivos;
            Destino = destino;
            Origem = origem;
        }

        public void Organizar()
        {
            NumeroArquivoAtual = 0;
            foreach (var arquivo in Arquivos.ArquivoList)
            {
                try
                {
                    NumeroArquivoAtual += 1;
                    PorcentagemConcluida = (decimal)NumeroArquivoAtual / Arquivos.TotalDeArquivos * 100;
                    ArquivoAtual = arquivo.Key;
                    Notificacao?.Invoke();
                    var arquivoDestino = PathArquivoDestino(arquivo);
                    if (File.Exists(arquivoDestino))
                        if (!Substituir)
                            continue;
                    if (VerificarSeEMidiaHeic(arquivo.Key))
                        ConverterParHeic(arquivo.Key, arquivoDestino);
                    else
                        File.Copy(arquivo.Key, arquivoDestino, true);
                    if (ExcluirOriginal)
                        File.Delete(arquivo.Key);
                }
                catch (Exception)
                {
                    // ignora o erro                    
                }
            }

        }

        private void ConverterParHeic(string arquivoOrigem, string arquivoDestino)
        {
            if (File.Exists(arquivoDestino))
                File.Delete(arquivoDestino);

            using (var image = new MagickImage(arquivoOrigem))
                image.Write(Path.ChangeExtension(arquivoDestino, ".jpeg"), MagickFormat.Jpeg);

        }

        private string PathArquivoDestino(KeyValuePair<string, FileInfo> arquivo)
        {
            var nomeArquivo = Path.GetFileName(arquivo.Key);
            var dirDestino = CriarDiretorioDestino(arquivo.Value);

            if (!Directory.Exists(dirDestino))
                Directory.CreateDirectory(dirDestino);

            return $"{dirDestino}{nomeArquivo}";
        }
        public bool VerificarSeEMidia(string path)
        {
            var mediaPattern = new Regex(
                @".*\.(jpg|jpeg|png|gif|bmp|mp4|mkv|avi|mov|heic)$",
                RegexOptions.IgnoreCase);
            return mediaPattern.IsMatch(path);
        }
        public bool VerificarSeEMidiaHeic(string path)
        {
            var mediaPattern = new Regex(
                @".*\.(heic)$",
                RegexOptions.IgnoreCase);
            return mediaPattern.IsMatch(path);
        }
        public string CriarDiretorioDestino(FileInfo fileInfo)
        {
            if (VerificarSeEMidia(fileInfo.Name) || !SepararMidia)
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
            var pathArquivo = Path.GetDirectoryName(fileInfo.FullName)
                .Replace(Origem, "");
            if (!string.IsNullOrEmpty(pathArquivo))
                pathArquivo += "\\";
            return $"{Destino}\\Arquivos\\{pathArquivo}";
        }
    }
}
