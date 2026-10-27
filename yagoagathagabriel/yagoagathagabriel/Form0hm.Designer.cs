namespace yagoagathagabriel
{
    partial class Form0hm
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
            label3 = new Label();
            txtTensao = new TextBox();
            txtResistencia = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 73);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "LEI DE OHM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 129);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Tensão:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 171);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Resistência:";
            // 
            // txtTensao
            // 
            txtTensao.Location = new Point(320, 126);
            txtTensao.Name = "txtTensao";
            txtTensao.Size = new Size(100, 23);
            txtTensao.TabIndex = 3;
            // 
            // txtResistencia
            // 
            txtResistencia.Location = new Point(320, 168);
            txtResistencia.Name = "txtResistencia";
            txtResistencia.Size = new Size(100, 23);
            txtResistencia.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(316, 229);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(242, 304);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // Form0hm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtResistencia);
            Controls.Add(txtTensao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form0hm";
            Text = "Form0hm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTensao;
        private TextBox txtResistencia;
        private Button btnCalcular;
        private Label lblResultado;
    }
}