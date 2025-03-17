namespace Calculadora_01
{
    public partial class Form1 : Form
    {
        private string Resultado { get; set; }
        private int valor { get; set; }
        private Operacao operacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
        }

        private void bntUm_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void bntDois_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void bntTres_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void bntQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void bntSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void bntSete_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void bntOito_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void bntNove_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void bntZero_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void bntAdicao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Adicao;
            valor = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
        }

        private void bntMultimicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
        }

        
        private void bntIgual_Click(object sender, EventArgs e)
        {
            textResultado.Text = "0";
            switch (operacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = valor + textResultado.Text;
                    break;
                case Operacao.Subtracao:
                    Resultado = valor - Convert.ToInt32(textResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = valor * Convert.ToDouble(textResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = valor / Convert.ToDouble(textResultado.Text);
                    break;
                default:
                    break;
            }
            textResultado.Text = Convert.ToString(Resultado);
        }

        private void bntVirgula_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
            {
                textResultado.Text += ",";
            }

        }

        private void bntC_Click(object sender, EventArgs e)
        {
            textResultado.Text += " ";
        }
    }
}
