namespace NDF
{
    partial class frmNextDate
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDia2 = new System.Windows.Forms.TextBox();
            this.txtMes2 = new System.Windows.Forms.TextBox();
            this.txtAño2 = new System.Windows.Forms.TextBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.txtDia1 = new System.Windows.Forms.TextBox();
            this.txtMes1 = new System.Windows.Forms.TextBox();
            this.txtAño1 = new System.Windows.Forms.TextBox();
            this.lblDia1 = new System.Windows.Forms.Label();
            this.lblMes1 = new System.Windows.Forms.Label();
            this.lblAño1 = new System.Windows.Forms.Label();
            this.lblDia2 = new System.Windows.Forms.Label();
            this.lblMes2 = new System.Windows.Forms.Label();
            this.lblAño2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBisiesto = new System.Windows.Forms.TextBox();
            this.lblIndicadorBisiesto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Escriba La Fecha:";
            // 
            // txtDia2
            // 
            this.txtDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia2.Location = new System.Drawing.Point(109, 281);
            this.txtDia2.Name = "txtDia2";
            this.txtDia2.ReadOnly = true;
            this.txtDia2.Size = new System.Drawing.Size(47, 30);
            this.txtDia2.TabIndex = 4;
            // 
            // txtMes2
            // 
            this.txtMes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes2.Location = new System.Drawing.Point(174, 281);
            this.txtMes2.Name = "txtMes2";
            this.txtMes2.ReadOnly = true;
            this.txtMes2.Size = new System.Drawing.Size(66, 30);
            this.txtMes2.TabIndex = 5;
            // 
            // txtAño2
            // 
            this.txtAño2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño2.Location = new System.Drawing.Point(257, 281);
            this.txtAño2.Name = "txtAño2";
            this.txtAño2.ReadOnly = true;
            this.txtAño2.Size = new System.Drawing.Size(58, 30);
            this.txtAño2.TabIndex = 6;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(41, 222);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(213, 25);
            this.lblTitulo2.TabIndex = 7;
            this.lblTitulo2.Text = "La Siguiente Fecha es:";
            // 
            // txtDia1
            // 
            this.txtDia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia1.Location = new System.Drawing.Point(109, 110);
            this.txtDia1.Name = "txtDia1";
            this.txtDia1.Size = new System.Drawing.Size(55, 30);
            this.txtDia1.TabIndex = 8;
            this.txtDia1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtMes1
            // 
            this.txtMes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes1.Location = new System.Drawing.Point(174, 110);
            this.txtMes1.Name = "txtMes1";
            this.txtMes1.Size = new System.Drawing.Size(66, 30);
            this.txtMes1.TabIndex = 9;
            this.txtMes1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // txtAño1
            // 
            this.txtAño1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño1.Location = new System.Drawing.Point(257, 110);
            this.txtAño1.Name = "txtAño1";
            this.txtAño1.Size = new System.Drawing.Size(58, 30);
            this.txtAño1.TabIndex = 10;
            this.txtAño1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // lblDia1
            // 
            this.lblDia1.AutoSize = true;
            this.lblDia1.Location = new System.Drawing.Point(110, 90);
            this.lblDia1.Name = "lblDia1";
            this.lblDia1.Size = new System.Drawing.Size(29, 17);
            this.lblDia1.TabIndex = 11;
            this.lblDia1.Text = "Dia";
            // 
            // lblMes1
            // 
            this.lblMes1.AutoSize = true;
            this.lblMes1.Location = new System.Drawing.Point(180, 90);
            this.lblMes1.Name = "lblMes1";
            this.lblMes1.Size = new System.Drawing.Size(34, 17);
            this.lblMes1.TabIndex = 12;
            this.lblMes1.Text = "Mes";
            // 
            // lblAño1
            // 
            this.lblAño1.AutoSize = true;
            this.lblAño1.Location = new System.Drawing.Point(254, 90);
            this.lblAño1.Name = "lblAño1";
            this.lblAño1.Size = new System.Drawing.Size(33, 17);
            this.lblAño1.TabIndex = 13;
            this.lblAño1.Text = "Año";
            // 
            // lblDia2
            // 
            this.lblDia2.AutoSize = true;
            this.lblDia2.Location = new System.Drawing.Point(110, 261);
            this.lblDia2.Name = "lblDia2";
            this.lblDia2.Size = new System.Drawing.Size(29, 17);
            this.lblDia2.TabIndex = 14;
            this.lblDia2.Text = "Dia";
            // 
            // lblMes2
            // 
            this.lblMes2.AutoSize = true;
            this.lblMes2.Location = new System.Drawing.Point(180, 261);
            this.lblMes2.Name = "lblMes2";
            this.lblMes2.Size = new System.Drawing.Size(34, 17);
            this.lblMes2.TabIndex = 15;
            this.lblMes2.Text = "Mes";
            // 
            // lblAño2
            // 
            this.lblAño2.AutoSize = true;
            this.lblAño2.Location = new System.Drawing.Point(254, 261);
            this.lblAño2.Name = "lblAño2";
            this.lblAño2.Size = new System.Drawing.Size(33, 17);
            this.lblAño2.TabIndex = 16;
            this.lblAño2.Text = "Año";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(167, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 23);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtBisiesto
            // 
            this.txtBisiesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBisiesto.Location = new System.Drawing.Point(182, 332);
            this.txtBisiesto.Name = "txtBisiesto";
            this.txtBisiesto.ReadOnly = true;
            this.txtBisiesto.Size = new System.Drawing.Size(58, 30);
            this.txtBisiesto.TabIndex = 18;
            // 
            // lblIndicadorBisiesto
            // 
            this.lblIndicadorBisiesto.AutoSize = true;
            this.lblIndicadorBisiesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicadorBisiesto.Location = new System.Drawing.Point(80, 337);
            this.lblIndicadorBisiesto.Name = "lblIndicadorBisiesto";
            this.lblIndicadorBisiesto.Size = new System.Drawing.Size(84, 24);
            this.lblIndicadorBisiesto.TabIndex = 19;
            this.lblIndicadorBisiesto.Text = "Bisiesto?";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(308, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // frmNextDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 400);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblIndicadorBisiesto);
            this.Controls.Add(this.txtBisiesto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAño2);
            this.Controls.Add(this.lblMes2);
            this.Controls.Add(this.lblDia2);
            this.Controls.Add(this.lblAño1);
            this.Controls.Add(this.lblMes1);
            this.Controls.Add(this.lblDia1);
            this.Controls.Add(this.txtAño1);
            this.Controls.Add(this.txtMes1);
            this.Controls.Add(this.txtDia1);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.txtAño2);
            this.Controls.Add(this.txtMes2);
            this.Controls.Add(this.txtDia2);
            this.Controls.Add(this.lblTitulo);
            this.MinimizeBox = false;
            this.Name = "frmNextDate";
            this.Text = "Next Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDia2;
        private System.Windows.Forms.TextBox txtMes2;
        private System.Windows.Forms.TextBox txtAño2;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TextBox txtDia1;
        private System.Windows.Forms.TextBox txtMes1;
        private System.Windows.Forms.TextBox txtAño1;
        private System.Windows.Forms.Label lblDia1;
        private System.Windows.Forms.Label lblMes1;
        private System.Windows.Forms.Label lblAño1;
        private System.Windows.Forms.Label lblDia2;
        private System.Windows.Forms.Label lblMes2;
        private System.Windows.Forms.Label lblAño2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBisiesto;
        private System.Windows.Forms.Label lblIndicadorBisiesto;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

