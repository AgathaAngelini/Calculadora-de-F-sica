using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yagoagathagabriel
{
    public partial class FormPeso : Form
    {
        public FormPeso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double massa = double.Parse(txtMassa.Text);
            double gravidade = double.Parse(txtGravidade.Text);

            double peso = massa * gravidade;

            lblResultado.Text = "Peso: " + peso + " N";
        }
    }
}
