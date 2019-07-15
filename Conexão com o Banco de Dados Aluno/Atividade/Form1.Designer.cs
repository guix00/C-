namespace Atividade
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alunoDataSet = new Atividade.alunoDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new Atividade.alunoDataSetTableAdapters.alunoTableAdapter();
            this.tableAdapterManager = new Atividade.alunoDataSetTableAdapters.TableAdapterManager();
            this.btmPrimeiro = new System.Windows.Forms.Button();
            this.btmAnterior = new System.Windows.Forms.Button();
            this.btmProximo = new System.Windows.Forms.Button();
            this.btmUltimo = new System.Windows.Forms.Button();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.txbRG = new System.Windows.Forms.MaskedTextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alunoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(44, 101);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(44, 147);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(44, 204);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(44, 252);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(28, 511);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(80, 13);
            this.lblPesquisa.TabIndex = 5;
            this.lblPesquisa.Text = "Nome pesquisa";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(105, 40);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(226, 20);
            this.txbNome.TabIndex = 6;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(105, 94);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(226, 20);
            this.txbEndereco.TabIndex = 7;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(105, 249);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(77, 20);
            this.txbIdade.TabIndex = 10;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(123, 511);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(226, 20);
            this.txbPesquisa.TabIndex = 11;
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(597, 37);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(597, 75);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(597, 116);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(597, 164);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(157, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Aluno:";
            // 
            // alunoDataSet
            // 
            this.alunoDataSet.DataSetName = "alunoDataSet";
            this.alunoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "aluno";
            this.alunoBindingSource.DataSource = this.alunoDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Atividade.alunoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btmPrimeiro
            // 
            this.btmPrimeiro.Location = new System.Drawing.Point(241, 246);
            this.btmPrimeiro.Name = "btmPrimeiro";
            this.btmPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btmPrimeiro.TabIndex = 21;
            this.btmPrimeiro.Text = "Primeiro";
            this.btmPrimeiro.UseVisualStyleBackColor = true;
            this.btmPrimeiro.Click += new System.EventHandler(this.btmPrimeiro_Click_1);
            // 
            // btmAnterior
            // 
            this.btmAnterior.Location = new System.Drawing.Point(334, 246);
            this.btmAnterior.Name = "btmAnterior";
            this.btmAnterior.Size = new System.Drawing.Size(75, 23);
            this.btmAnterior.TabIndex = 22;
            this.btmAnterior.Text = "Anterior";
            this.btmAnterior.UseVisualStyleBackColor = true;
            this.btmAnterior.Click += new System.EventHandler(this.btmAnterior_Click_1);
            // 
            // btmProximo
            // 
            this.btmProximo.Location = new System.Drawing.Point(426, 246);
            this.btmProximo.Name = "btmProximo";
            this.btmProximo.Size = new System.Drawing.Size(75, 23);
            this.btmProximo.TabIndex = 23;
            this.btmProximo.Text = "Próximo";
            this.btmProximo.UseVisualStyleBackColor = true;
            this.btmProximo.Click += new System.EventHandler(this.btmProximo_Click_1);
            // 
            // btmUltimo
            // 
            this.btmUltimo.Location = new System.Drawing.Point(520, 246);
            this.btmUltimo.Name = "btmUltimo";
            this.btmUltimo.Size = new System.Drawing.Size(75, 23);
            this.btmUltimo.TabIndex = 24;
            this.btmUltimo.Text = "Último";
            this.btmUltimo.UseVisualStyleBackColor = true;
            this.btmUltimo.Click += new System.EventHandler(this.btmUltimo_Click_1);
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(47, 325);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(625, 160);
            this.dgvAluno.TabIndex = 25;
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(105, 140);
            this.txbRG.Mask = "00000000-0";
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(226, 20);
            this.txbRG.TabIndex = 26;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(105, 204);
            this.txbTelefone.Mask = "0000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(226, 20);
            this.txbTelefone.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 565);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btmUltimo);
            this.Controls.Add(this.btmProximo);
            this.Controls.Add(this.btmAnterior);
            this.Controls.Add(this.btmPrimeiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbPesquisa);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alunoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private alunoDataSet alunoDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private alunoDataSetTableAdapters.alunoTableAdapter alunoTableAdapter;
        private alunoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btmPrimeiro;
        private System.Windows.Forms.Button btmAnterior;
        private System.Windows.Forms.Button btmProximo;
        private System.Windows.Forms.Button btmUltimo;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.MaskedTextBox txbRG;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
    }
}

