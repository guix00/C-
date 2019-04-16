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
    public partial class frmTeste2 : Form
    {
        public frmTeste2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double fixo = 35.00;
            double frete = 0;
            
            double total= 0;

            string RSul = "Sul";
            string RSudeste = "Sudeste";
            string RNordeste = "Nordeste";
            string RCentro = "Centro-Oeste";
            string RNorte = "Norte";


            valor = System.Convert.ToDouble(txbValor.Text);
            
            //Caso o valor seja maior ou igual a 5000, o frete será grátis
            if (valor >= 5000)
            {
                MessageBox.Show("O Frete é grátis!!");
            }


            //Caso o valor seja menor que 5000, calcular o frete conforme a região selecionada
            else
            {

                //Caso a região Sul seja selecionada acrescentar 8% ao frete em relação ao valor de compra 
                if (comboBox1.Text == RSul)
                {
                    frete = (valor * 8/100);
                    total = valor + frete + fixo;
                    lblFrete.Text = "" + frete;
                    lblValor.Text = "" + valor;
                    lblTotal.Text = "" + total;

                    MessageBox.Show
                    ("Nome: " + txbNome.Text +
                    "\nValor: " + txbValor.Text +
                    "\nLocalização: " + comboBox1.Text +
                    "\nFrete: " + lblFrete.Text +
                    "\nTotal: " + lblTotal.Text
                    );
                }

                //Caso a região Sudeste seja selecionada acrescentar 5% ao frete em relação ao valor de compra
                if (comboBox1.Text == RSudeste)
                {
                    frete = (valor * 5 / 100);
                    total = valor + frete + fixo;
                    lblFrete.Text = "" + frete;
                    lblValor.Text = "" + valor;
                    lblTotal.Text = "" + total;

                    MessageBox.Show
                    ("Nome: " + txbNome.Text +
                    "\nValor: " + txbValor.Text +
                    "\nLocalização: " + comboBox1.Text +
                    "\nFrete: " + lblFrete.Text +
                    "\nTotal: " + lblTotal.Text
                    );
                }

                //Caso a região Centro-Oeste seja selecionada acrescentar 12% ao frete em relação ao valor de compra
                if (comboBox1.Text == RCentro)
                {
                    frete = (valor * 12 / 100);
                    total = valor + frete + fixo;
                    lblFrete.Text = "" + frete;
                    lblValor.Text = "" + valor;
                    lblTotal.Text = "" + total;

                    MessageBox.Show
                    ("Nome: " + txbNome.Text +
                    "\nValor: " + txbValor.Text +
                    "\nLocalização: " + comboBox1.Text +
                    "\nFrete: " + lblFrete.Text +
                    "\nTotal: " + lblTotal.Text
                    );
                }


                //Caso a região Nordeste seja selecionada acrescentar 15% ao frete em relação ao valor de compra
                if (comboBox1.Text == RNordeste)
                {
                    frete = (valor * 15 / 100);
                    total = valor + frete + fixo;
                    lblFrete.Text = "" + frete;
                    lblValor.Text = "" + valor;
                    lblTotal.Text = "" + total;

                    MessageBox.Show
                    ("Nome: " + txbNome.Text +
                    "\nValor: " + txbValor.Text +
                    "\nLocalização: " + comboBox1.Text +
                    "\nFrete: " + lblFrete.Text +
                    "\nTotal: " + lblTotal.Text
                    );
                }

                //Caso a região Norte seja selecionada acrescentar 17% ao frete em relação ao valor de compra
                if (comboBox1.Text == RNorte)
                {
                    frete = (valor * 17 / 100);
                    total = valor + frete + fixo;
                    lblFrete.Text = "" + frete;
                    lblValor.Text = "" + valor;
                    lblTotal.Text = "" + total;

                    MessageBox.Show
                    ("Nome: " + txbNome.Text +
                    "\nValor: " + txbValor.Text +
                    "\nLocalização: " + comboBox1.Text +
                    "\nFrete: " + lblFrete.Text +
                    "\nTotal: " + lblTotal.Text
                    );
                }

               
            }



        }
    }
}
