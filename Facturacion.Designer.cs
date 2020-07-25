namespace ColorNails
{
    partial class Facturacion
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
            this.BotonFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Efectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Transferencia = new System.Windows.Forms.TextBox();
            this.Txt_Tarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Comprobacion = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotonFacturar
            // 
            this.BotonFacturar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.BotonFacturar.ForeColor = System.Drawing.Color.Black;
            this.BotonFacturar.Location = new System.Drawing.Point(293, 226);
            this.BotonFacturar.Name = "BotonFacturar";
            this.BotonFacturar.Size = new System.Drawing.Size(110, 37);
            this.BotonFacturar.TabIndex = 4;
            this.BotonFacturar.Text = "Facturar";
            this.BotonFacturar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Efectivo";
            this.label1.UseMnemonic = false;
            // 
            // Txt_Efectivo
            // 
            this.Txt_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Efectivo.Location = new System.Drawing.Point(159, 9);
            this.Txt_Efectivo.Name = "Txt_Efectivo";
            this.Txt_Efectivo.Size = new System.Drawing.Size(100, 29);
            this.Txt_Efectivo.TabIndex = 1;
            this.Txt_Efectivo.Text = "0";
            this.Txt_Efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Efectivo.TextChanged += new System.EventHandler(this.Cambio);
            this.Txt_Efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarjeta";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transferencia";
            this.label3.UseMnemonic = false;
            // 
            // Txt_Transferencia
            // 
            this.Txt_Transferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Transferencia.Location = new System.Drawing.Point(159, 132);
            this.Txt_Transferencia.Name = "Txt_Transferencia";
            this.Txt_Transferencia.Size = new System.Drawing.Size(100, 29);
            this.Txt_Transferencia.TabIndex = 3;
            this.Txt_Transferencia.Text = "0";
            this.Txt_Transferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Transferencia.TextChanged += new System.EventHandler(this.Cambio);
            this.Txt_Transferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // Txt_Tarjeta
            // 
            this.Txt_Tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tarjeta.Location = new System.Drawing.Point(159, 71);
            this.Txt_Tarjeta.Name = "Txt_Tarjeta";
            this.Txt_Tarjeta.Size = new System.Drawing.Size(100, 29);
            this.Txt_Tarjeta.TabIndex = 2;
            this.Txt_Tarjeta.Text = "0";
            this.Txt_Tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Tarjeta.TextChanged += new System.EventHandler(this.Cambio);
            this.Txt_Tarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(157, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sumatoria";
            this.label5.UseMnemonic = false;
            // 
            // Txt_Comprobacion
            // 
            this.Txt_Comprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Comprobacion.Location = new System.Drawing.Point(159, 226);
            this.Txt_Comprobacion.Name = "Txt_Comprobacion";
            this.Txt_Comprobacion.ReadOnly = true;
            this.Txt_Comprobacion.Size = new System.Drawing.Size(100, 29);
            this.Txt_Comprobacion.TabIndex = 10;
            this.Txt_Comprobacion.TabStop = false;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(13, 226);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(100, 29);
            this.Txt_Total.TabIndex = 0;
            this.Txt_Total.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(159, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 11;
            this.textBox1.TabStop = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(415, 304);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Txt_Comprobacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Tarjeta);
            this.Controls.Add(this.Txt_Transferencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Efectivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonFacturar);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(431, 343);
            this.MinimumSize = new System.Drawing.Size(431, 343);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Efectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Transferencia;
        private System.Windows.Forms.TextBox Txt_Tarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Comprobacion;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox textBox1;
    }
}