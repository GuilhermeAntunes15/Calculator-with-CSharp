using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculos calc = new Calculos(); // instanciar a clasee
        double valor1, valor2;

        public Form1()
        {
            InitializeComponent();
        }

        private void entradaDados()
        {
            valor1 = Convert.ToDouble(txt_v1.Text);
            valor2 = Convert.ToDouble(txt_v2.Text);
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Subtrair(valor1, valor2).ToString();
            lbl_Resp.Visible = true;
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Dividir(valor1, valor2).ToString();
            lbl_Resp.Visible = true;
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Multiplicar(valor1, valor2).ToString();
            lbl_Resp.Visible = true;
        }

        private void btn_Ans_Click(object sender, EventArgs e)
        {
            txt_v1.Text = lbl_Resp.Text;
            txt_v2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Porcentagem(valor1).ToString();
            lbl_Resp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Potenciacao(valor1, valor2).ToString();
            lbl_Resp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Raiz(valor1, valor2).ToString();
            lbl_Resp.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Potencia e Raiz no valor um coloque o numero e no dois o indice",
            "Ajuda");
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            entradaDados();

            lbl_Resp.Text = calc.Somar(valor1, valor2).ToString();
            lbl_Resp.Visible = true;

        }
    }
}
