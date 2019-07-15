using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Atividade
{
    public partial class Form1 : Form
    {
        //Conectar atraves da classe 
        OleDbConnection conn = Conexao.obterConexao();

        //Declarando DataReader -- tabela virtual somente leitura 
        OleDbDataReader dr_aluno;

        //Declarando o BindingSource -- Tabela virtual editavel 
        BindingSource bs_aluno = new BindingSource();

        //cria a variavel que receberá a query (comando sql)
        String _query;

        private void carregar_grid()
        {

            //determinado a query desejada
            _query = "select* from aluno";

            //declarando o objeto  DataCommand passando a query e o obejto de conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            //execute o método ExecuteReader que retornará um DataReader preenchido com a query
            try
            {
                dr_aluno = _dataCommand.ExecuteReader();
            }
            catch (Exception)
            {

            }

            if (dr_aluno.HasRows == true)
            {

                //Neste momento a tabela bs_clientes está sendo alimentada com os dados vindos da tabela DataReader (dr_clientes)
                bs_aluno.DataSource = dr_aluno;
                dgvAluno.DataSource = bs_aluno;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos pessoas cadastradas !!!!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //Método igualar() para identificar as informações contidas nas labels e textbox com as do banco
        private void igualar_text()
        {
            lblID.DataBindings.Add("Text", bs_aluno, "id_aluno");
            lblID.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_aluno, "nome");
            txbNome.DataBindings.Clear();
            txbEndereco.DataBindings.Add("Text", bs_aluno, "endereco");
            txbEndereco.DataBindings.Clear();
            txbRG.DataBindings.Add("Text", bs_aluno, "rg");
            txbRG.DataBindings.Clear();
            txbTelefone.DataBindings.Add("Text", bs_aluno, "telefone");
            txbTelefone.DataBindings.Clear();
            txbIdade.DataBindings.Add("Text", bs_aluno, "idade");
            txbIdade.DataBindings.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregar_grid();
            this.alunoTableAdapter.Fill(this.alunoDataSet.aluno);

        }
        private void dgvAluno_Click(object sender, EventArgs e)
        {
            igualar_text();
        }
        private void dgvAluno_KeyUp(object sender, EventArgs e)
        {
            igualar_text();
        }


        public Form1()
        {
            InitializeComponent();
            carregar_grid();
           
        }

        //Método para realizar a pesquisa dos dados cadastrados no banco
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //Para realizar a pesquisa, o comando SQL seleciona o nome já cadastrado no banco
            _query = "Select * from Aluno where nome like '" + txbPesquisa.Text + "'";
            MessageBox.Show(_query);

            //Try e Catch para verificar se tudo ocorreu perfeitamente ou não
            try
            {

                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_aluno = _dataCommand.ExecuteReader();


                if (dr_aluno.HasRows == true)
                {

                    bs_aluno.DataSource = dr_aluno;

                }
                else
                {

                    MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbPesquisa.Text = "";

                }

                igualar_text();
            }

            catch (Exception meu)
            {
                MessageBox.Show(meu.ToString());
            }
        }

        
        
        public string query { get; set; }



        //Método para realizar a limpa dos dados
        private void limpar()
        {
            lblID.Text = "";
            txbNome.Clear();
            txbEndereco.Clear();
            txbRG.Clear();
            txbEndereco.Clear();
            txbIdade.Clear();
            txbTelefone.Clear();

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }


        //Método para realizar a exclusão dos dados do banco
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Comando SQL de exclusão de dados
            _query = "delete from Aluno where id_aluno like'" + lblID.Text + "'";

            //Try e Catch para verificar se tudo ocorreu perfeitamente ou não
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão !!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        //Método para validar se os campos foram preenchidos corretamente
        private bool valida()
        {
            bool erro = true;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite!", "Atenção bro!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
            }

            else if (txbEndereco.Text == "")
            {
                MessageBox.Show("Endereço Inválido. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEndereco.Focus();
            }
            else if (txbRG.Text == "")
            {
                MessageBox.Show("RG Inválido. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbRG.Focus();
            }
            else if (txbTelefone.Text == "")
            {
                MessageBox.Show("Telefone Inválido. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbTelefone.Focus();
            }
            else if (txbIdade.Text == "")
            {
                MessageBox.Show("Idade Inválida. Redigite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbIdade.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }



        //Método para realizar a Alteração
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool teste; //Variavel para receber o valor de ERRO apos executar a valida
            teste = valida(); //Executando valida() e armazenando o resultado na variavel bool erro

            if (teste == false)
            {
                _query = "Update Aluno set nome = '" + txbNome.Text + "',";
                _query += "endereco = '" + txbEndereco.Text + "',";
                _query += "rg = '" + txbRG.Text + "',";
                _query += "telefone = '" + txbTelefone.Text + "',";
                _query += "idade = '" + txbIdade.Text + "' ";
                _query += "where id_aluno like  '" + lblID.Text + "'";
                
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    igualar_text();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                catch (Exception g)
                {
                    MessageBox.Show(g.ToString());
                    MessageBox.Show("Problemas com a Alteração  !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Método para realizar o cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool teste;//Variavel para receber o valor de ERRO apos executar a valida
            teste = valida();//Executando valida() e armazenando o resultado na variavel bool erro

            if (teste == false)
            {
                _query = "Insert into Aluno (nome,endereco,rg,telefone,idade) Values ";
                _query += "('" + txbNome.Text + "','" + txbEndereco.Text + "','" + txbRG.Text + "','" + txbTelefone.Text + "','" + txbIdade.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    
                    MessageBox.Show("Incluido com sucesso !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    carregar_grid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Inclusão  !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        
        


        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alunoDataSet);

        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from aluno where nome like '" + txbPesquisa.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(query, conn);
            dr_aluno = _dataCommand.ExecuteReader();

            if (dr_aluno.HasRows == true)
            {
                bs_aluno.DataSource = dr_aluno;
            }
            else
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisa.Text = "";
            }

        }

        private void btmPrimeiro_Click_1(object sender, EventArgs e)
        {
            // move o ponteiro de registros para a primeira posição da tabela virtual -   memória 

            bs_aluno.MoveFirst();
            // atualiza os campos do formulário com o registro posicionado na memória 
            igualar_text();
        }

        private void btmAnterior_Click_1(object sender, EventArgs e)
        {
            if (bs_aluno.Position == 0)
            {

                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                bs_aluno.MovePrevious();
                igualar_text();
            }
        }

        private void btmProximo_Click_1(object sender, EventArgs e)
        {
            if (bs_aluno.Count == bs_aluno.Position + 1)
            {
                MessageBox.Show("Fim de arquivo encontrado!!!!", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_aluno.MoveNext();
                igualar_text();
            }
        }

        private void btmUltimo_Click_1(object sender, EventArgs e)
        {
            // move o ponteiro de registros para a última posição da tabela virtual -   memória 
            bs_aluno.MoveLast();
            // atualiza os campos do formulário com a posição da memória 
            igualar_text();
        }











    }
}
