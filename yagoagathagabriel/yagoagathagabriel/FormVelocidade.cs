using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yagoagathagabriel
{
    public partial class FormVelocidade : Form
    {
        public FormVelocidade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia = double.Parse(txtDistancia.Text);
            double tempo = double.Parse(txtTempo.Text);

            double velocidade = distancia / tempo;

            lblResultado.Text = "Velocidade média: " + velocidade + " m/s";
        }
    }
}
