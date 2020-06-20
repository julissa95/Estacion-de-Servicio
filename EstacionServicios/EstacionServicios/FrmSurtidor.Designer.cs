namespace EstacionServicios
{
    partial class FrmSurtidor
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
            this.lblTipoCombustible = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.NumericUpDown();
            this.btnSurtir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCombustible
            // 
            this.lblTipoCombustible.AutoSize = true;
            this.lblTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustible.Location = new System.Drawing.Point(151, 22);
            this.lblTipoCombustible.Name = "lblTipoCombustible";
            this.lblTipoCombustible.Size = new System.Drawing.Size(153, 16);
            this.lblTipoCombustible.TabIndex = 0;
            this.lblTipoCombustible.Text = "TIPO DE COMBUSTIBLE";
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(168, 133);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(120, 20);
            this.txtLitros.TabIndex = 1;
            // 
            // btnSurtir
            // 
            this.btnSurtir.BackColor = System.Drawing.Color.Green;
            this.btnSurtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurtir.Location = new System.Drawing.Point(138, 200);
            this.btnSurtir.Name = "btnSurtir";
            this.btnSurtir.Size = new System.Drawing.Size(82, 36);
            this.btnSurtir.TabIndex = 2;
            this.btnSurtir.Text = "Surtir";
            this.btnSurtir.UseVisualStyleBackColor = false;
            this.btnSurtir.Click += new System.EventHandler(this.btnSurtir_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(226, 200);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(103, 36);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(403, 299);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(138, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(191, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(179, 103);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(100, 16);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "PRECIO: 0,00";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(164, 167);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(138, 24);
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "MONTO: 0,00";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(196, 64);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(71, 13);
            this.lblDisponible.TabIndex = 8;
            this.lblDisponible.Text = "DISPONIBLE";
            // 
            // FrmSurtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 334);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSurtir);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblTipoCombustible);
            this.Name = "FrmSurtidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSurtidor";
            ((System.ComponentModel.ISupportInitialize)(this.txtLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCombustible;
        private System.Windows.Forms.NumericUpDown txtLitros;
        private System.Windows.Forms.Button btnSurtir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblDisponible;
    }
}