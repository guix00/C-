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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Exgrande = 40.00;
            double grande = 35.00;
            double media = 25.00;
            double pequena = 15.00;
            double cheddar = 0;
            double catupiry = 0;
            double qtndPizza;
            double desconto = 0;
            double total;

            if (rdbExtraGrande.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbExtraGrande.Text);
                
                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((Exgrande + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }


            if (rdbGrande.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbGrande.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((grande + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }

            if (rdbMedia.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbMedia.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((media + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }

            if (rdbPequena.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbPequena.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((pequena + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double Exgrande = 40.00;
            double grande = 35.00;
            double media = 25.00;
            double pequena = 15.00;
            double cheddar = 0;
            double catupiry = 0;
            double qtndPizza;
            double desconto = 0;
            double total;

            if (rdbExtraGrande.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbExtraGrande.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((Exgrande + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }


            if (rdbGrande.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbGrande.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((grande + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }

            if (rdbMedia.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbMedia.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((media + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }

            if (rdbPequena.Checked)
            {
                //Conversão de bool para double
                qtndPizza = System.Convert.ToDouble(txbPequena.Text);

                //Calculando o valor do desconto conforme a quantidades de pizzas compradas
                if (qtndPizza == 2)
                {
                    desconto = 10.00;
                }
                if (qtndPizza == 3)
                {
                    desconto = 20.00;
                }
                if (qtndPizza >= 4)
                {
                    desconto = 25.00;
                }


                //Caso as bordas de Pizza sejam selecionadas:
                if (ckbCheddar.Checked == true)
                {
                    cheddar = 5.00;
                }

                if (ckbCatupiry.Checked == true)
                {
                    catupiry = 3.00;
                }

                //Calculando o valor total 
                total = ((pequena + catupiry + cheddar) * qtndPizza) - desconto;

                //Demonstrando o valor total e o valor de desconto
                txbValor.Text = "" + total;
                txbDesconto.Text = "" + desconto;
            }

            //Tamanho Selecionado para a demonstração no Confirmar Pedido
            string tamanho = null;

            if (rdbExtraGrande.Checked == true)
            {
                tamanho = "Extra Grande \n R$ 45.00";
            }
            else if (rdbGrande.Checked == true)
            {
                tamanho = "Grande \n R$ 35.00";
            }
            else if (rdbMedia.Checked == true)
            {
                tamanho = "Médio \n R$ 25.00";
            }
            else if (rdbPequena.Checked == true)
            {
                tamanho = "Pequeno \n R$ 15.00";
            }


            //Borda selecionada para a demonstração no Confirmar Pedido
            string bCheddar = null;
            string bCatupiry = null;
            string bd = null;


            if (ckbCheddar.Checked == true)
            {
                bCheddar = "Cheddar\n";
                bd = bCheddar;
            }
            if (ckbCatupiry.Checked == true)
            {
                bCatupiry = "Catupiry\n";
                bd = bCatupiry;
            }

            bd = bCheddar + bCatupiry;
            
            

            


            //Sabor selecionado para a demonstração no Confirmar Pedido
            string calabresa = null;
            string mussarela = null;
            string frango = null;
            string atum = null;
            string portuguesa = null;
            string escarola = null;
            string lombo = null;
            string sabor = null;

            if (ckbCalabresa.Checked == true)
            {
                calabresa = "Calabresa\n";
                sabor = calabresa;
            }
            if (ckbMussarela.Checked == true)
            {
                mussarela = "Mussarela\n";
                sabor = mussarela;
            }
            if (ckbFrango.Checked == true)
            {
                frango = "Frango\n";
                sabor = frango;
            }
            if (ckbAtum.Checked == true)
            {
                atum = "Atum\n";
                sabor = atum;
            }
            if (ckbPortuguesa.Checked == true)
            {
                portuguesa = "Portuguesa\n";
                sabor = portuguesa;
            }
            if (ckbEscarola.Checked == true)
            {
                escarola = "Escarola\n";
                sabor = escarola;
                
            }
            if (ckbLombo.Checked == true)
            {
               lombo = "Lombo\n";
               sabor = lombo;
            }

            sabor = calabresa + mussarela + frango + atum + portuguesa + escarola + lombo;

            
            
            
            MessageBox.Show
               (
               "\nTamanho:   " + tamanho +
               "\nBorda:  \n" + bd +
               "\nSabor: " + sabor +
               "\nDesconto: " + desconto +
               "\nTotal a pagar: " + txbValor.Text
               );


        }
    }
}
