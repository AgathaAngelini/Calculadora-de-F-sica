using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yagoagathagabriel
{
    public partial class FormAceleracao : Form
    {
        public FormAceleracao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double velocidadeInicial = double.Parse(txtVelocidadeInicial.Text);
            double velocidadeFinal = double.Parse(txtVelocidadeFinal.Text);
            double tempo = double.Parse(txtTempo.Text);

            double aceleracao = (velocidadeFinal - velocidadeInicial) / tempo;

            lblResultado.Text = "Aceleração: " + aceleracao + " m/s²";
        }
    }
}
