using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faculdade_calcudadora_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, media;
            num1 = float.Parse(txtValor1.Text);
            num2 = float.Parse(txtValor2.Text);
            num3 = float.Parse(txtValor3.Text);

            media = (num1 + num2 + num3) / 3;

            txtResultado.Text = media.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInstrucao1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            var num = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = num.ToString("N1");
        }
    }
}
