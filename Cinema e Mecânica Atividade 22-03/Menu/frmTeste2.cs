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

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //Definição das CheckBox
            double interior = 0, motor = 0, carroceria = 0, suspensao = 0;

            double total = 0;

            if (ckbCarroceria.Checked == true)
            {
                carroceria = 599.00;



            }

            if (ckbInterior.Checked == true)
            {
                interior = 850.00;


            }

            if (ckbMotor.Checked == true)
            {
                motor = 799.00;

                
            }

            if (ckbSuspensao.Checked == true)
            {
                suspensao = 450.00;


            }
            // Calcular os valores selecionados na CheckBox
            total = motor + carroceria + interior + suspensao;

            txbTotal.Text = "" + total;
        }




        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //Definição das CheckBox
            double interior = 0, motor = 0, carroceria = 0, suspensao = 0;

            double total = 0;

            if (ckbCarroceria.Checked == true)
            {
                carroceria = 599.00;



            }

            if (ckbInterior.Checked == true)
            {
                interior = 850.00;


            }

            if (ckbMotor.Checked == true)
            {
                motor = 799.00;

                
            }

            if (ckbSuspensao.Checked == true)
            {
                suspensao = 450.00;


            }
            // Calcular os valores selecionados na CheckBox
            total = motor + carroceria + interior + suspensao;

            txbTotal.Text = "R$" + total;

            string camb = null;
            
            if (rdbAutomatico.Checked == true) 
            {
                camb = "Câmbio: Automático";
            }
            else if (rdbManual.Checked == true) 
            {
                camb = "Câmbio: Manual";
            }



                MessageBox.Show
                (
                "\nNome:   " + txbNome.Text +
                "\nRG:  " + txbRG.Text + 
                "\nCPF: " + txbCPF.Text +
                "\nEndereço: " + txbEndereço.Text + 
                "\nNúmero: " + txbNumero.Text +
                "\nResidencial: " +  txbResidencial.Text +
                "\nData de Apresentação: " +txbApresentar.Text +
                "\nData de Recebimento: " + txbRetirar.Text+
                "\nCelular: " + txbCelular.Text +
                "\nModelo do Carro: " + txbModelo.Text + 
                "\nCor original: " + txbCor.Text + 
                "\nAno do Automóvel: " + comboAnoAutomovel.Text +
                "\n" + camb+
                "\nServiços: " + comboServiços.Text +
                "\nTotal a pagar: " + txbTotal.Text
                );



        }
    }
}
