
namespace SGClubRaquetaAlvaroMerino
{
    partial class frmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mktCuenta = new System.Windows.Forms.MaskedTextBox();
            this.mktTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.nupdMinutos = new System.Windows.Forms.NumericUpDown();
            this.nupdHora = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPista = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.pistasPorReservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new SGClubRaquetaAlvaroMerino.dsBD();
            this.sociosTableAdapter = new SGClubRaquetaAlvaroMerino.dsBDTableAdapters.sociosTableAdapter();
            this.pistasPorReservaTableAdapter = new SGClubRaquetaAlvaroMerino.dsBDTableAdapters.PistasPorReservaTableAdapter();
            this.pistasTableAdapter = new SGClubRaquetaAlvaroMerino.dsBDTableAdapters.pistasTableAdapter();
            this.reservasTableAdapter = new SGClubRaquetaAlvaroMerino.dsBDTableAdapters.reservasTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHora)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasPorReservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige al Socio : ";
            // 
            // cmbSocio
            // 
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(98, 6);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(186, 21);
            this.cmbSocio.TabIndex = 1;
            this.cmbSocio.SelectedIndexChanged += new System.EventHandler(this.cmbSocio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI Socio: ";
            // 
            // lblDniSocio
            // 
            this.lblDniSocio.AutoSize = true;
            this.lblDniSocio.Location = new System.Drawing.Point(485, 9);
            this.lblDniSocio.Name = "lblDniSocio";
            this.lblDniSocio.Size = new System.Drawing.Size(70, 13);
            this.lblDniSocio.TabIndex = 3;
            this.lblDniSocio.Text = "Dni del Socio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.mktCuenta);
            this.panel1.Controls.Add(this.mktTelefono);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 100);
            this.panel1.TabIndex = 4;
            // 
            // mktCuenta
            // 
            this.mktCuenta.Enabled = false;
            this.mktCuenta.Location = new System.Drawing.Point(463, 37);
            this.mktCuenta.Mask = "ES00-0000-0000-0000-0000-0000";
            this.mktCuenta.Name = "mktCuenta";
            this.mktCuenta.ReadOnly = true;
            this.mktCuenta.Size = new System.Drawing.Size(286, 20);
            this.mktCuenta.TabIndex = 10;
            // 
            // mktTelefono
            // 
            this.mktTelefono.Enabled = false;
            this.mktTelefono.Location = new System.Drawing.Point(83, 67);
            this.mktTelefono.Mask = "000-000-000";
            this.mktTelefono.Name = "mktTelefono";
            this.mktTelefono.ReadOnly = true;
            this.mktTelefono.Size = new System.Drawing.Size(290, 20);
            this.mktTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(463, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(463, 9);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(286, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(83, 41);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(290, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(83, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "CCC: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellidos: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pcbImagen);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnReservar);
            this.panel2.Controls.Add(this.nupdMinutos);
            this.panel2.Controls.Add(this.nupdHora);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbPista);
            this.panel2.Location = new System.Drawing.Point(15, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 147);
            this.panel2.TabIndex = 5;
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(463, 14);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(286, 92);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 10;
            this.pcbImagen.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Duración: 1h 30 minutos";
            // 
            // btnReservar
            // 
            this.btnReservar.Enabled = false;
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(330, 107);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(96, 37);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // nupdMinutos
            // 
            this.nupdMinutos.Enabled = false;
            this.nupdMinutos.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupdMinutos.Location = new System.Drawing.Point(151, 86);
            this.nupdMinutos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupdMinutos.Name = "nupdMinutos";
            this.nupdMinutos.Size = new System.Drawing.Size(34, 20);
            this.nupdMinutos.TabIndex = 6;
            // 
            // nupdHora
            // 
            this.nupdHora.Enabled = false;
            this.nupdHora.Location = new System.Drawing.Point(96, 86);
            this.nupdHora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nupdHora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nupdHora.Name = "nupdHora";
            this.nupdHora.Size = new System.Drawing.Size(34, 20);
            this.nupdHora.TabIndex = 5;
            this.nupdHora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Location = new System.Drawing.Point(83, 50);
            this.dtpFecha.MinDate = new System.DateTime(2021, 11, 10, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(220, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2021, 11, 12, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Hora de Inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pista:";
            // 
            // cmbPista
            // 
            this.cmbPista.Enabled = false;
            this.cmbPista.FormattingEnabled = true;
            this.cmbPista.Location = new System.Drawing.Point(83, 14);
            this.cmbPista.Name = "cmbPista";
            this.cmbPista.Size = new System.Drawing.Size(220, 21);
            this.cmbPista.TabIndex = 0;
            this.cmbPista.SelectedIndexChanged += new System.EventHandler(this.cmbPista_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPagar);
            this.panel3.Controls.Add(this.dgvReservas);
            this.panel3.Location = new System.Drawing.Point(15, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 210);
            this.panel3.TabIndex = 6;
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(330, 166);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(96, 37);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(17, 14);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(732, 146);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.TabStop = false;
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            // 
            // pistasPorReservaBindingSource
            // 
            this.pistasPorReservaBindingSource.DataMember = "PistasPorReserva";
            this.pistasPorReservaBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // pistasPorReservaTableAdapter
            // 
            this.pistasPorReservaTableAdapter.ClearBeforeFill = true;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDniSocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSocio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdHora)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasPorReservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSocio;
        private dsBD dsBD;
        private dsBDTableAdapters.sociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mktTelefono;
        private System.Windows.Forms.MaskedTextBox mktCuenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nupdMinutos;
        private System.Windows.Forms.NumericUpDown nupdHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistaDataGridViewTextBoxColumn;
        private dsBDTableAdapters.PistasPorReservaTableAdapter pistasPorReservaTableAdapter;
        private System.Windows.Forms.BindingSource pistasPorReservaBindingSource;
        private System.Windows.Forms.PictureBox pcbImagen;
        private dsBDTableAdapters.pistasTableAdapter pistasTableAdapter;
        private dsBDTableAdapters.reservasTableAdapter reservasTableAdapter;
    }
}