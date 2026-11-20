namespace Inventario.Escritorio
{
    partial class FormPrincipal
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
            lblTitulo = new Label();
            lblBuscar = new Label();
            lblValor = new Label();
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnVender = new Button();
            btnStock = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(207, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inventario de productos";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(169, 52);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(97, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar producto:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(190, 352);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(111, 15);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor del inventario:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(272, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(94, 78);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(378, 150);
            dgvProductos.TabIndex = 4;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(286, 313);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(86, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(94, 234);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(190, 234);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(90, 23);
            btnVender.TabIndex = 7;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(286, 234);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(90, 23);
            btnStock.TabIndex = 8;
            btnStock.Text = "Agregar stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(382, 234);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 317);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 10;
            label1.Text = "Cantidad:";
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(245, 272);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(80, 23);
            btnReportes.TabIndex = 11;
            btnReportes.Text = "Ver reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 377);
            Controls.Add(btnReportes);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnStock);
            Controls.Add(btnVender);
            Controls.Add(btnAgregar);
            Controls.Add(nudCantidad);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Controls.Add(lblValor);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblBuscar;
        private Label lblValor;
        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private Button btnVender;
        private Button btnStock;
        private Button btnEliminar;
        private Label label1;
        private Button btnReportes;
    }
}
