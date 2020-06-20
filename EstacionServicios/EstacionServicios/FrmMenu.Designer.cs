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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnCorriente = new System.Windows.Forms.Button();
            this.BtnDiesel = new System.Windows.Forms.Button();
            this.BtnExtra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMontoSuper = new System.Windows.Forms.Label();
            this.lblLitrosSuper = new System.Windows.Forms.Label();
            this.lblOperacionesSuper = new System.Windows.Forms.Label();
            this.lblDisponibleSuper = new System.Windows.Forms.Label();
            this.lblCapacidadSuper = new System.Windows.Forms.Label();
            this.lblPlayeroSuper = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMontoPremiun = new System.Windows.Forms.Label();
            this.lblLitrosPremiun = new System.Windows.Forms.Label();
            this.lblOperacionesPremiun = new System.Windows.Forms.Label();
            this.lblDisponiblePremiun = new System.Windows.Forms.Label();
            this.lblCapacidadPremiun = new System.Windows.Forms.Label();
            this.lblPlayeroPremiun = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalGenMonto = new System.Windows.Forms.Label();
            this.lblTotalGenLitros = new System.Windows.Forms.Label();
            this.lblTotalOperaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCorriente
            // 
            this.btnCorriente.BackColor = System.Drawing.Color.Maroon;
            this.btnCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorriente.Location = new System.Drawing.Point(251, 119);
            this.btnCorriente.Name = "btnCorriente";
            this.btnCorriente.Size = new System.Drawing.Size(162, 53);
            this.btnCorriente.TabIndex = 0;
            this.btnCorriente.Text = "Super";
            this.btnCorriente.UseVisualStyleBackColor = false;
            this.btnCorriente.Click += new System.EventHandler(this.btnCorriente_Click);
            // 
            // BtnDiesel
            // 
            this.BtnDiesel.BackColor = System.Drawing.Color.Teal;
            this.BtnDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiesel.Location = new System.Drawing.Point(14, 118);
            this.BtnDiesel.Name = "BtnDiesel";
            this.BtnDiesel.Size = new System.Drawing.Size(181, 54);
            this.BtnDiesel.TabIndex = 1;
            this.BtnDiesel.Text = "Diesel";
            this.BtnDiesel.UseVisualStyleBackColor = false;
            this.BtnDiesel.Click += new System.EventHandler(this.BtnDiesel_Click);
            // 
            // BtnExtra
            // 
            this.BtnExtra.BackColor = System.Drawing.Color.Green;
            this.BtnExtra.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtra.Location = new System.Drawing.Point(462, 118);
            this.BtnExtra.Name = "BtnExtra";
            this.BtnExtra.Size = new System.Drawing.Size(184, 54);
            this.BtnExtra.TabIndex = 2;
            this.BtnExtra.Text = "Premiun";
            this.BtnExtra.UseVisualStyleBackColor = false;
            this.BtnExtra.Click += new System.EventHandler(this.BtnExtra_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblAdress);
            this.groupBox1.Controls.Add(this.lblCuit);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Estación";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(386, 74);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(152, 13);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "HORARIO DE ATENCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(386, 50);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "TELEFONO";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(23, 74);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(75, 13);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "DIRECCION";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(23, 50);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(36, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mistral", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Magenta;
            this.lblName.Location = new System.Drawing.Point(163, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "NOMBRE DE LA ESTACIÓN";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBox2.Location = new System.Drawing.Point(14, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diesel";
            // 
            // lblMontoDiesel
            // 
            this.lblMontoDiesel.AutoSize = true;
            this.lblMontoDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDiesel.ForeColor = System.Drawing.Color.Black;
            this.lblMontoDiesel.Location = new System.Drawing.Point(8, 137);
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
            this.lblLitrosDiesel.Location = new System.Drawing.Point(8, 117);
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
            this.lblOperacionesDiesel.Location = new System.Drawing.Point(8, 97);
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
            this.lblDisponibleDiesel.Location = new System.Drawing.Point(8, 69);
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
            this.lblCapacidadDiesel.Location = new System.Drawing.Point(8, 49);
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
            this.lblPlayeroDiesel.Location = new System.Drawing.Point(8, 29);
            this.lblPlayeroDiesel.Name = "lblPlayeroDiesel";
            this.lblPlayeroDiesel.Size = new System.Drawing.Size(85, 20);
            this.lblPlayeroDiesel.TabIndex = 0;
            this.lblPlayeroDiesel.Text = "PLAYERO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMontoSuper);
            this.groupBox3.Controls.Add(this.lblLitrosSuper);
            this.groupBox3.Controls.Add(this.lblOperacionesSuper);
            this.groupBox3.Controls.Add(this.lblDisponibleSuper);
            this.groupBox3.Controls.Add(this.lblCapacidadSuper);
            this.groupBox3.Controls.Add(this.lblPlayeroSuper);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(251, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 171);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Super";
            // 
            // lblMontoSuper
            // 
            this.lblMontoSuper.AutoSize = true;
            this.lblMontoSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSuper.ForeColor = System.Drawing.Color.Black;
            this.lblMontoSuper.Location = new System.Drawing.Point(8, 137);
            this.lblMontoSuper.Name = "lblMontoSuper";
            this.lblMontoSuper.Size = new System.Drawing.Size(120, 20);
            this.lblMontoSuper.TabIndex = 5;
            this.lblMontoSuper.Text = "MONTO TOTAL";
            // 
            // lblLitrosSuper
            // 
            this.lblLitrosSuper.AutoSize = true;
            this.lblLitrosSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitrosSuper.ForeColor = System.Drawing.Color.Black;
            this.lblLitrosSuper.Location = new System.Drawing.Point(8, 117);
            this.lblLitrosSuper.Name = "lblLitrosSuper";
            this.lblLitrosSuper.Size = new System.Drawing.Size(121, 20);
            this.lblLitrosSuper.TabIndex = 4;
            this.lblLitrosSuper.Text = "TOTAL LITROS";
            // 
            // lblOperacionesSuper
            // 
            this.lblOperacionesSuper.AutoSize = true;
            this.lblOperacionesSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionesSuper.ForeColor = System.Drawing.Color.Black;
            this.lblOperacionesSuper.Location = new System.Drawing.Point(8, 97);
            this.lblOperacionesSuper.Name = "lblOperacionesSuper";
            this.lblOperacionesSuper.Size = new System.Drawing.Size(126, 20);
            this.lblOperacionesSuper.TabIndex = 3;
            this.lblOperacionesSuper.Text = "OPERACIONES";
            // 
            // lblDisponibleSuper
            // 
            this.lblDisponibleSuper.AutoSize = true;
            this.lblDisponibleSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleSuper.ForeColor = System.Drawing.Color.Black;
            this.lblDisponibleSuper.Location = new System.Drawing.Point(8, 69);
            this.lblDisponibleSuper.Name = "lblDisponibleSuper";
            this.lblDisponibleSuper.Size = new System.Drawing.Size(106, 20);
            this.lblDisponibleSuper.TabIndex = 2;
            this.lblDisponibleSuper.Text = "DISPONIBLE";
            // 
            // lblCapacidadSuper
            // 
            this.lblCapacidadSuper.AutoSize = true;
            this.lblCapacidadSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadSuper.ForeColor = System.Drawing.Color.Black;
            this.lblCapacidadSuper.Location = new System.Drawing.Point(8, 49);
            this.lblCapacidadSuper.Name = "lblCapacidadSuper";
            this.lblCapacidadSuper.Size = new System.Drawing.Size(103, 20);
            this.lblCapacidadSuper.TabIndex = 1;
            this.lblCapacidadSuper.Text = "CAPACIDAD";
            // 
            // lblPlayeroSuper
            // 
            this.lblPlayeroSuper.AutoSize = true;
            this.lblPlayeroSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroSuper.ForeColor = System.Drawing.Color.Black;
            this.lblPlayeroSuper.Location = new System.Drawing.Point(8, 29);
            this.lblPlayeroSuper.Name = "lblPlayeroSuper";
            this.lblPlayeroSuper.Size = new System.Drawing.Size(85, 20);
            this.lblPlayeroSuper.TabIndex = 0;
            this.lblPlayeroSuper.Text = "PLAYERO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMontoPremiun);
            this.groupBox4.Controls.Add(this.lblLitrosPremiun);
            this.groupBox4.Controls.Add(this.lblOperacionesPremiun);
            this.groupBox4.Controls.Add(this.lblDisponiblePremiun);
            this.groupBox4.Controls.Add(this.lblCapacidadPremiun);
            this.groupBox4.Controls.Add(this.lblPlayeroPremiun);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(462, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 171);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Premiun";
            // 
            // lblMontoPremiun
            // 
            this.lblMontoPremiun.AutoSize = true;
            this.lblMontoPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPremiun.ForeColor = System.Drawing.Color.Black;
            this.lblMontoPremiun.Location = new System.Drawing.Point(8, 137);
            this.lblMontoPremiun.Name = "lblMontoPremiun";
            this.lblMontoPremiun.Size = new System.Drawing.Size(120, 20);
            this.lblMontoPremiun.TabIndex = 5;
            this.lblMontoPremiun.Text = "MONTO TOTAL";
            // 
            // lblLitrosPremiun
            // 
            this.lblLitrosPremiun.AutoSize = true;
            this.lblLitrosPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitrosPremiun.ForeColor = System.Drawing.Color.Black;
            this.lblLitrosPremiun.Location = new System.Drawing.Point(8, 117);
            this.lblLitrosPremiun.Name = "lblLitrosPremiun";
            this.lblLitrosPremiun.Size = new System.Drawing.Size(121, 20);
            this.lblLitrosPremiun.TabIndex = 4;
            this.lblLitrosPremiun.Text = "TOTAL LITROS";
            // 
            // lblOperacionesPremiun
            // 
            this.lblOperacionesPremiun.AutoSize = true;
            this.lblOperacionesPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacionesPremiun.ForeColor = System.Drawing.Color.Black;
            this.lblOperacionesPremiun.Location = new System.Drawing.Point(8, 97);
            this.lblOperacionesPremiun.Name = "lblOperacionesPremiun";
            this.lblOperacionesPremiun.Size = new System.Drawing.Size(126, 20);
            this.lblOperacionesPremiun.TabIndex = 3;
            this.lblOperacionesPremiun.Text = "OPERACIONES";
            // 
            // lblDisponiblePremiun
            // 
            this.lblDisponiblePremiun.AutoSize = true;
            this.lblDisponiblePremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponiblePremiun.ForeColor = System.Drawing.Color.Black;
            this.lblDisponiblePremiun.Location = new System.Drawing.Point(8, 69);
            this.lblDisponiblePremiun.Name = "lblDisponiblePremiun";
            this.lblDisponiblePremiun.Size = new System.Drawing.Size(106, 20);
            this.lblDisponiblePremiun.TabIndex = 2;
            this.lblDisponiblePremiun.Text = "DISPONIBLE";
            // 
            // lblCapacidadPremiun
            // 
            this.lblCapacidadPremiun.AutoSize = true;
            this.lblCapacidadPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadPremiun.ForeColor = System.Drawing.Color.Black;
            this.lblCapacidadPremiun.Location = new System.Drawing.Point(8, 49);
            this.lblCapacidadPremiun.Name = "lblCapacidadPremiun";
            this.lblCapacidadPremiun.Size = new System.Drawing.Size(103, 20);
            this.lblCapacidadPremiun.TabIndex = 1;
            this.lblCapacidadPremiun.Text = "CAPACIDAD";
            // 
            // lblPlayeroPremiun
            // 
            this.lblPlayeroPremiun.AutoSize = true;
            this.lblPlayeroPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroPremiun.ForeColor = System.Drawing.Color.Black;
            this.lblPlayeroPremiun.Location = new System.Drawing.Point(8, 29);
            this.lblPlayeroPremiun.Name = "lblPlayeroPremiun";
            this.lblPlayeroPremiun.Size = new System.Drawing.Size(85, 20);
            this.lblPlayeroPremiun.TabIndex = 0;
            this.lblPlayeroPremiun.Text = "PLAYERO";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalGenMonto);
            this.groupBox5.Controls.Add(this.lblTotalGenLitros);
            this.groupBox5.Controls.Add(this.lblTotalOperaciones);
            this.groupBox5.Location = new System.Drawing.Point(125, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TOTAL GENERAL";
            // 
            // lblTotalGenMonto
            // 
            this.lblTotalGenMonto.AutoSize = true;
            this.lblTotalGenMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGenMonto.ForeColor = System.Drawing.Color.Black;
            this.lblTotalGenMonto.Location = new System.Drawing.Point(160, 56);
            this.lblTotalGenMonto.Name = "lblTotalGenMonto";
            this.lblTotalGenMonto.Size = new System.Drawing.Size(120, 20);
            this.lblTotalGenMonto.TabIndex = 8;
            this.lblTotalGenMonto.Text = "MONTO TOTAL";
            // 
            // lblTotalGenLitros
            // 
            this.lblTotalGenLitros.AutoSize = true;
            this.lblTotalGenLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGenLitros.ForeColor = System.Drawing.Color.Black;
            this.lblTotalGenLitros.Location = new System.Drawing.Point(160, 36);
            this.lblTotalGenLitros.Name = "lblTotalGenLitros";
            this.lblTotalGenLitros.Size = new System.Drawing.Size(121, 20);
            this.lblTotalGenLitros.TabIndex = 7;
            this.lblTotalGenLitros.Text = "TOTAL LITROS";
            // 
            // lblTotalOperaciones
            // 
            this.lblTotalOperaciones.AutoSize = true;
            this.lblTotalOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperaciones.ForeColor = System.Drawing.Color.Black;
            this.lblTotalOperaciones.Location = new System.Drawing.Point(160, 16);
            this.lblTotalOperaciones.Name = "lblTotalOperaciones";
            this.lblTotalOperaciones.Size = new System.Drawing.Size(137, 20);
            this.lblTotalOperaciones.TabIndex = 6;
            this.lblTotalOperaciones.Text = "OPERACIONES";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 477);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExtra);
            this.Controls.Add(this.BtnDiesel);
            this.Controls.Add(this.btnCorriente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estación de Servicios JulissaJ";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMontoSuper;
        private System.Windows.Forms.Label lblLitrosSuper;
        private System.Windows.Forms.Label lblOperacionesSuper;
        private System.Windows.Forms.Label lblDisponibleSuper;
        private System.Windows.Forms.Label lblCapacidadSuper;
        private System.Windows.Forms.Label lblPlayeroSuper;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMontoPremiun;
        private System.Windows.Forms.Label lblLitrosPremiun;
        private System.Windows.Forms.Label lblOperacionesPremiun;
        private System.Windows.Forms.Label lblDisponiblePremiun;
        private System.Windows.Forms.Label lblCapacidadPremiun;
        private System.Windows.Forms.Label lblPlayeroPremiun;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalGenMonto;
        private System.Windows.Forms.Label lblTotalGenLitros;
        private System.Windows.Forms.Label lblTotalOperaciones;
    }
}

