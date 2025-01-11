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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasta de origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasta de destino:";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(127, 6);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(471, 22);
            this.txtOrigem.TabIndex = 2;
            this.txtOrigem.Text = "C:\\Users\\Leticia\\Desktop\\Teste do organizador\\origem";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(129, 34);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(469, 22);
            this.txtDestino.TabIndex = 3;
            this.txtDestino.Text = "C:\\Users\\Leticia\\Desktop\\Teste do organizador\\destino";
            // 
            // btnOrigem
            // 
            this.btnOrigem.Location = new System.Drawing.Point(604, 9);
            this.btnOrigem.Name = "btnOrigem";
            this.btnOrigem.Size = new System.Drawing.Size(75, 23);
            this.btnOrigem.TabIndex = 4;
            this.btnOrigem.Text = "Origem";
            this.btnOrigem.UseVisualStyleBackColor = true;
            this.btnOrigem.Click += new System.EventHandler(this.btnOrigem_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(604, 37);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(75, 23);
            this.btnDestino.TabIndex = 5;
            this.btnDestino.Text = "Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // ckExcluirOrigem
            // 
            this.ckExcluirOrigem.AutoSize = true;
            this.ckExcluirOrigem.Location = new System.Drawing.Point(15, 62);
            this.ckExcluirOrigem.Name = "ckExcluirOrigem";
            this.ckExcluirOrigem.Size = new System.Drawing.Size(187, 20);
            this.ckExcluirOrigem.TabIndex = 6;
            this.ckExcluirOrigem.Text = "Excluir arquivos de origem";
            this.ckExcluirOrigem.UseVisualStyleBackColor = true;
            // 
            // btnOrganizar
            // 
            this.btnOrganizar.Location = new System.Drawing.Point(282, 247);
            this.btnOrganizar.Name = "btnOrganizar";
            this.btnOrganizar.Size = new System.Drawing.Size(102, 77);
            this.btnOrganizar.TabIndex = 7;
            this.btnOrganizar.Text = "Organizar";
            this.btnOrganizar.UseVisualStyleBackColor = true;
            this.btnOrganizar.Click += new System.EventHandler(this.btnOrganizar_Click);
            // 
            // ckSubstituir
            // 
            this.ckSubstituir.AutoSize = true;
            this.ckSubstituir.Location = new System.Drawing.Point(226, 62);
            this.ckSubstituir.Name = "ckSubstituir";
            this.ckSubstituir.Size = new System.Drawing.Size(83, 20);
            this.ckSubstituir.TabIndex = 8;
            this.ckSubstituir.Text = "Substituir";
            this.ckSubstituir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
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
            this.cbTipoOrganizacao.Location = new System.Drawing.Point(109, 88);
            this.cbTipoOrganizacao.Name = "cbTipoOrganizacao";
            this.cbTipoOrganizacao.Size = new System.Drawing.Size(121, 24);
            this.cbTipoOrganizacao.TabIndex = 11;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(15, 140);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(671, 23);
            this.progress.TabIndex = 12;
            // 
            // lblProgress
            // 
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(279, 173);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(105, 23);
            this.lblProgress.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 336);
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
    }
}

