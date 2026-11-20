namespace Inventario.Escritorio
{
    partial class FormReportes
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
            lblTitulo = new Label();
            lblValiosos = new Label();
            lblStockBajo = new Label();
            dgvValiosos = new DataGridView();
            dgvStockBajo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvValiosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(245, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(125, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes de inventario";
            // 
            // lblValiosos
            // 
            lblValiosos.AutoSize = true;
            lblValiosos.Location = new Point(75, 21);
            lblValiosos.Name = "lblValiosos";
            lblValiosos.Size = new Size(131, 15);
            lblValiosos.TabIndex = 1;
            lblValiosos.Text = "Productos más valiosos";
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Location = new Point(385, 21);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(141, 15);
            lblStockBajo.TabIndex = 2;
            lblStockBajo.Text = "Productos con stock bajo";
            // 
            // dgvValiosos
            // 
            dgvValiosos.AllowUserToAddRows = false;
            dgvValiosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvValiosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValiosos.Location = new Point(16, 39);
            dgvValiosos.MultiSelect = false;
            dgvValiosos.Name = "dgvValiosos";
            dgvValiosos.ReadOnly = true;
            dgvValiosos.RowHeadersVisible = false;
            dgvValiosos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvValiosos.Size = new Size(264, 150);
            dgvValiosos.TabIndex = 3;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.AllowUserToAddRows = false;
            dgvStockBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(326, 39);
            dgvStockBajo.MultiSelect = false;
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.ReadOnly = true;
            dgvStockBajo.RowHeadersVisible = false;
            dgvStockBajo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockBajo.Size = new Size(264, 150);
            dgvStockBajo.TabIndex = 4;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 215);
            Controls.Add(dgvStockBajo);
            Controls.Add(dgvValiosos);
            Controls.Add(lblStockBajo);
            Controls.Add(lblValiosos);
            Controls.Add(lblTitulo);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvValiosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValiosos;
        private Label lblStockBajo;
        private DataGridView dgvValiosos;
        private DataGridView dgvStockBajo;
    }
}