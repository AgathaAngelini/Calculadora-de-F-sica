namespace yagoagathagabriel
{
    partial class FormAtrito
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
            txtCoeficiente = new TextBox();
            txtNormal = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 129);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Coeficiente de atrito:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 174);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Força normal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 69);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "FORÇA DE ATRITO";
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(350, 126);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(100, 23);
            txtCoeficiente.TabIndex = 3;
            // 
            // txtNormal
            // 
            txtNormal.Location = new Point(350, 171);
            txtNormal.Name = "txtNormal";
            txtNormal.Size = new Size(100, 23);
            txtNormal.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(322, 243);
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
            lblResultado.Location = new Point(233, 314);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
            // 
            // FormAtrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNormal);
            Controls.Add(txtCoeficiente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAtrito";
            Text = "FormAtrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCoeficiente;
        private TextBox txtNormal;
        private Button btnCalcular;
        private Label lblResultado;
    }
}