namespace ColorNails
{
    partial class Cuadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadre));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorNailbarDataSet = new ColorNails.ColorNailbarDataSet();
            this.cuadreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cuadreTableAdapter = new ColorNails.ColorNailbarDataSetTableAdapters.CuadreTableAdapter();
            this.efectivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton = new System.Windows.Forms.Button();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.efectivoDataGridViewTextBoxColumn,
            this.tarjetaDataGridViewTextBoxColumn,
            this.transferenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuadreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(411, 46);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // colorNailbarDataSet
            // 
            this.colorNailbarDataSet.DataSetName = "ColorNailbarDataSet";
            this.colorNailbarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuadreBindingSource
            // 
            this.cuadreBindingSource.DataMember = "Cuadre";
            this.cuadreBindingSource.DataSource = this.colorNailbarDataSet;
            // 
            // cuadreTableAdapter
            // 
            this.cuadreTableAdapter.ClearBeforeFill = true;
            // 
            // efectivoDataGridViewTextBoxColumn
            // 
            this.efectivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.efectivoDataGridViewTextBoxColumn.DataPropertyName = "Efectivo";
            this.efectivoDataGridViewTextBoxColumn.HeaderText = "Efectivo";
            this.efectivoDataGridViewTextBoxColumn.Name = "efectivoDataGridViewTextBoxColumn";
            this.efectivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarjetaDataGridViewTextBoxColumn
            // 
            this.tarjetaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarjetaDataGridViewTextBoxColumn.DataPropertyName = "Tarjeta";
            this.tarjetaDataGridViewTextBoxColumn.HeaderText = "Tarjeta";
            this.tarjetaDataGridViewTextBoxColumn.Name = "tarjetaDataGridViewTextBoxColumn";
            this.tarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transferenciaDataGridViewTextBoxColumn
            // 
            this.transferenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transferenciaDataGridViewTextBoxColumn.DataPropertyName = "Transferencia";
            this.transferenciaDataGridViewTextBoxColumn.HeaderText = "Transferencia";
            this.transferenciaDataGridViewTextBoxColumn.Name = "transferenciaDataGridViewTextBoxColumn";
            this.transferenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Boton
            // 
            this.Boton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Boton.Location = new System.Drawing.Point(334, 68);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(88, 23);
            this.Boton.TabIndex = 1;
            this.Boton.Text = "OK";
            this.Boton.UseVisualStyleBackColor = true;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(143, 68);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(94, 20);
            this.Txt_Total.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total : ";
            // 
            // Cuadre
            // 
            this.AcceptButton = this.Boton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.CancelButton = this.Boton;
            this.ClientSize = new System.Drawing.Size(434, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 142);
            this.MinimumSize = new System.Drawing.Size(450, 142);
            this.Name = "Cuadre";
            this.Text = "Cuadre";
            this.Load += new System.EventHandler(this.Cuadre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorNailbarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ColorNailbarDataSet colorNailbarDataSet;
        private System.Windows.Forms.BindingSource cuadreBindingSource;
        private ColorNailbarDataSetTableAdapters.CuadreTableAdapter cuadreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn efectivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Boton;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label1;
    }
}