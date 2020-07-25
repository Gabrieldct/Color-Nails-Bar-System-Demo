namespace ColorNails
{
    partial class Main
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonFacturar = new System.Windows.Forms.Button();
            this.BotonImpFac = new System.Windows.Forms.Button();
            this.BotonComisiones = new System.Windows.Forms.Button();
            this.BotonCuadre = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.BotonCierre = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Sub_total = new System.Windows.Forms.TextBox();
            this.CBServicios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEmpleados = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Display = new System.Windows.Forms.DataGridView();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GestionS = new System.Windows.Forms.Button();
            this.GestionP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorNailbarDataSet1 = new ColorNails.ColorNailbarDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter1 = new ColorNails.ColorNailbarDataSetTableAdapters.EmpleadosTableAdapter();
            this.productosYServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productos_Y_ServiciosTableAdapter1 = new ColorNails.ColorNailbarDataSetTableAdapters.Productos_Y_ServiciosTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new ColorNails.ColorNailbarDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosYServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(877, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe Total";
            // 
            // BotonFacturar
            // 
            this.BotonFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonFacturar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BotonFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotonFacturar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonFacturar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonFacturar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotonFacturar.Location = new System.Drawing.Point(883, 439);
            this.BotonFacturar.Name = "BotonFacturar";
            this.BotonFacturar.Size = new System.Drawing.Size(166, 28);
            this.BotonFacturar.TabIndex = 10;
            this.BotonFacturar.Text = "Facturar";
            this.BotonFacturar.UseVisualStyleBackColor = true;
            this.BotonFacturar.Click += new System.EventHandler(this.BotonFacturar_Click);
            // 
            // BotonImpFac
            // 
            this.BotonImpFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonImpFac.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonImpFac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BotonImpFac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotonImpFac.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonImpFac.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonImpFac.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotonImpFac.Location = new System.Drawing.Point(882, 473);
            this.BotonImpFac.Name = "BotonImpFac";
            this.BotonImpFac.Size = new System.Drawing.Size(166, 28);
            this.BotonImpFac.TabIndex = 11;
            this.BotonImpFac.Text = "Imprimir Factura";
            this.BotonImpFac.UseVisualStyleBackColor = true;
            // 
            // BotonComisiones
            // 
            this.BotonComisiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonComisiones.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonComisiones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BotonComisiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotonComisiones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonComisiones.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BotonComisiones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotonComisiones.Location = new System.Drawing.Point(883, 227);
            this.BotonComisiones.Name = "BotonComisiones";
            this.BotonComisiones.Size = new System.Drawing.Size(165, 32);
            this.BotonComisiones.TabIndex = 14;
            this.BotonComisiones.Text = "Calcular Comisiones";
            this.BotonComisiones.UseVisualStyleBackColor = true;
            this.BotonComisiones.Click += new System.EventHandler(this.BotonComisiones_Click);
            // 
            // BotonCuadre
            // 
            this.BotonCuadre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCuadre.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonCuadre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BotonCuadre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotonCuadre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonCuadre.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BotonCuadre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotonCuadre.Location = new System.Drawing.Point(883, 163);
            this.BotonCuadre.Name = "BotonCuadre";
            this.BotonCuadre.Size = new System.Drawing.Size(166, 26);
            this.BotonCuadre.TabIndex = 19;
            this.BotonCuadre.Text = "Cuadre";
            this.BotonCuadre.UseVisualStyleBackColor = true;
            this.BotonCuadre.Click += new System.EventHandler(this.BotonCuadre_Click);
            // 
            // button29
            // 
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button29.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.button29.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button29.Location = new System.Drawing.Point(883, 131);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(166, 26);
            this.button29.TabIndex = 68;
            this.button29.Text = "Iniciar Dia";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // BotonCierre
            // 
            this.BotonCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCierre.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BotonCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BotonCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BotonCierre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonCierre.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BotonCierre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotonCierre.Location = new System.Drawing.Point(883, 195);
            this.BotonCierre.Name = "BotonCierre";
            this.BotonCierre.Size = new System.Drawing.Size(166, 26);
            this.BotonCierre.TabIndex = 69;
            this.BotonCierre.Text = "Cerrar Dia";
            this.BotonCierre.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ColorNails.Properties.Resources.Icono;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Sub_total
            // 
            this.Sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Sub_total.Location = new System.Drawing.Point(882, 404);
            this.Sub_total.Name = "Sub_total";
            this.Sub_total.ReadOnly = true;
            this.Sub_total.Size = new System.Drawing.Size(166, 29);
            this.Sub_total.TabIndex = 72;
            // 
            // CBServicios
            // 
            this.CBServicios.BackColor = System.Drawing.Color.RosyBrown;
            this.CBServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBServicios.DataSource = this.productosYServiciosBindingSource;
            this.CBServicios.DisplayMember = "nombre";
            this.CBServicios.DropDownHeight = 120;
            this.CBServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBServicios.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold);
            this.CBServicios.FormattingEnabled = true;
            this.CBServicios.IntegralHeight = false;
            this.CBServicios.Location = new System.Drawing.Point(24, 333);
            this.CBServicios.Name = "CBServicios";
            this.CBServicios.Size = new System.Drawing.Size(231, 41);
            this.CBServicios.TabIndex = 73;
            this.CBServicios.ValueMember = "Precio";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(197, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 47);
            this.label4.TabIndex = 75;
            this.label4.Text = "Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 47);
            this.label3.TabIndex = 76;
            this.label3.Text = "Empleado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // CBEmpleados
            // 
            this.CBEmpleados.BackColor = System.Drawing.Color.RosyBrown;
            this.CBEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEmpleados.DataSource = this.empleadosBindingSource;
            this.CBEmpleados.DisplayMember = "Nombre";
            this.CBEmpleados.DropDownHeight = 120;
            this.CBEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEmpleados.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold);
            this.CBEmpleados.FormattingEnabled = true;
            this.CBEmpleados.IntegralHeight = false;
            this.CBEmpleados.Location = new System.Drawing.Point(24, 236);
            this.CBEmpleados.Name = "CBEmpleados";
            this.CBEmpleados.Size = new System.Drawing.Size(231, 41);
            this.CBEmpleados.TabIndex = 77;
            this.CBEmpleados.ValueMember = "ID";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DataSource = this.clientesBindingSource;
            this.comboBox3.DisplayMember = "Nombre";
            this.comboBox3.DropDownHeight = 120;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Location = new System.Drawing.Point(314, 10);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(540, 35);
            this.comboBox3.TabIndex = 78;
            // 
            // Display
            // 
            this.Display.AllowUserToAddRows = false;
            this.Display.AllowUserToDeleteRows = false;
            this.Display.AllowUserToResizeColumns = false;
            this.Display.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Display.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.Display.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Display.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Servicio,
            this.Precio});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Display.DefaultCellStyle = dataGridViewCellStyle4;
            this.Display.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Display.EnableHeadersVisualStyles = false;
            this.Display.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Display.Location = new System.Drawing.Point(299, 183);
            this.Display.MultiSelect = false;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Display.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Display.RowHeadersVisible = false;
            this.Display.RowHeadersWidth = 20;
            this.Display.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Display.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Display.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Maroon;
            this.Display.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Display.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Brown;
            this.Display.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Display.RowTemplate.Height = 30;
            this.Display.RowTemplate.ReadOnly = true;
            this.Display.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Display.ShowCellErrors = false;
            this.Display.ShowCellToolTips = false;
            this.Display.ShowEditingIcon = false;
            this.Display.ShowRowErrors = false;
            this.Display.Size = new System.Drawing.Size(535, 274);
            this.Display.TabIndex = 79;
            this.Display.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Display_CellValueChanged);
            // 
            // Empleado
            // 
            this.Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Servicio
            // 
            this.Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.FillWeight = 90F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(299, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 38);
            this.button2.TabIndex = 80;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(746, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 81;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GestionS
            // 
            this.GestionS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GestionS.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.GestionS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.GestionS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.GestionS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GestionS.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.GestionS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GestionS.Location = new System.Drawing.Point(883, 289);
            this.GestionS.Name = "GestionS";
            this.GestionS.Size = new System.Drawing.Size(166, 26);
            this.GestionS.TabIndex = 82;
            this.GestionS.Text = "Gestion Servicios";
            this.GestionS.UseVisualStyleBackColor = true;
            this.GestionS.Click += new System.EventHandler(this.GestionS_Click);
            // 
            // GestionP
            // 
            this.GestionP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GestionP.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.GestionP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.GestionP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.GestionP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GestionP.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.GestionP.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GestionP.Location = new System.Drawing.Point(882, 321);
            this.GestionP.Name = "GestionP";
            this.GestionP.Size = new System.Drawing.Size(166, 26);
            this.GestionP.TabIndex = 83;
            this.GestionP.Text = "Gestion Personal";
            this.GestionP.UseVisualStyleBackColor = true;
            this.GestionP.Click += new System.EventHandler(this.GestionP_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(887, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 84;
            this.button1.Text = "Gestion Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // colorNailbarDataSet1
            // 
            this.colorNailbarDataSet1.DataSetName = "ColorNailbarDataSet";
            this.colorNailbarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.colorNailbarDataSet1;
            // 
            // empleadosTableAdapter1
            // 
            this.empleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // productosYServiciosBindingSource
            // 
            this.productosYServiciosBindingSource.DataMember = "Productos Y Servicios";
            this.productosYServiciosBindingSource.DataSource = this.colorNailbarDataSet1;
            // 
            // productos_Y_ServiciosTableAdapter1
            // 
            this.productos_Y_ServiciosTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.colorNailbarDataSet1;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1092, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GestionP);
            this.Controls.Add(this.GestionS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.CBEmpleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBServicios);
            this.Controls.Add(this.Sub_total);
            this.Controls.Add(this.BotonCierre);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.BotonCuadre);
            this.Controls.Add(this.BotonComisiones);
            this.Controls.Add(this.BotonImpFac);
            this.Controls.Add(this.BotonFacturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(1108, 579);
            this.MinimumSize = new System.Drawing.Size(1108, 579);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Colors NailBar";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosYServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonFacturar;
        private System.Windows.Forms.Button BotonImpFac;
        private System.Windows.Forms.Button BotonComisiones;
        private System.Windows.Forms.Button BotonCuadre;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button BotonCierre;
        private System.Windows.Forms.TextBox Sub_total;
        private System.Windows.Forms.ComboBox CBServicios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEmpleados;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView Display;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GestionS;
        private System.Windows.Forms.Button GestionP;
        private ColorNailbarDataSet colorNailbarDataSet;
        private ColorNailbarDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private ColorNailbarDataSetTableAdapters.Productos_Y_ServiciosTableAdapter productos_Y_ServiciosTableAdapter;
        private ColorNailbarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private ColorNailbarDataSet colorNailbarDataSet1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private ColorNailbarDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter1;
        private System.Windows.Forms.BindingSource productosYServiciosBindingSource;
        private ColorNailbarDataSetTableAdapters.Productos_Y_ServiciosTableAdapter productos_Y_ServiciosTableAdapter1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ColorNailbarDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
    }
}

