using OrganizadorDeFotos.Strategy;
using System;
using System.Threading;
using System.Windows.Forms;

namespace OrganizadorDeFotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbTipoOrganizacao.SelectedIndex = 0;
        }

        private void btnOrigem_Click(object sender, EventArgs e)
        {
            folderDialog.SelectedPath = txtOrigem.Text;
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtOrigem.Text = folderDialog.SelectedPath;

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            folderDialog.SelectedPath = txtDestino.Text;
            if (folderDialog.ShowDialog() == DialogResult.OK)
                txtDestino.Text = folderDialog.SelectedPath;

        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            var arquivoOrigem = new ArquivosDeOrigem(txtOrigem.Text);
            arquivoOrigem.Carregar();
            var organizador = new Organizador(arquivoOrigem, txtDestino.Text);
            organizador.Substituir = ckSubstituir.Checked;
            organizador.ExcluirOriginal = ckExcluirOrigem.Checked;
            organizador.TipoOrganizacao = cbTipoOrganizacao.SelectedIndex;
            organizador.SepararMidia = ckSeparaArquivosDeMidia.Checked;
            organizador.Notificacao = () =>
            {
                // Usando Invoke para atualizar os componentes de UI
                Invoke((MethodInvoker)delegate {
                    lblProgress.Text = $"{organizador.NumeroArquivoAtual}/{arquivoOrigem.TotalDeArquivos}";
                    progress.Value = (int)organizador.PorcentagemConcluida;
                    Thread.Sleep(10);
                    if (organizador.PorcentagemConcluida == 100)
                        MessageBox.Show("Processo concluído com sucesso.");
                });
            };
            var thread = new Thread(() =>
            {
                
                organizador.Organizar();
            });
            thread.Start();

        }
    }
}
