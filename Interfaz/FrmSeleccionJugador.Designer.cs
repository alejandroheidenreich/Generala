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
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cmb_JugadorUno = new System.Windows.Forms.ComboBox();
            this.cmb_JugadorDos = new System.Windows.Forms.ComboBox();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(30, 198);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(164, 50);
            this.btn_Seleccionar.TabIndex = 0;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(213, 198);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(164, 50);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cmb_JugadorUno
            // 
            this.cmb_JugadorUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_JugadorUno.FormattingEnabled = true;
            this.cmb_JugadorUno.Location = new System.Drawing.Point(48, 67);
            this.cmb_JugadorUno.Name = "cmb_JugadorUno";
            this.cmb_JugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmb_JugadorUno.TabIndex = 2;
            // 
            // cmb_JugadorDos
            // 
            this.cmb_JugadorDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_JugadorDos.FormattingEnabled = true;
            this.cmb_JugadorDos.Location = new System.Drawing.Point(213, 67);
            this.cmb_JugadorDos.Name = "cmb_JugadorDos";
            this.cmb_JugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmb_JugadorDos.TabIndex = 3;
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(141, 136);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(109, 16);
            this.lbl_mensajeDeError.TabIndex = 10;
            this.lbl_mensajeDeError.Text = "Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
            // 
            // FrmSeleccionJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 288);
            this.Controls.Add(this.lbl_mensajeDeError);
            this.Controls.Add(this.cmb_JugadorDos);
            this.Controls.Add(this.cmb_JugadorUno);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Seleccionar);
            this.Name = "FrmSeleccionJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionJugador";
            this.Load += new System.EventHandler(this.FrmSeleccionJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Seleccionar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ComboBox cmb_JugadorUno;
        private System.Windows.Forms.ComboBox cmb_JugadorDos;
        private System.Windows.Forms.Label lbl_mensajeDeError;
    }
}