using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Atividade
{
    class Conexao
    {
        //declarando um objeto de conexão passando como parametro a string de conexão
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=aluno.accdb";

        //variavel que representa a conexão com o banco
        private static OleDbConnection conn = null;

        //metodo que permite obter a conexão 
        public static OleDbConnection obterConexao()
        {

            //vamos criar a conexao 
            conn = new OleDbConnection(connString);

            //a conexao foi feita com sucesso?
            try
            {

                //abre a conexao e a devolve ao chamador do metdo 
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida");
                //ops! o que aconteceu?
                //uma boa ideia aqui é gravar e exeção em um arquivo de log 

            }
            return conn;
        }

        //******************************
        //metodo que permite fechar a conexão 

        public static void fecharConexao()
        {

            if (conn != null)
            {

                conn.Close();
            }
        }

    }
}
