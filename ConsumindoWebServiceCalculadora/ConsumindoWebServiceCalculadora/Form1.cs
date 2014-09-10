using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoWebServiceCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs evtArgs)
        {
            string ValorUm = txtValorUm.Text;
            string ValorDois = txtValorDois.Text;

            if (IsEmpty(ValorUm))
            {
                MessageBox.Show("Preencha o valor um.");
            }
            else if (IsEmpty(ValorDois))
            {
                MessageBox.Show("Preencha o valor dois.");
            }
            else
            {
                string Operacao = "";

                if (radioBtnSoma.Checked)
                {
                    Operacao = "Soma";
                }
                else if (radioBtnSubtracao.Checked)
                {
                    Operacao = "Subtracao";
                }
                else if (radioBtnMultiplicacao.Checked)
                {
                    Operacao = "Multiplicacao";
                }
                else if (radioBtnDivisao.Checked)
                {
                    Operacao = "Divisao";
                }

                ConsomeServicoCalculadora.CalculadoraSoapClient client = new ConsomeServicoCalculadora.CalculadoraSoapClient();
                MessageBox.Show(client.RealizaCalculo(Operacao, ValorUm, ValorDois));
            }
        }

        private bool IsEmpty(string Valor)
        {
            bool Retorno = false;

            if(Valor.Equals(""))
            {
                Retorno = true;
            }

            return Retorno;
        }
    }
}
