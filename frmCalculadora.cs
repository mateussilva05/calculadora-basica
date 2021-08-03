using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        double valorVisor = 0, valorAnterior = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void CliqueBotao_Click(object sender, EventArgs e) //Evento de clique do mouse.
        {
            if (txtVisor.Text == "0" || botaoIgual == true) //Verifica se o texto do txtVisor é "0,". 
            {
                txtVisor.Clear(); //Limpa o texto do visor.
                botaoIgual = false;
            }

            Button botaoClicado = (Button)sender; //Instancia a classe Button como objeto.

            switch (botaoClicado.Name) //Verifica qual o botao clicado através do nome.
            {
                case "btn1":                    //Caso o nome do botao clicado seja "btn1",
                    txtVisor.Text += "1";       //o visor vai imprimir o número 1.
                    break;

                case "btn2":
                    txtVisor.Text += "2";
                    break;

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    };
                    break;
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e) //Evento de clique no botão Adição
        {
            if (primeiraOperacao) //Verifica se a adição é a primeira operação.
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //A variável valorAnterior recebe o texto de txtVisor convertido para double.

                if (botaoIgual == false) //Verifica se o botão btnIgual foi clicado.
                {
                    txtHistorico.Text += txtVisor.Text; //O txtHistorico recebe o texto de txtVisor.
                }

                txtVisor.Clear(); //txtVisor é limpo.
                operacao = " + "; //Variável operação recebe adição.
                primeiraOperacao = false; //primeiraOperacao fica falsa.
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //Variável valorVisor recebe o texto de txtVisor convertido para double.

                txtHistorico.Text += operacao + txtVisor.Text; //txtHistorico imprime a operação e o texto de txtVisor.

                //txtVisor.Text = Convert.ToString(valorAnterior + valorVisor); //txtVisor recebe os dados das variáveis valorAnterior e valorVisor convertidos em string.
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " + ";
                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = " - ";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                //txtVisor.Text = Convert.ToString(valorAnterior - valorVisor);
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " - ";
                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = " x ";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                //txtVisor.Text = Convert.ToString(valorAnterior * valorVisor);
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " x ";
                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = " / ";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                //txtVisor.Text = Convert.ToString(valorAnterior / valorVisor);
                txtVisor.Text = Convert.ToString(Calculo());

                operacao = " / ";
                txtHistorico.Text += " = " + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorVisor = Convert.ToDouble(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            txtVisor.Text = Convert.ToString(Calculo());

            txtHistorico.Text += " = " + txtVisor.Text;

            valorAnterior = Convert.ToDouble(txtVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }

        private double Calculo()
        {
            switch (operacao)
            {
                case " + ":
                    valorAnterior = valorAnterior + valorVisor;
                    break;

                case " - ":
                    valorAnterior = valorAnterior - valorVisor;
                    break;

                case " x ":
                    valorAnterior = valorAnterior * valorVisor;
                    break;

                case " / ":
                    valorAnterior = valorAnterior / valorVisor;
                    break;

                default:
                    break;
            }

            return valorAnterior;
        }

        private void btnLimpar_Click(object sender, EventArgs e) //Evento de clique no botão Limpar.
        {
            txtVisor.Clear(); //Código que deixa o Visor limpo.
            txtHistorico.Clear(); //Código que deixa o Histórico limpo. 
            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e) //Evento de clique no botão Backspace.
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1); //Código que apaga um caractere do lado direito para o esquerdo do Visor.
        }
    }
}
