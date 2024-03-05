namespace CalculadoraDescuentos
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom_Producto1 = new System.Windows.Forms.TextBox();
            this.txtPrecio_Producto1 = new System.Windows.Forms.TextBox();
            this.txtCant_Producto1 = new System.Windows.Forms.TextBox();
            this.txtCant_Producto2 = new System.Windows.Forms.TextBox();
            this.txtPrecio_Producto2 = new System.Windows.Forms.TextBox();
            this.txtNom_Producto2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCupon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calculadora de Descuentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad del Producto";
            // 
            // txtNom_Producto1
            // 
            this.txtNom_Producto1.Location = new System.Drawing.Point(210, 108);
            this.txtNom_Producto1.Name = "txtNom_Producto1";
            this.txtNom_Producto1.Size = new System.Drawing.Size(157, 22);
            this.txtNom_Producto1.TabIndex = 5;
            // 
            // txtPrecio_Producto1
            // 
            this.txtPrecio_Producto1.Location = new System.Drawing.Point(210, 164);
            this.txtPrecio_Producto1.Name = "txtPrecio_Producto1";
            this.txtPrecio_Producto1.Size = new System.Drawing.Size(157, 22);
            this.txtPrecio_Producto1.TabIndex = 6;
            // 
            // txtCant_Producto1
            // 
            this.txtCant_Producto1.Location = new System.Drawing.Point(210, 218);
            this.txtCant_Producto1.Name = "txtCant_Producto1";
            this.txtCant_Producto1.Size = new System.Drawing.Size(157, 22);
            this.txtCant_Producto1.TabIndex = 7;
            // 
            // txtCant_Producto2
            // 
            this.txtCant_Producto2.Location = new System.Drawing.Point(569, 221);
            this.txtCant_Producto2.Name = "txtCant_Producto2";
            this.txtCant_Producto2.Size = new System.Drawing.Size(157, 22);
            this.txtCant_Producto2.TabIndex = 8;
            // 
            // txtPrecio_Producto2
            // 
            this.txtPrecio_Producto2.Location = new System.Drawing.Point(569, 164);
            this.txtPrecio_Producto2.Name = "txtPrecio_Producto2";
            this.txtPrecio_Producto2.Size = new System.Drawing.Size(157, 22);
            this.txtPrecio_Producto2.TabIndex = 9;
            // 
            // txtNom_Producto2
            // 
            this.txtNom_Producto2.Location = new System.Drawing.Point(569, 108);
            this.txtNom_Producto2.Name = "txtNom_Producto2";
            this.txtNom_Producto2.Size = new System.Drawing.Size(157, 22);
            this.txtNom_Producto2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre del Producto 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio del Producto 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad del Producto 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cupón";
            // 
            // txtCupon
            // 
            this.txtCupon.Location = new System.Drawing.Point(569, 296);
            this.txtCupon.Name = "txtCupon";
            this.txtCupon.Size = new System.Drawing.Size(157, 22);
            this.txtCupon.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCupon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNom_Producto2);
            this.Controls.Add(this.txtPrecio_Producto2);
            this.Controls.Add(this.txtCant_Producto2);
            this.Controls.Add(this.txtCant_Producto1);
            this.Controls.Add(this.txtPrecio_Producto1);
            this.Controls.Add(this.txtNom_Producto1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom_Producto1;
        private System.Windows.Forms.TextBox txtPrecio_Producto1;
        private System.Windows.Forms.TextBox txtCant_Producto1;
        private System.Windows.Forms.TextBox txtCant_Producto2;
        private System.Windows.Forms.TextBox txtPrecio_Producto2;
        private System.Windows.Forms.TextBox txtNom_Producto2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCupon;
    }
}

