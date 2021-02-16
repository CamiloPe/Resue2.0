
namespace ResueDos
{
    partial class FrmRegistrarse
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
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grpFoto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatosRegistro = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpDatosPersonales.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDatosRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.textBox2);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoP);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoM);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoM);
            this.grpDatosPersonales.Controls.Add(this.textBox1);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(10, 11);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(298, 111);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos personales";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Location = new System.Drawing.Point(5, 77);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(107, 17);
            this.lblApellidoP.TabIndex = 4;
            this.lblApellidoP.Text = "Apellido paterno";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(121, 46);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(163, 23);
            this.txtApellidoM.TabIndex = 3;
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Location = new System.Drawing.Point(5, 51);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(110, 17);
            this.lblApellidoM.TabIndex = 2;
            this.lblApellidoM.Text = "Apellido materno";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbOtro);
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(10, 128);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(105, 100);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Location = new System.Drawing.Point(6, 70);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(56, 21);
            this.rdbOtro.TabIndex = 2;
            this.rdbOtro.TabStop = true;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 45);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(87, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 20);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(90, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grpFoto
            // 
            this.grpFoto.Controls.Add(this.pictureBox1);
            this.grpFoto.Location = new System.Drawing.Point(133, 134);
            this.grpFoto.Name = "grpFoto";
            this.grpFoto.Size = new System.Drawing.Size(175, 94);
            this.grpFoto.TabIndex = 3;
            this.grpFoto.TabStop = false;
            this.grpFoto.Text = "Foto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpDatosRegistro
            // 
            this.grpDatosRegistro.Controls.Add(this.comboBox1);
            this.grpDatosRegistro.Controls.Add(this.lblEdad);
            this.grpDatosRegistro.Controls.Add(this.textBox4);
            this.grpDatosRegistro.Controls.Add(this.lblConfirmarContrasena);
            this.grpDatosRegistro.Controls.Add(this.txtContrasena);
            this.grpDatosRegistro.Controls.Add(this.lblContrasena);
            this.grpDatosRegistro.Controls.Add(this.txtUsuario);
            this.grpDatosRegistro.Controls.Add(this.lblUsuario);
            this.grpDatosRegistro.Controls.Add(this.txtEMail);
            this.grpDatosRegistro.Controls.Add(this.lblEMail);
            this.grpDatosRegistro.Location = new System.Drawing.Point(313, 11);
            this.grpDatosRegistro.Name = "grpDatosRegistro";
            this.grpDatosRegistro.Size = new System.Drawing.Size(333, 162);
            this.grpDatosRegistro.TabIndex = 4;
            this.grpDatosRegistro.TabStop = false;
            this.grpDatosRegistro.Text = "Datos de registro";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(5, 129);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 17);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 23);
            this.textBox4.TabIndex = 13;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(5, 103);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(137, 17);
            this.lblConfirmarContrasena.TabIndex = 12;
            this.lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(157, 72);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(163, 23);
            this.txtContrasena.TabIndex = 11;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(5, 77);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 17);
            this.lblContrasena.TabIndex = 10;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(157, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 23);
            this.txtUsuario.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(5, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(157, 20);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(163, 23);
            this.txtEMail.TabIndex = 7;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(5, 24);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(44, 17);
            this.lblEMail.TabIndex = 6;
            this.lblEMail.Text = "E-Mail";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(313, 179);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(206, 49);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrar.Location = new System.Drawing.Point(525, 179);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 49);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "12 doce",
            "13 trece",
            "14 catorce",
            "15 quince",
            "16 dieciséis",
            "17 diecisiete",
            "18 dieciocho",
            "19 diecinueve",
            "20 veinte",
            "21 veintiuno",
            "22 veintidós",
            "23 veintitrés",
            "24 veinticuatro",
            "25 veinticinco",
            "26 veintiséis",
            "27 veintisiete",
            "28 veintiocho",
            "29 veintinueve",
            "30 treinta",
            "31 treinta y uno",
            "32 treinta y dos",
            "33 treinta y tres",
            "34 treinta y cuatro",
            "35 treinta y cinco",
            "36 treinta y seis",
            "37 treinta y siete",
            "38 treinta y ocho",
            "39 treinta y nueve",
            "40 cuarenta",
            "41 cuarenta y uno",
            "42 cuarenta y dos",
            "43 cuarenta y tres",
            "44 cuarenta y cuatro",
            "45 cuarenta y cinco",
            "46 cuarenta y seis",
            "47 cuarenta y siete",
            "48 cuarenta y ocho",
            "49 cuarenta y nueve",
            "50 cincuenta",
            "51 cincuenta y uno",
            "52 cincuenta y dos",
            "53 cincuenta y tres",
            "54 cincuenta y cuatro",
            "55 cincuenta y cinco",
            "56 cincuenta y seis",
            "57 cincuenta y siete",
            "58 cincuenta y ocho",
            "59 cincuenta y nueve",
            "60 sesenta",
            "61 sesenta y uno ",
            "62 sesenta y dos",
            "63 sesenta y tres",
            "64 sesenta y cuatro",
            "65 sesenta y cinco",
            "66 sesenta y seis",
            "67 sesenta y siete",
            "68 sesenta y ocho",
            "69 sesenta y nueve",
            "70 setenta",
            "71 setenta y uno",
            "72 setenta y dos",
            "73 setenta y tres",
            "74 setenta y cuatro",
            "75 setenta y cinco"});
            this.comboBox1.Location = new System.Drawing.Point(157, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // FrmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(659, 254);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpDatosRegistro);
            this.Controls.Add(this.grpFoto);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatosPersonales);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRegistrarse";
            this.Text = "Registrarse";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDatosRegistro.ResumeLayout(false);
            this.grpDatosRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label lblApellidoP;
        public System.Windows.Forms.TextBox txtApellidoM;
        public System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpDatosRegistro;
        public System.Windows.Forms.Label lblEdad;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.Label lblConfirmarContrasena;
        public System.Windows.Forms.TextBox txtContrasena;
        public System.Windows.Forms.Label lblContrasena;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

