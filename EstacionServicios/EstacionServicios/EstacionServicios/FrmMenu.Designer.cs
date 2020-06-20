namespace EstacionServicios
{
    partial class FrmMenu
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
            this.btnCorriente = new System.Windows.Forms.Button();
            this.BtnDiesel = new System.Windows.Forms.Button();
            this.BtnExtra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMontoDiesel = new System.Windows.Forms.Label();
            this.lblLitrosDiesel = new System.Windows.Forms.Label();
            this.lblOperacionesDiesel = new System.Windows.Forms.Label();
            this.lblDisponibleDiesel = new System.Windows.Forms.Label();
            this.lblCapacidadDiesel = new System.Windows.Forms.Label();
            this.lblPlayeroDiesel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCorriente
            // 
            this.btnCorriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorriente.Location = new System.Drawing.Point(215, 119);
            this.btnCorriente.Name = "btnCorriente";
            this.btnCorriente.Size = new System.Drawing.Size(139, 53);
            this.btnCorriente.TabIndex = 0;
            this.btnCorriente.Text = "Super";
            this.btnCorriente.UseVisualStyleBackColor = false;
            this.btnCorriente.Click += new System.EventHandler(this.btnCorriente_Click);
            // 
            // BtnDiesel
            // 
            this.BtnDiesel.BackColor = System.Drawing.Color.Teal;
            this.BtnDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiesel.Location = new System.Drawing.Point(12, 118);
            this.BtnDiesel.Name = "BtnDiesel";
            this.BtnDiesel.Size = new System.Drawing.Size(155, 54);
            this.BtnDiesel.TabIndex = 1;
            this.BtnDiesel.Text = "Diesel";
            this.BtnDiesel.UseVisualStyleBackColor = false;
            this.BtnDiesel.Click += new System.EventHandler(this.BtnDiesel_Click);
            // 
            // BtnExtra
            // 
            this.BtnExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnExtra.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtra.Location = new System.Drawing.Point(396, 118);
            this.BtnExtra.Name = "BtnExtra";
            this.BtnExtra.Size = new System.Drawing.Size(158, 54);
            this.BtnExtra.TabIndex = 2;
            this.BtnExtra.Text = "Premiun";
            this.BtnExtra.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdress);
            this.groupBox1.Controls.Add(this.lblCuit);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Estación";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(20, 74);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(66, 13);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "DIRECCION";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(20, 50);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NOMBRE DE LA ESTACIÓN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMontoDiesel);
            this.groupBox2.Controls.Add(this.lblLitrosDiesel);
            this.groupBox2.Controls.Add(this.lblOperacionesDiesel);
            this.groupBox2.Controls.Add(this.lblDisponibleDiesel);
            this.groupBox2.Controls.Add(this.lblCapacidadDiesel);
            this.groupBox2.Controls.Add(this.lblPlayeroDiesel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diesel";
            // 
            // lblMontoDiesel
            // 
            this.lblMontoDiesel.AutoSize = true;
            this.lblMontoDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblMontoDiesel.Location = new System.Drawing.Point(7, 137);
            this.lblMontoDiesel.Name = "lblMontoDiesel";
            this.lblMontoDiesel.Size = new System.Drawing.Size(120, 20);
            this.lblMontoDiesel.TabIndex = 5;
            this.lblMontoDiesel.Text = "MONTO TOTAL";
            // 
            // lblLitrosDiesel
            // 
            this.lblLitrosDiesel.AutoSize = true;
            this.lblLitrosDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitrosDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblLitrosDiesel.Location = new System.Drawing.Point(7, 117);
            this.lblLitrosDiesel.Name = "lblLitrosDiesel";
            this.lblLitrosDiesel.Size = new System.Drawing.Size(121, 20);
            this.lblLitrosDiesel.TabIndex = 4;
            this.lblLitrosDiesel.Text = "TOTAL LITROS";
            // 
            // lblOperacionesDiesel
            // 
            this.lblOperacionesDiesel.AutoSize = true;
            this.lblOperacionesDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionesDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblOperacionesDiesel.Location = new System.Drawing.Point(7, 97);
            this.lblOperacionesDiesel.Name = "lblOperacionesDiesel";
            this.lblOperacionesDiesel.Size = new System.Drawing.Size(126, 20);
            this.lblOperacionesDiesel.TabIndex = 3;
            this.lblOperacionesDiesel.Text = "OPERACIONES";
            // 
            // lblDisponibleDiesel
            // 
            this.lblDisponibleDiesel.AutoSize = true;
            this.lblDisponibleDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblDisponibleDiesel.Location = new System.Drawing.Point(7, 69);
            this.lblDisponibleDiesel.Name = "lblDisponibleDiesel";
            this.lblDisponibleDiesel.Size = new System.Drawing.Size(106, 20);
            this.lblDisponibleDiesel.TabIndex = 2;
            this.lblDisponibleDiesel.Text = "DISPONIBLE";
            // 
            // lblCapacidadDiesel
            // 
            this.lblCapacidadDiesel.AutoSize = true;
            this.lblCapacidadDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblCapacidadDiesel.Location = new System.Drawing.Point(7, 49);
            this.lblCapacidadDiesel.Name = "lblCapacidadDiesel";
            this.lblCapacidadDiesel.Size = new System.Drawing.Size(103, 20);
            this.lblCapacidadDiesel.TabIndex = 1;
            this.lblCapacidadDiesel.Text = "CAPACIDAD";
            // 
            // lblPlayeroDiesel
            // 
            this.lblPlayeroDiesel.AutoSize = true;
            this.lblPlayeroDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblPlayeroDiesel.Location = new System.Drawing.Point(7, 29);
            this.lblPlayeroDiesel.Name = "lblPlayeroDiesel";
            this.lblPlayeroDiesel.Size = new System.Drawing.Size(85, 20);
            this.lblPlayeroDiesel.TabIndex = 0;
            this.lblPlayeroDiesel.Text = "PLAYERO";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExtra);
            this.Controls.Add(this.BtnDiesel);
            this.Controls.Add(this.btnCorriente);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototipo para una Estación de Servicios";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorriente;
        private System.Windows.Forms.Button BtnDiesel;
        private System.Windows.Forms.Button BtnExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMontoDiesel;
        private System.Windows.Forms.Label lblLitrosDiesel;
        private System.Windows.Forms.Label lblOperacionesDiesel;
        private System.Windows.Forms.Label lblDisponibleDiesel;
        private System.Windows.Forms.Label lblCapacidadDiesel;
        private System.Windows.Forms.Label lblPlayeroDiesel;
    }
}

