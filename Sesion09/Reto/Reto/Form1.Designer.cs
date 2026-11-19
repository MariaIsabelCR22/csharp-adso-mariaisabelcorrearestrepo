namespace Reto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitular = new Label();
            lblSaldo = new Label();
            lblMonto = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            lblMovimientos = new Label();
            lstMovimientos = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            btnTransferir = new Button();
            lblDestinatario = new Label();
            txtDestinatario = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(253, 56);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(179, 13);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular: Maria Isabel Correa Restrepo";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(300, 84);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(85, 13);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo: $500.000";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(229, 142);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(116, 13);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto de la operacion:";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(356, 140);
            nudMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(117, 20);
            nudMonto.TabIndex = 3;
            nudMonto.ThousandsSeparator = true;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(229, 170);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(64, 20);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(321, 170);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(64, 20);
            btnRetirar.TabIndex = 5;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(319, 203);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(66, 13);
            lblMovimientos.TabIndex = 6;
            lblMovimientos.Text = "Movimientos";
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(229, 229);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(244, 82);
            lstMovimientos.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(409, 170);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(64, 20);
            btnTransferir.TabIndex = 9;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Location = new Point(229, 114);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new Size(121, 13);
            lblDestinatario.TabIndex = 10;
            lblDestinatario.Text = "Nombre del destinatario:";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(356, 114);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(117, 20);
            txtDestinatario.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 24);
            label1.Name = "label1";
            label1.Size = new Size(123, 13);
            label1.TabIndex = 12;
            label1.Text = "CAJERO AUTOMATICO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(715, 335);
            Controls.Add(label1);
            Controls.Add(txtDestinatario);
            Controls.Add(lblDestinatario);
            Controls.Add(btnTransferir);
            Controls.Add(lstMovimientos);
            Controls.Add(lblMovimientos);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cajero Automatico";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitular;
        private Label lblSaldo;
        private Label lblMonto;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Button btnRetirar;
        private Label lblMovimientos;
        private ListBox lstMovimientos;
        private ErrorProvider errorProvider1;
        private Button btnTransferir;
        private TextBox txtDestinatario;
        private Label lblDestinatario;
        private Label label1;
    }
}
