using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            double filme = 0;
            double pipoca = 0;
            double coca = 0;
            double pedido = 0;
            double qntdPipoca = 0;
            double qntdCoca = 0;
            double total = 0;
            
            
            
            if (rdbNormal.Checked && ckb3D.Checked) //Se vc for pagar normal e com a opção 3D
            {
                filme = 17+ 7.50;

                if (ckbPipoca.Checked && ckbCocaCola.Checked)
                {
                    pipoca = 4.50;
                    coca = 4.25;
                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = (pipoca * qntdPipoca) + (coca * qntdCoca);

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;

                }

                else if (ckbPipoca.Checked)
                {
                     pipoca = 4.50;

                     pedido = 0;
                     qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    

                    pedido = pipoca * qntdPipoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

                else if (ckbCocaCola.Checked == true)
                {
                    coca = 4.25;
                    pedido = 0;
                    
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = coca * qntdCoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

            }

            
            
            
            
            else if (rdbEstudante.Checked && ckb3D.Checked) //Se vc é estudante e quer a opção 3D
            {
                filme = 8.50 + 7.50;

                if (ckbPipoca.Checked && ckbCocaCola.Checked == true)
                {
                    pipoca = 4.50;
                    coca = 4.25;
                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = (pipoca * qntdPipoca) + (coca * qntdCoca);

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;

                }

                else if (ckbPipoca.Checked == true)
                {
                    pipoca = 4.50;

                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    

                    pedido = pipoca * qntdPipoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

                else if (ckbCocaCola.Checked == true)
                {
                    coca = 4.25;
                    pedido = 0;
                    
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = coca * qntdCoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

            }

            
            
            
            
            else if (rdbNormal.Checked) //Se vc for pagar somente a Normal
            {
                filme = 17.00;

                if (ckbPipoca.Checked && ckbCocaCola.Checked == true)
                {
                    pipoca = 4.50;
                    coca = 4.25;
                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = (pipoca * qntdPipoca) + (coca * qntdCoca);

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;

                }

                else if (ckbPipoca.Checked == true)
                {
                    pipoca = 4.50;

                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    

                    pedido = pipoca * qntdPipoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

                else if (ckbCocaCola.Checked == true)
                {
                    coca = 4.25;
                    pedido = 0;
                    
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = coca * qntdCoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }
            }

           
            
            
            
            
            else //Se vc for pagar somente a Estudante
            {
                filme = 8.50;

                if (ckbPipoca.Checked && ckbCocaCola.Checked == true)
                {
                    pipoca = 4.50;
                    coca = 4.25;
                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = (pipoca * qntdPipoca) + (coca * qntdCoca);

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;

                }

                else if (ckbPipoca.Checked == true)
                {
                    pipoca = 4.50;

                    pedido = 0;
                    qntdPipoca = System.Convert.ToDouble(txbPipoca.Text);
                    

                    pedido = pipoca * qntdPipoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }

                else if (ckbCocaCola.Checked == true)
                {
                    coca = 4.25;
                    pedido = 0;
                    
                    qntdCoca = System.Convert.ToDouble(txbCocaCola.Text);

                    pedido = coca * qntdCoca;

                    total = filme + pedido;

                    txbTotalPagar.Text = "" + total;

                    txbValordoIngresso.Text = "" + filme;

                    txbFilmeSelecionado.Text = "" + comboFilme.Text;

                    txbValordoPedido.Text = "" + pedido;
                }


 
            }
            
            string especial = null;
            
            if (ckb3D.Checked == true) 
            {
                especial = "Selecionado";
            }
            else 
            {
                especial = "Opção não selecionada";
            }
 

            MessageBox.Show(
                "\nNome: " + textBox1.Text + 
                "\nFilme: " + comboFilme.Text +
                "\n3D: " + especial + 
                "\nValor: " + txbValordoIngresso.Text +
                "\nValor do Pedido: " + txbValordoPedido.Text +
                "\nTotal: " + txbTotalPagar.Text
            );

        }
    }
}
