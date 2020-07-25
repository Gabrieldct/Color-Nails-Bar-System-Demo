namespace ColorNails
{
    partial class Comision
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comision));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaNetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorNailbarDataSet = new ColorNails.ColorNailbarDataSet();
            this.comisionesTableAdapter = new ColorNails.ColorNailbarDataSetTableAdapters.ComisionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoDataGridViewTextBoxColumn,
            this.entradaNetaDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comisionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(366, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            // 
            // entradaNetaDataGridViewTextBoxColumn
            // 
            this.entradaNetaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.entradaNetaDataGridViewTextBoxColumn.DataPropertyName = "Entrada Neta";
            dataGridViewCellStyle1.Format = "N2";
            this.entradaNetaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.entradaNetaDataGridViewTextBoxColumn.HeaderText = "Entrada Neta";
            this.entradaNetaDataGridViewTextBoxColumn.Name = "entradaNetaDataGridViewTextBoxColumn";
            this.entradaNetaDataGridViewTextBoxColumn.Width = 95;
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "Comision";
            dataGridViewCellStyle2.Format = "N2";
            this.comisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            this.comisionDataGridViewTextBoxColumn.Width = 74;
            // 
            // comisionesBindingSource
            // 
            this.comisionesBindingSource.DataMember = "Comisiones";
            this.comisionesBindingSource.DataSource = this.colorNailbarDataSet;
            // 
            // colorNailbarDataSet
            // 
            this.colorNailbarDataSet.DataSetName = "ColorNailbarDataSet";
            this.colorNailbarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comisionesTableAdapter
            // 
            this.comisionesTableAdapter.ClearBeforeFill = true;
            // 
            // Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(390, 325);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(406, 364);
            this.MinimumSize = new System.Drawing.Size(406, 364);
            this.Name = "Comision";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ColorNailbarDataSet colorNailbarDataSet;
        private System.Windows.Forms.BindingSource comisionesBindingSource;
        private ColorNailbarDataSetTableAdapters.ComisionesTableAdapter comisionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaNetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
    }
}