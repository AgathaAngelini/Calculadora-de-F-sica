namespace yagoagathagabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVelocidade tela = new FormVelocidade();
            tela.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormOhm tela = new FormOhm();
            tela.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPeso tela = new FormPeso();
            tela.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormAtrito tela = new FormAtrito();
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAceleracao tela = new FormAceleracao();
            tela.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPeso tela = new FormPeso();
            tela.Show();
        }
    }
}
