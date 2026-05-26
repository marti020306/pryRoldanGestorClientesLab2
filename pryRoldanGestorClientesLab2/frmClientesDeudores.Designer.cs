namespace pryRoldanGestorClientesLab2
{
    partial class frmClientesDeudores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDeudaBlanco = new System.Windows.Forms.Label();
            this.lblCantidadBlanco = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblPromedioBlanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(57, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // lblDeudaBlanco
            // 
            this.lblDeudaBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaBlanco.Location = new System.Drawing.Point(222, 333);
            this.lblDeudaBlanco.Name = "lblDeudaBlanco";
            this.lblDeudaBlanco.Size = new System.Drawing.Size(100, 23);
            this.lblDeudaBlanco.TabIndex = 1;
            // 
            // lblCantidadBlanco
            // 
            this.lblCantidadBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadBlanco.Location = new System.Drawing.Point(219, 399);
            this.lblCantidadBlanco.Name = "lblCantidadBlanco";
            this.lblCantidadBlanco.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadBlanco.TabIndex = 2;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(54, 469);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(113, 16);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio Deuda:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(54, 399);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(134, 16);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad de Clientes:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(54, 333);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(85, 16);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Total Deuda:";
            // 
            // lblPromedioBlanco
            // 
            this.lblPromedioBlanco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioBlanco.Location = new System.Drawing.Point(219, 462);
            this.lblPromedioBlanco.Name = "lblPromedioBlanco";
            this.lblPromedioBlanco.Size = new System.Drawing.Size(100, 23);
            this.lblPromedioBlanco.TabIndex = 6;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.lblPromedioBlanco);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidadBlanco);
            this.Controls.Add(this.lblDeudaBlanco);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmClientesDeudores";
            this.Text = "Clientes Deudores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblDeudaBlanco;
        private System.Windows.Forms.Label lblCantidadBlanco;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblPromedioBlanco;
    }
}