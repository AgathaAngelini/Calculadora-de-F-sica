namespace yagoagathagabriel
{
    partial class FormPeso
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
            lblResultado = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMassa = new TextBox();
            txtGravidade = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 136);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Massa:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(239, 309);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(67, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 183);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Gravidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 82);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "PESO";
            // 
            // txtMassa
            // 
            txtMassa.Location = new Point(325, 136);
            txtMassa.Name = "txtMassa";
            txtMassa.Size = new Size(100, 23);
            txtMassa.TabIndex = 4;
            // 
            // txtGravidade
            // 
            txtGravidade.Location = new Point(325, 180);
            txtGravidade.Name = "txtGravidade";
            txtGravidade.Size = new Size(100, 23);
            txtGravidade.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(325, 259);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormPeso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtGravidade);
            Controls.Add(txtMassa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "FormPeso";
            Text = "FormPeso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Label label3;
        private Label label4;
        private TextBox txtMassa;
        private TextBox txtGravidade;
        private Button btnCalcular;
    }
}