using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public FrmCalculadora()
        {
            InitializeComponent();
        }
        private void button31_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "0";       
        }
        private void button21_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "1";
        }
        private void button22_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "2";
        }
        private void button23_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "3";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "4";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "5";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "7";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "8";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TextResultado.Text += "9";
        }
        private void button33_Click(object sender, EventArgs e)
        {
            TextResultado.Text += ".";
        }
        private void button25_Click(object sender, EventArgs e)
        {

            if (TextResultado.Text != "")
            {
                valor2 = decimal.Parse(TextResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SUB")
                {
                    TextResultado.Text = Convert.ToString(valor1 - valor2);
                    txtHistorico.Text += $"{valor1} - {valor2} = {TextResultado.Text} \n";
                }
                else if (operacao == "SOMA")
                {
                    TextResultado.Text = Convert.ToString(valor1 + valor2);
                    txtHistorico.Text += $"{valor1} + {valor2} = {TextResultado.Text} \n";
                }
                else if (operacao == "DIV")
                {
                    TextResultado.Text = Convert.ToString(valor1 / valor2);
                    txtHistorico.Text += $"{valor1} / {valor2} = {TextResultado.Text}\n";
                }
                else
                {
                    TextResultado.Text = Convert.ToString(valor1 * valor2);
                    txtHistorico.Text += $"{valor1} * {valor2} = {TextResultado.Text}\n";
                }
            }
            else
            {
                MessageBox.Show("Não existe nenhum Resultado.");
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if(TextResultado.Text != "")
            {
                valor1 = decimal.Parse(TextResultado.Text, CultureInfo.InvariantCulture);
                TextResultado.Text = "";
                operacao = "SUB";
                lboperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }   
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(TextResultado.Text != "")
            {
                valor1 = decimal.Parse(TextResultado.Text, CultureInfo.InvariantCulture);
                TextResultado.Text = "";
                operacao = "SOMA";
                lboperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }      
        }
        private void button34_Click(object sender, EventArgs e)
        {
            if(TextResultado.Text != "")
            {
                valor1 = decimal.Parse(TextResultado.Text, CultureInfo.InvariantCulture);
                TextResultado.Text = "";
                operacao = "DIV";
                lboperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão.");
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (TextResultado.Text != "")
            {
                valor1 = decimal.Parse(TextResultado.Text, CultureInfo.InvariantCulture);
                TextResultado.Text = "";
                operacao = "MULT";
                lboperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            TextResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lboperacao.Text = "";       
        }
        private void txtHistorico_TextChanged(object sender, EventArgs e)
        {
            TextResultado.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btapagar_Click(object sender, EventArgs e)
        {
            if (txtHistorico.Text != "")
            {              
                TextResultado.Text = "";
                txtHistorico.Text = "";
            }
            else
            {
                MessageBox.Show(" Ainda não há historico.");
            }       
        }
        private void TextResultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            TextResultado.Text = "";
        }
    }
}
