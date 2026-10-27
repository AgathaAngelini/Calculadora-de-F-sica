namespace yagoagathagabriel
{
    partial class FormAceleracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtVelocidadeInicial = new TextBox();
            label3 = new Label();
            txtVelocidadeFinal = new TextBox();
            label4 = new Label();
            txtTempo = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 82);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ACELERAÇÃO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 139);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Velocidade inicial:";
            // 
            // txtVelocidadeInicial
            // 
            txtVelocidadeInicial.Location = new Point(324, 136);
            txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            txtVelocidadeInicial.Size = new Size(100, 23);
            txtVelocidadeInicial.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 192);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 3;
            label3.Text = "Velocidade final:";
            // 
            // txtVelocidadeFinal
            // 
            txtVelocidadeFinal.Location = new Point(324, 189);
            txtVelocidadeFinal.Name = "txtVelocidadeFinal";
            txtVelocidadeFinal.Size = new Size(100, 23);
            txtVelocidadeFinal.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 245);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Tempo:";
            // 
            // txtTempo
            // 
            txtTempo.Location = new Point(324, 242);
            txtTempo.Name = "txtTempo";
            txtTempo.Size = new Size(100, 23);
            txtTempo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(324, 306);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(191, 357);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado:";
            // 
            // FormAceleracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtTempo);
            Controls.Add(label4);
            Controls.Add(txtVelocidadeFinal);
            Controls.Add(label3);
            Controls.Add(txtVelocidadeInicial);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAceleracao";
            Text = "FormAceleracao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVelocidadeInicial;
        private Label label3;
        private TextBox txtVelocidadeFinal;
        private Label label4;
        private TextBox txtTempo;
        private Button btnCalcular;
        private Label lblResultado;
    }
}