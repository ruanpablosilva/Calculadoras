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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text)).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text)).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text)).ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

    }
}
