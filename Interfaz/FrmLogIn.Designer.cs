namespace Interfaz
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.btn_BotonAutoCompletado = new System.Windows.Forms.Button();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.lbl_recuperarContrasenia = new System.Windows.Forms.LinkLabel();
            this.lbl_linea2 = new System.Windows.Forms.Label();
            this.lbl_linea1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BotonAutoCompletado
            // 
            this.btn_BotonAutoCompletado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_BotonAutoCompletado.FlatAppearance.BorderSize = 0;
            this.btn_BotonAutoCompletado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_BotonAutoCompletado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BotonAutoCompletado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BotonAutoCompletado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BotonAutoCompletado.ForeColor = System.Drawing.Color.LightGray;
            this.btn_BotonAutoCompletado.Location = new System.Drawing.Point(640, 12);
            this.btn_BotonAutoCompletado.Name = "btn_BotonAutoCompletado";
            this.btn_BotonAutoCompletado.Size = new System.Drawing.Size(30, 29);
            this.btn_BotonAutoCompletado.TabIndex = 12;
            this.btn_BotonAutoCompletado.Text = "©";
            this.btn_BotonAutoCompletado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_BotonAutoCompletado.UseVisualStyleBackColor = false;
            this.btn_BotonAutoCompletado.Click += new System.EventHandler(this.btn_BotonAutoCompletado_Click);
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.Image = ((System.Drawing.Image)(resources.GetObject("lbl_mensajeDeError.Image")));
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(395, 189);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(129, 16);
            this.lbl_mensajeDeError.TabIndex = 9;
            this.lbl_mensajeDeError.Text = "     Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
            // 
            // lbl_recuperarContrasenia
            // 
            this.lbl_recuperarContrasenia.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lbl_recuperarContrasenia.AutoSize = true;
            this.lbl_recuperarContrasenia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_recuperarContrasenia.LinkColor = System.Drawing.Color.DimGray;
            this.lbl_recuperarContrasenia.Location = new System.Drawing.Point(398, 283);
            this.lbl_recuperarContrasenia.Name = "lbl_recuperarContrasenia";
            this.lbl_recuperarContrasenia.Size = new System.Drawing.Size(141, 16);
            this.lbl_recuperarContrasenia.TabIndex = 14;
            this.lbl_recuperarContrasenia.TabStop = true;
            this.lbl_recuperarContrasenia.Text = "¿Olvidaste tu contraseña?";
            this.lbl_recuperarContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_recuperarContrasenia_LinkClicked);
            // 
            // lbl_linea2
            // 
            this.lbl_linea2.AutoSize = true;
            this.lbl_linea2.ForeColor = System.Drawing.Color.Green;
            this.lbl_linea2.Location = new System.Drawing.Point(303, 148);
            this.lbl_linea2.Name = "lbl_linea2";
            this.lbl_linea2.Size = new System.Drawing.Size(327, 15);
            this.lbl_linea2.TabIndex = 16;
            this.lbl_linea2.Text = "________________________________________________________________";
            // 
            // lbl_linea1
            // 
            this.lbl_linea1.AutoSize = true;
            this.lbl_linea1.ForeColor = System.Drawing.Color.Green;
            this.lbl_linea1.Location = new System.Drawing.Point(303, 66);
            this.lbl_linea1.Name = "lbl_linea1";
            this.lbl_linea1.Size = new System.Drawing.Size(327, 15);
            this.lbl_linea1.TabIndex = 15;
            this.lbl_linea1.Text = "________________________________________________________________";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Salir.Location = new System.Drawing.Point(627, 278);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 38);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.btn_Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.Green;
            this.btn_Ingresar.Location = new System.Drawing.Point(303, 225);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(304, 40);
            this.btn_Ingresar.TabIndex = 8;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contrasenia.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_contrasenia.Location = new System.Drawing.Point(303, 128);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '⚫';
            this.txt_contrasenia.PlaceholderText = "CONTRASEÑA";
            this.txt_contrasenia.Size = new System.Drawing.Size(325, 17);
            this.txt_contrasenia.TabIndex = 11;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_usuario.Location = new System.Drawing.Point(303, 46);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "USUARIO";
            this.txt_usuario.Size = new System.Drawing.Size(325, 17);
            this.txt_usuario.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_Logo);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 341);
            this.panel1.TabIndex = 17;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackColor = System.Drawing.Color.Green;
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(245, 341);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(682, 330);
            this.ControlBox = false;
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_BotonAutoCompletado);
            this.Controls.Add(this.lbl_recuperarContrasenia);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_mensajeDeError);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_linea1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.lbl_linea2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BotonAutoCompletado;
        private System.Windows.Forms.Label lbl_mensajeDeError;
        private System.Windows.Forms.LinkLabel lbl_recuperarContrasenia;
        private System.Windows.Forms.Label lbl_linea2;
        private System.Windows.Forms.Label lbl_linea1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}