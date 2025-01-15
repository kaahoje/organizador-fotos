namespace OrganizadorDeFotos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOrigem = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.ckExcluirOrigem = new System.Windows.Forms.CheckBox();
            this.btnOrganizar = new System.Windows.Forms.Button();
            this.ckSubstituir = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoOrganizacao = new System.Windows.Forms.ComboBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.ckSeparaArquivosDeMidia = new System.Windows.Forms.CheckBox();
            this.ckConverterHeicParaJpg = new System.Windows.Forms.CheckBox();
            this.lblArquivoAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasta de origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasta de destino:";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(95, 5);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(354, 20);
            this.txtOrigem.TabIndex = 2;
            this.txtOrigem.Text = "C:\\Users\\Leticia\\Desktop\\Teste do organizador\\origem";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(97, 28);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(353, 20);
            this.txtDestino.TabIndex = 3;
            this.txtDestino.Text = "C:\\Users\\Leticia\\Desktop\\Teste do organizador\\destino";
            // 
            // btnOrigem
            // 
            this.btnOrigem.Location = new System.Drawing.Point(453, 7);
            this.btnOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(56, 19);
            this.btnOrigem.TabIndex = 4;
            this.btnOrigem.Text = "Origem";
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(453, 30);
            this.btnDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(56, 19);
            this.btnDestino.TabIndex = 5;
            this.btnDestino.Text = "Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // ckExcluirOrigem
            // 
            this.ckExcluirOrigem.AutoSize = true;
            this.ckExcluirOrigem.Location = new System.Drawing.Point(11, 50);
            this.ckExcluirOrigem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckExcluirOrigem.Name = "ckExcluirOrigem";
            this.ckExcluirOrigem.Size = new System.Drawing.Size(149, 17);
            this.ckExcluirOrigem.TabIndex = 6;
            this.ckExcluirOrigem.Text = "Excluir arquivos de origem";
            this.ckExcluirOrigem.UseVisualStyleBackColor = true;
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(212, 220);
            this.btnOrganizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(76, 63);
            this.btnOrganizar.TabIndex = 7;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // ckSubstituir
            // 
            this.ckSubstituir.AutoSize = true;
            this.ckSubstituir.Checked = true;
            this.ckSubstituir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSubstituir.Location = new System.Drawing.Point(11, 71);
            this.ckSubstituir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckSubstituir.Name = "ckSubstituir";
            this.ckSubstituir.Size = new System.Drawing.Size(69, 17);
            this.ckSubstituir.TabIndex = 8;
            this.ckSubstituir.Text = "Substituir";
            this.ckSubstituir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Organizar por:";
            // 
            // cbTipoOrganizacao
            // 
            this.cbTipoOrganizacao.FormattingEnabled = true;
            this.cbTipoOrganizacao.Items.AddRange(new object[] {
            "Dia",
            "Mês",
            "Ano"});
            this.cbTipoOrganizacao.Location = new System.Drawing.Point(82, 134);
            this.cbTipoOrganizacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoOrganizacao.Name = "cbTipoOrganizacao";
            this.cbTipoOrganizacao.Size = new System.Drawing.Size(92, 21);
            this.cbTipoOrganizacao.TabIndex = 11;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(11, 159);
            this.progress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(503, 19);
            this.progress.TabIndex = 12;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(11, 199);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(503, 19);
            this.lblProgress.TabIndex = 13;
            // 
            // ckSeparaArquivosDeMidia
            // 
            this.ckSeparaArquivosDeMidia.AutoSize = true;
            this.ckSeparaArquivosDeMidia.Checked = true;
            this.ckSeparaArquivosDeMidia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSeparaArquivosDeMidia.Location = new System.Drawing.Point(11, 92);
            this.ckSeparaArquivosDeMidia.Margin = new System.Windows.Forms.Padding(2);
            this.ckSeparaArquivosDeMidia.Name = "ckSeparaArquivosDeMidia";
            this.ckSeparaArquivosDeMidia.Size = new System.Drawing.Size(220, 17);
            this.ckSeparaArquivosDeMidia.TabIndex = 14;
            this.ckSeparaArquivosDeMidia.Text = "Separar arquivos de mídia (fotos/vídeos)";
            this.ckSeparaArquivosDeMidia.UseVisualStyleBackColor = true;
            // 
            // ckConverterHeicParaJpg
            // 
            this.ckConverterHeicParaJpg.AutoSize = true;
            this.ckConverterHeicParaJpg.Checked = true;
            this.ckConverterHeicParaJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckConverterHeicParaJpg.Location = new System.Drawing.Point(11, 113);
            this.ckConverterHeicParaJpg.Margin = new System.Windows.Forms.Padding(2);
            this.ckConverterHeicParaJpg.Name = "ckConverterHeicParaJpg";
            this.ckConverterHeicParaJpg.Size = new System.Drawing.Size(147, 17);
            this.ckConverterHeicParaJpg.TabIndex = 15;
            this.ckConverterHeicParaJpg.Text = "Converter HEIC para JPG";
            this.ckConverterHeicParaJpg.UseVisualStyleBackColor = true;
            // 
            // lblArquivoAtual
            // 
            this.lblArquivoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoAtual.Location = new System.Drawing.Point(11, 180);
            this.lblArquivoAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArquivoAtual.Name = "lblArquivoAtual";
            this.lblArquivoAtual.Size = new System.Drawing.Size(502, 19);
            this.lblArquivoAtual.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 291);
            this.Controls.Add(this.lblArquivoAtual);
            this.Controls.Add(this.ckConverterHeicParaJpg);
            this.Controls.Add(this.ckSeparaArquivosDeMidia);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.cbTipoOrganizacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckSubstituir);
            this.Controls.Add(this.btnOrganizar);
            this.Controls.Add(this.ckExcluirOrigem);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnOrigem);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Organizador de fotos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnOrigem;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.CheckBox ckExcluirOrigem;
        private System.Windows.Forms.Button btnOrganizar;
        private System.Windows.Forms.CheckBox ckSubstituir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoOrganizacao;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.CheckBox ckSeparaArquivosDeMidia;
        private System.Windows.Forms.CheckBox ckConverterHeicParaJpg;
        private System.Windows.Forms.Label lblArquivoAtual;
    }
}

