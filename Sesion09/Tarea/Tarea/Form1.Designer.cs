namespace Tarea
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
            lblTitulo = new Label();
            lblValor = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtValor = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(156, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversor de temperatura";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(156, 48);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(131, 90);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(98, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Unidad de origen";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(126, 128);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(103, 15);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Unidad de destino";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(172, 221);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Click += lblResultado_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(244, 45);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Celsius", "", "Fahrenheit", "", "Kelvin" });
            cmbOrigen.Location = new Point(235, 90);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 6;
            // 
            // cmbDestino
            // 
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Celsius", "", "Fahrenheit", "", "Kelvin" });
            cmbDestino.Location = new Point(235, 128);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 7;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(199, 176);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 8;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 279);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblResultado);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValor;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
        private ComboBox cmbOrigen;
        private TextBox txtValor;
        private Button btnConvertir;
        private ComboBox cmbDestino;
    }
}
