
namespace ResueDos
{
    partial class FrmOdin
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
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnTips = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrarse.Location = new System.Drawing.Point(10, 11);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(117, 46);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfig.Location = new System.Drawing.Point(10, 63);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(117, 46);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrar.Location = new System.Drawing.Point(10, 114);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(240, 46);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTips
            // 
            this.btnTips.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTips.Location = new System.Drawing.Point(133, 63);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(117, 46);
            this.btnTips.TabIndex = 3;
            this.btnTips.Text = "Tips";
            this.btnTips.UseVisualStyleBackColor = false;
            this.btnTips.Click += new System.EventHandler(this.btnTips_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSignIn.Location = new System.Drawing.Point(133, 11);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(117, 46);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // FrmOdin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 184);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnTips);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnRegistrarse);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmOdin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnTips;
        private System.Windows.Forms.Button btnSignIn;
    }
}