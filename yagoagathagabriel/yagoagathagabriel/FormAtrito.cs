using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace yagoagathagabriel
{
    public partial class FormAtrito : Form
    {
        public FormAtrito()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double coeficiente = double.Parse(txtCoeficiente.Text);
            double normal = double.Parse(txtNormal.Text);

            double atrito = coeficiente * normal;

            lblResultado.Text = "Força de atrito: " + atrito + " N";
        }
    }
}
