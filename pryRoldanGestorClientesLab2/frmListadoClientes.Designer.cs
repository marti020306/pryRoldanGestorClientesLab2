namespace pryRoldanGestorClientesLab2
{
    partial class frmListadoClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBlancoPromedio = new System.Windows.Forms.Label();
            this.lblBlancoCantidad = new System.Windows.Forms.Label();
            this.lblBlancoTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdenar);
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.lblBlancoPromedio);
            this.groupBox1.Controls.Add(this.lblBlancoCantidad);
            this.groupBox1.Controls.Add(this.lblBlancoTotal);
            this.groupBox1.Controls.Add(this.lblPromedio);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(801, 641);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta De Datos";
            // 
            // lblBlancoPromedio
            // 
            this.lblBlancoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoPromedio.Location = new System.Drawing.Point(635, 578);
            this.lblBlancoPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoPromedio.Name = "lblBlancoPromedio";
            this.lblBlancoPromedio.Size = new System.Drawing.Size(133, 28);
            this.lblBlancoPromedio.TabIndex = 6;
            // 
            // lblBlancoCantidad
            // 
            this.lblBlancoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoCantidad.Location = new System.Drawing.Point(635, 529);
            this.lblBlancoCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoCantidad.Name = "lblBlancoCantidad";
            this.lblBlancoCantidad.Size = new System.Drawing.Size(133, 28);
            this.lblBlancoCantidad.TabIndex = 5;
            // 
            // lblBlancoTotal
            // 
            this.lblBlancoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBlancoTotal.Location = new System.Drawing.Point(635, 476);
            this.lblBlancoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlancoTotal.Name = "lblBlancoTotal";
            this.lblBlancoTotal.Size = new System.Drawing.Size(133, 28);
            this.lblBlancoTotal.TabIndex = 4;
            this.lblBlancoTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(473, 580);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(129, 16);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio de Deuda";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(473, 530);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(131, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de Clientes";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(473, 478);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total de Deuda";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvClientes.Location = new System.Drawing.Point(8, 23);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(760, 418);
            this.dgvClientes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(44, 525);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 33);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(204, 525);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 33);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 671);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoClientes";
            this.Text = "Listado De Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblBlancoPromedio;
        private System.Windows.Forms.Label lblBlancoCantidad;
        private System.Windows.Forms.Label lblBlancoTotal;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnReporte;
    }
}