namespace PostgradoApp
{
    partial class dictamenIngresado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridDictamen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tDICTAMENINGRESADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDictamen
            // 
            this.dataGridDictamen.AllowUserToAddRows = false;
            this.dataGridDictamen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridDictamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDictamen.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridDictamen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDictamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDictamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDictamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDictamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridDictamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDictamen.DoubleBuffered = true;
            this.dataGridDictamen.EnableHeadersVisualStyles = false;
            this.dataGridDictamen.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.dataGridDictamen.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDictamen.Location = new System.Drawing.Point(0, 0);
            this.dataGridDictamen.MultiSelect = false;
            this.dataGridDictamen.Name = "dataGridDictamen";
            this.dataGridDictamen.ReadOnly = true;
            this.dataGridDictamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDictamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDictamen.Size = new System.Drawing.Size(1032, 487);
            this.dataGridDictamen.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ingresado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tDICTAMENINGRESADOBindingSource
            // 
            this.tDICTAMENINGRESADOBindingSource.DataSource = typeof(PostgradoApp.TDICTAMEN_INGRESADO);
            // 
            // dictamenIngresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridDictamen);
            this.Name = "dictamenIngresado";
            this.Size = new System.Drawing.Size(1032, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDictamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.BindingSource tDICTAMENINGRESADOBindingSource;
    }
}
