namespace PostgradoApp
{
    partial class dictamenTotal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dictamenTotal));
            this.dataGridDictamen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.estado = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.buscarTxtBox = new System.Windows.Forms.TextBox();
            this.btnEntregados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNoEntregados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTotal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictaminanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeemisiónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aptoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tDICTAMENINGRESADOVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDICTAMENINGRESADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDICTAMENDEVUELTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictamen)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENDEVUELTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDictamen
            // 
            this.dataGridDictamen.AllowUserToAddRows = false;
            this.dataGridDictamen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridDictamen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDictamen.AutoGenerateColumns = false;
            this.dataGridDictamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDictamen.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDictamen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDictamen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridDictamen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDictamen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDictamen.ColumnHeadersHeight = 33;
            this.dataGridDictamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.alumnoDataGridViewTextBoxColumn,
            this.dictaminanteDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.destinatarioDataGridViewTextBoxColumn,
            this.fechadeemisiónDataGridViewTextBoxColumn,
            this.fechadeingresoDataGridViewTextBoxColumn,
            this.aptoDataGridViewCheckBoxColumn,
            this.estado,
            this.detalle});
            this.dataGridDictamen.DataSource = this.tDICTAMENINGRESADOVIEWBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDictamen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDictamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDictamen.DoubleBuffered = true;
            this.dataGridDictamen.EnableHeadersVisualStyles = false;
            this.dataGridDictamen.HeaderBgColor = System.Drawing.Color.White;
            this.dataGridDictamen.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            this.dataGridDictamen.Location = new System.Drawing.Point(0, 88);
            this.dataGridDictamen.MultiSelect = false;
            this.dataGridDictamen.Name = "dataGridDictamen";
            this.dataGridDictamen.ReadOnly = true;
            this.dataGridDictamen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDictamen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDictamen.RowHeadersVisible = false;
            this.dataGridDictamen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDictamen.Size = new System.Drawing.Size(1038, 489);
            this.dataGridDictamen.TabIndex = 0;
            this.dataGridDictamen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDictamen_CellContentClick);
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.buscarTxtBox);
            this.panel1.Controls.Add(this.btnEntregados);
            this.panel1.Controls.Add(this.btnNoEntregados);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 88);
            this.panel1.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Reportes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 0D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(316, 26);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(93, 33);
            this.bunifuFlatButton1.TabIndex = 31;
            this.bunifuFlatButton1.Text = "Reportes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Editar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(872, 12);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(106, 39);
            this.bunifuThinButton22.TabIndex = 30;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.btnEditarDictamen_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Nuevo";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DimGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(758, 12);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(106, 39);
            this.bunifuThinButton21.TabIndex = 29;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btnNuevoDictamen_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(485, 57);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(226, 10);
            this.bunifuSeparator3.TabIndex = 28;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // buscarTxtBox
            // 
            this.buscarTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.buscarTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscarTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buscarTxtBox.ForeColor = System.Drawing.Color.DimGray;
            this.buscarTxtBox.Location = new System.Drawing.Point(485, 36);
            this.buscarTxtBox.Multiline = true;
            this.buscarTxtBox.Name = "buscarTxtBox";
            this.buscarTxtBox.Size = new System.Drawing.Size(230, 22);
            this.buscarTxtBox.TabIndex = 27;
            this.buscarTxtBox.Text = "Buscar por apellido";
            this.buscarTxtBox.TextChanged += new System.EventHandler(this.buscarTxtBox_TextChanged);
            this.buscarTxtBox.Enter += new System.EventHandler(this.Enter1);
            this.buscarTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarTxtBox_KeyPress);
            this.buscarTxtBox.Leave += new System.EventHandler(this.Leave1);
            // 
            // btnEntregados
            // 
            this.btnEntregados.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnEntregados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEntregados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntregados.BorderRadius = 5;
            this.btnEntregados.ButtonText = "Entregados (2)";
            this.btnEntregados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEntregados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEntregados.Iconimage = null;
            this.btnEntregados.Iconimage_right = null;
            this.btnEntregados.Iconimage_right_Selected = null;
            this.btnEntregados.Iconimage_Selected = null;
            this.btnEntregados.IconMarginLeft = 0;
            this.btnEntregados.IconMarginRight = 0;
            this.btnEntregados.IconRightVisible = true;
            this.btnEntregados.IconRightZoom = 0D;
            this.btnEntregados.IconVisible = true;
            this.btnEntregados.IconZoom = 0D;
            this.btnEntregados.IsTab = false;
            this.btnEntregados.Location = new System.Drawing.Point(211, 25);
            this.btnEntregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntregados.Name = "btnEntregados";
            this.btnEntregados.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.btnEntregados.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.btnEntregados.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.btnEntregados.selected = false;
            this.btnEntregados.Size = new System.Drawing.Size(93, 33);
            this.btnEntregados.TabIndex = 24;
            this.btnEntregados.Text = "Entregados (2)";
            this.btnEntregados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntregados.Textcolor = System.Drawing.Color.White;
            this.btnEntregados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEntregados.Click += new System.EventHandler(this.btnEntregados_Click);
            // 
            // btnNoEntregados
            // 
            this.btnNoEntregados.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnNoEntregados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNoEntregados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoEntregados.BorderRadius = 5;
            this.btnNoEntregados.ButtonText = "No entregados (2)";
            this.btnNoEntregados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoEntregados.DisabledColor = System.Drawing.Color.Gray;
            this.btnNoEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNoEntregados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNoEntregados.Iconimage = null;
            this.btnNoEntregados.Iconimage_right = null;
            this.btnNoEntregados.Iconimage_right_Selected = null;
            this.btnNoEntregados.Iconimage_Selected = null;
            this.btnNoEntregados.IconMarginLeft = 0;
            this.btnNoEntregados.IconMarginRight = 0;
            this.btnNoEntregados.IconRightVisible = true;
            this.btnNoEntregados.IconRightZoom = 0D;
            this.btnNoEntregados.IconVisible = true;
            this.btnNoEntregados.IconZoom = 0D;
            this.btnNoEntregados.IsTab = false;
            this.btnNoEntregados.Location = new System.Drawing.Point(105, 25);
            this.btnNoEntregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoEntregados.Name = "btnNoEntregados";
            this.btnNoEntregados.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.btnNoEntregados.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.btnNoEntregados.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.btnNoEntregados.selected = false;
            this.btnNoEntregados.Size = new System.Drawing.Size(107, 33);
            this.btnNoEntregados.TabIndex = 23;
            this.btnNoEntregados.Text = "No entregados (2)";
            this.btnNoEntregados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNoEntregados.Textcolor = System.Drawing.Color.White;
            this.btnNoEntregados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnNoEntregados.Click += new System.EventHandler(this.btnNoEntregados_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Activecolor = System.Drawing.SystemColors.ControlLight;
            this.btnTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTotal.BorderRadius = 5;
            this.btnTotal.ButtonText = "Todos (4)";
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.DisabledColor = System.Drawing.Color.Gray;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTotal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTotal.Iconimage = null;
            this.btnTotal.Iconimage_right = null;
            this.btnTotal.Iconimage_right_Selected = null;
            this.btnTotal.Iconimage_Selected = null;
            this.btnTotal.IconMarginLeft = 0;
            this.btnTotal.IconMarginRight = 0;
            this.btnTotal.IconRightVisible = true;
            this.btnTotal.IconRightZoom = 0D;
            this.btnTotal.IconVisible = true;
            this.btnTotal.IconZoom = 0D;
            this.btnTotal.IsTab = true;
            this.btnTotal.Location = new System.Drawing.Point(15, 25);
            this.btnTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.btnTotal.OnHovercolor = System.Drawing.SystemColors.ControlLight;
            this.btnTotal.OnHoverTextColor = System.Drawing.SystemColors.ControlDark;
            this.btnTotal.selected = true;
            this.btnTotal.Size = new System.Drawing.Size(91, 34);
            this.btnTotal.TabIndex = 22;
            this.btnTotal.Text = "Todos (4)";
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTotal.Textcolor = System.Drawing.Color.White;
            this.btnTotal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnTotal.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(482, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            this.alumnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dictaminanteDataGridViewTextBoxColumn
            // 
            this.dictaminanteDataGridViewTextBoxColumn.DataPropertyName = "Dictaminante";
            this.dictaminanteDataGridViewTextBoxColumn.HeaderText = "Dictaminante";
            this.dictaminanteDataGridViewTextBoxColumn.Name = "dictaminanteDataGridViewTextBoxColumn";
            this.dictaminanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinatarioDataGridViewTextBoxColumn
            // 
            this.destinatarioDataGridViewTextBoxColumn.DataPropertyName = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.HeaderText = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.Name = "destinatarioDataGridViewTextBoxColumn";
            this.destinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadeemisiónDataGridViewTextBoxColumn
            // 
            this.fechadeemisiónDataGridViewTextBoxColumn.DataPropertyName = "Fecha_de_emisión";
            this.fechadeemisiónDataGridViewTextBoxColumn.HeaderText = "Fecha de emisión";
            this.fechadeemisiónDataGridViewTextBoxColumn.Name = "fechadeemisiónDataGridViewTextBoxColumn";
            this.fechadeemisiónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadeingresoDataGridViewTextBoxColumn
            // 
            this.fechadeingresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_de_ingreso";
            this.fechadeingresoDataGridViewTextBoxColumn.HeaderText = "Fecha de ingreso";
            this.fechadeingresoDataGridViewTextBoxColumn.Name = "fechadeingresoDataGridViewTextBoxColumn";
            this.fechadeingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aptoDataGridViewCheckBoxColumn
            // 
            this.aptoDataGridViewCheckBoxColumn.DataPropertyName = "Apto";
            this.aptoDataGridViewCheckBoxColumn.HeaderText = "Apto";
            this.aptoDataGridViewCheckBoxColumn.Name = "aptoDataGridViewCheckBoxColumn";
            this.aptoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tDICTAMENINGRESADOVIEWBindingSource
            // 
            this.tDICTAMENINGRESADOVIEWBindingSource.DataSource = typeof(PostgradoApp.TDICTAMEN_INGRESADOVIEW);
            // 
            // tDICTAMENINGRESADOBindingSource
            // 
            this.tDICTAMENINGRESADOBindingSource.DataSource = typeof(PostgradoApp.TDICTAMEN_INGRESADO);
            // 
            // tDICTAMENDEVUELTOBindingSource
            // 
            this.tDICTAMENDEVUELTOBindingSource.DataSource = typeof(PostgradoApp.TDICTAMEN_DEVUELTO);
            // 
            // dictamenTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridDictamen);
            this.Controls.Add(this.panel1);
            this.Name = "dictamenTotal";
            this.Size = new System.Drawing.Size(1038, 577);
            this.Load += new System.EventHandler(this.dictamenTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDictamen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENINGRESADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDICTAMENDEVUELTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDictamen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox buscarTxtBox;
        private Bunifu.Framework.UI.BunifuFlatButton btnEntregados;
        private Bunifu.Framework.UI.BunifuFlatButton btnNoEntregados;
        private Bunifu.Framework.UI.BunifuFlatButton btnTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.BindingSource tDICTAMENINGRESADOBindingSource;
        private System.Windows.Forms.BindingSource tDICTAMENDEVUELTOBindingSource;
        private System.Windows.Forms.BindingSource tDICTAMENINGRESADOVIEWBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictaminanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeemisiónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeingresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aptoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
