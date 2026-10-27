using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yagoagathagabriel
{
    public partial class Form0hm : Form
    {
        public Form0hm()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double tensao = double.Parse(txtTensao.Text);
            double resistencia = double.Parse(txtResistencia.Text);

            double corrente = tensao / resistencia;

            lblResultado.Text = "Corrente: " + corrente + " A";
        }

    }
}
