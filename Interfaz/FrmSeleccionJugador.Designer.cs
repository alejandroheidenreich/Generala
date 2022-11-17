namespace Interfaz
{
    partial class FrmSeleccionJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionJugador));
            this.cmb_JugadorUno = new System.Windows.Forms.ComboBox();
            this.cmb_JugadorDos = new System.Windows.Forms.ComboBox();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.btn_AgregarJugador = new System.Windows.Forms.Button();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_JugadorUno
            // 
            this.cmb_JugadorUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_JugadorUno.FormattingEnabled = true;
            this.cmb_JugadorUno.Location = new System.Drawing.Point(36, 73);
            this.cmb_JugadorUno.Name = "cmb_JugadorUno";
            this.cmb_JugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmb_JugadorUno.TabIndex = 2;
            // 
            // cmb_JugadorDos
            // 
            this.cmb_JugadorDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_JugadorDos.FormattingEnabled = true;
            this.cmb_JugadorDos.Location = new System.Drawing.Point(219, 73);
            this.cmb_JugadorDos.Name = "cmb_JugadorDos";
            this.cmb_JugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmb_JugadorDos.TabIndex = 3;
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(85, 145);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(109, 16);
            this.lbl_mensajeDeError.TabIndex = 10;
            this.lbl_mensajeDeError.Text = "Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
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
            this.btn_Salir.Location = new System.Drawing.Point(341, 223);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 38);
            this.btn_Salir.TabIndex = 37;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Seleccionar.FlatAppearance.BorderSize = 0;
            this.btn_Seleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Seleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Seleccionar.ForeColor = System.Drawing.Color.Green;
            this.btn_Seleccionar.Location = new System.Drawing.Point(111, 170);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(229, 40);
            this.btn_Seleccionar.TabIndex = 38;
            this.btn_Seleccionar.Text = "SELECCIONAR";
            this.btn_Seleccionar.UseVisualStyleBackColor = false;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click_1);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Fondo.BackgroundImage")));
            this.pnl_Fondo.Controls.Add(this.btn_Seleccionar);
            this.pnl_Fondo.Controls.Add(this.btn_AgregarJugador);
            this.pnl_Fondo.Controls.Add(this.btn_Salir);
            this.pnl_Fondo.Controls.Add(this.cmb_JugadorDos);
            this.pnl_Fondo.Controls.Add(this.cmb_JugadorUno);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(387, 264);
            this.pnl_Fondo.TabIndex = 39;
            // 
            // btn_AgregarJugador
            // 
            this.btn_AgregarJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_AgregarJugador.FlatAppearance.BorderSize = 0;
            this.btn_AgregarJugador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_AgregarJugador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AgregarJugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarJugador.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarJugador.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarJugador.Location = new System.Drawing.Point(36, 170);
            this.btn_AgregarJugador.Name = "btn_AgregarJugador";
            this.btn_AgregarJugador.Size = new System.Drawing.Size(43, 40);
            this.btn_AgregarJugador.TabIndex = 38;
            this.btn_AgregarJugador.Text = "+";
            this.btn_AgregarJugador.UseVisualStyleBackColor = false;
            this.btn_AgregarJugador.Click += new System.EventHandler(this.btn_AgregarJugador_Click);
            // 
            // FrmSeleccionJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(411, 288);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_mensajeDeError);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionJugador";
            this.Load += new System.EventHandler(this.FrmSeleccionJugador_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.ComboBox cmb_JugadorUno;
        private System.Windows.Forms.ComboBox cmb_JugadorDos;
        private System.Windows.Forms.Label lbl_mensajeDeError;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Button btn_AgregarJugador;
    }
}