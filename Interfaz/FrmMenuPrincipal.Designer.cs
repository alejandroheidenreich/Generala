﻿namespace Interfaz
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btn_CrearMesa = new System.Windows.Forms.Button();
            this.btn_EntrarSala = new System.Windows.Forms.Button();
            this.rtb_LogPartida = new System.Windows.Forms.RichTextBox();
            this.dtg_Mesa = new System.Windows.Forms.DataGridView();
            this.dtg_JuegoUno = new System.Windows.Forms.DataGridView();
            this.dtg_JuegoDos = new System.Windows.Forms.DataGridView();
            this.lbl_J1 = new System.Windows.Forms.Label();
            this.lbl_J2 = new System.Windows.Forms.Label();
            this.lbl_EncabezadoPuntajeJ1 = new System.Windows.Forms.Label();
            this.lbl_PuntajeJ1 = new System.Windows.Forms.Label();
            this.lbl_PuntajeJ2 = new System.Windows.Forms.Label();
            this.lbl_EncabezadoPuntajeJ2 = new System.Windows.Forms.Label();
            this.btn_CancelarPartida = new System.Windows.Forms.Button();
            this.pnl_Cargando = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoDos)).BeginInit();
            this.pnl_Cargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CrearMesa
            // 
            this.btn_CrearMesa.Location = new System.Drawing.Point(49, 41);
            this.btn_CrearMesa.Name = "btn_CrearMesa";
            this.btn_CrearMesa.Size = new System.Drawing.Size(139, 75);
            this.btn_CrearMesa.TabIndex = 2;
            this.btn_CrearMesa.Text = "Crear Mesa";
            this.btn_CrearMesa.UseVisualStyleBackColor = true;
            this.btn_CrearMesa.Click += new System.EventHandler(this.btn_CrearMesa_Click);
            // 
            // btn_EntrarSala
            // 
            this.btn_EntrarSala.Location = new System.Drawing.Point(236, 41);
            this.btn_EntrarSala.Name = "btn_EntrarSala";
            this.btn_EntrarSala.Size = new System.Drawing.Size(139, 75);
            this.btn_EntrarSala.TabIndex = 12;
            this.btn_EntrarSala.Text = "Iniciar Partida";
            this.btn_EntrarSala.UseVisualStyleBackColor = true;
            this.btn_EntrarSala.Click += new System.EventHandler(this.btn_IniciarPartida_Click);
            // 
            // rtb_LogPartida
            // 
            this.rtb_LogPartida.Location = new System.Drawing.Point(795, 41);
            this.rtb_LogPartida.Name = "rtb_LogPartida";
            this.rtb_LogPartida.ReadOnly = true;
            this.rtb_LogPartida.Size = new System.Drawing.Size(347, 556);
            this.rtb_LogPartida.TabIndex = 17;
            this.rtb_LogPartida.TabStop = false;
            this.rtb_LogPartida.Text = "";
            // 
            // dtg_Mesa
            // 
            this.dtg_Mesa.AllowUserToAddRows = false;
            this.dtg_Mesa.AllowUserToDeleteRows = false;
            this.dtg_Mesa.AllowUserToResizeColumns = false;
            this.dtg_Mesa.AllowUserToResizeRows = false;
            this.dtg_Mesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Mesa.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_Mesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Mesa.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Mesa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Mesa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Mesa.Location = new System.Drawing.Point(49, 147);
            this.dtg_Mesa.MultiSelect = false;
            this.dtg_Mesa.Name = "dtg_Mesa";
            this.dtg_Mesa.ReadOnly = true;
            this.dtg_Mesa.RowHeadersVisible = false;
            this.dtg_Mesa.RowTemplate.Height = 25;
            this.dtg_Mesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Mesa.Size = new System.Drawing.Size(509, 424);
            this.dtg_Mesa.TabIndex = 18;
            this.dtg_Mesa.TabStop = false;
            this.dtg_Mesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Mesa_CellContentClick);
            // 
            // dtg_JuegoUno
            // 
            this.dtg_JuegoUno.AllowUserToAddRows = false;
            this.dtg_JuegoUno.AllowUserToDeleteRows = false;
            this.dtg_JuegoUno.AllowUserToResizeColumns = false;
            this.dtg_JuegoUno.AllowUserToResizeRows = false;
            this.dtg_JuegoUno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_JuegoUno.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_JuegoUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_JuegoUno.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_JuegoUno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_JuegoUno.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_JuegoUno.Location = new System.Drawing.Point(586, 110);
            this.dtg_JuegoUno.MultiSelect = false;
            this.dtg_JuegoUno.Name = "dtg_JuegoUno";
            this.dtg_JuegoUno.ReadOnly = true;
            this.dtg_JuegoUno.RowHeadersVisible = false;
            this.dtg_JuegoUno.RowTemplate.Height = 25;
            this.dtg_JuegoUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_JuegoUno.Size = new System.Drawing.Size(187, 262);
            this.dtg_JuegoUno.TabIndex = 19;
            this.dtg_JuegoUno.TabStop = false;
            // 
            // dtg_JuegoDos
            // 
            this.dtg_JuegoDos.AllowUserToAddRows = false;
            this.dtg_JuegoDos.AllowUserToDeleteRows = false;
            this.dtg_JuegoDos.AllowUserToResizeColumns = false;
            this.dtg_JuegoDos.AllowUserToResizeRows = false;
            this.dtg_JuegoDos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_JuegoDos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_JuegoDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_JuegoDos.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_JuegoDos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_JuegoDos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_JuegoDos.Location = new System.Drawing.Point(1164, 110);
            this.dtg_JuegoDos.MultiSelect = false;
            this.dtg_JuegoDos.Name = "dtg_JuegoDos";
            this.dtg_JuegoDos.ReadOnly = true;
            this.dtg_JuegoDos.RowHeadersVisible = false;
            this.dtg_JuegoDos.RowTemplate.Height = 25;
            this.dtg_JuegoDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_JuegoDos.Size = new System.Drawing.Size(187, 262);
            this.dtg_JuegoDos.TabIndex = 20;
            this.dtg_JuegoDos.TabStop = false;
            // 
            // lbl_J1
            // 
            this.lbl_J1.AutoSize = true;
            this.lbl_J1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_J1.Location = new System.Drawing.Point(626, 57);
            this.lbl_J1.Name = "lbl_J1";
            this.lbl_J1.Size = new System.Drawing.Size(89, 20);
            this.lbl_J1.TabIndex = 22;
            this.lbl_J1.Text = "Jugador 1";
            // 
            // lbl_J2
            // 
            this.lbl_J2.AutoSize = true;
            this.lbl_J2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_J2.Location = new System.Drawing.Point(1215, 57);
            this.lbl_J2.Name = "lbl_J2";
            this.lbl_J2.Size = new System.Drawing.Size(89, 20);
            this.lbl_J2.TabIndex = 23;
            this.lbl_J2.Text = "Jugador 2";
            // 
            // lbl_EncabezadoPuntajeJ1
            // 
            this.lbl_EncabezadoPuntajeJ1.AutoSize = true;
            this.lbl_EncabezadoPuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntajeJ1.Location = new System.Drawing.Point(586, 387);
            this.lbl_EncabezadoPuntajeJ1.Name = "lbl_EncabezadoPuntajeJ1";
            this.lbl_EncabezadoPuntajeJ1.Size = new System.Drawing.Size(63, 16);
            this.lbl_EncabezadoPuntajeJ1.TabIndex = 24;
            this.lbl_EncabezadoPuntajeJ1.Text = "Puntaje:";
            // 
            // lbl_PuntajeJ1
            // 
            this.lbl_PuntajeJ1.AutoSize = true;
            this.lbl_PuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJ1.Location = new System.Drawing.Point(655, 387);
            this.lbl_PuntajeJ1.Name = "lbl_PuntajeJ1";
            this.lbl_PuntajeJ1.Size = new System.Drawing.Size(15, 16);
            this.lbl_PuntajeJ1.TabIndex = 25;
            this.lbl_PuntajeJ1.Text = "0";
            // 
            // lbl_PuntajeJ2
            // 
            this.lbl_PuntajeJ2.AutoSize = true;
            this.lbl_PuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJ2.Location = new System.Drawing.Point(1233, 387);
            this.lbl_PuntajeJ2.Name = "lbl_PuntajeJ2";
            this.lbl_PuntajeJ2.Size = new System.Drawing.Size(15, 16);
            this.lbl_PuntajeJ2.TabIndex = 27;
            this.lbl_PuntajeJ2.Text = "0";
            // 
            // lbl_EncabezadoPuntajeJ2
            // 
            this.lbl_EncabezadoPuntajeJ2.AutoSize = true;
            this.lbl_EncabezadoPuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntajeJ2.Location = new System.Drawing.Point(1164, 387);
            this.lbl_EncabezadoPuntajeJ2.Name = "lbl_EncabezadoPuntajeJ2";
            this.lbl_EncabezadoPuntajeJ2.Size = new System.Drawing.Size(63, 16);
            this.lbl_EncabezadoPuntajeJ2.TabIndex = 26;
            this.lbl_EncabezadoPuntajeJ2.Text = "Puntaje:";
            // 
            // btn_CancelarPartida
            // 
            this.btn_CancelarPartida.Location = new System.Drawing.Point(419, 41);
            this.btn_CancelarPartida.Name = "btn_CancelarPartida";
            this.btn_CancelarPartida.Size = new System.Drawing.Size(139, 75);
            this.btn_CancelarPartida.TabIndex = 28;
            this.btn_CancelarPartida.Text = "Cancelar Partida";
            this.btn_CancelarPartida.UseVisualStyleBackColor = true;
            this.btn_CancelarPartida.Click += new System.EventHandler(this.btn_CancelarPartida_Click);
            // 
            // pnl_Cargando
            // 
            this.pnl_Cargando.Controls.Add(this.pictureBox1);
            this.pnl_Cargando.Location = new System.Drawing.Point(575, 1);
            this.pnl_Cargando.Name = "pnl_Cargando";
            this.pnl_Cargando.Size = new System.Drawing.Size(789, 623);
            this.pnl_Cargando.TabIndex = 29;
            this.pnl_Cargando.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 622);
            this.Controls.Add(this.pnl_Cargando);
            this.Controls.Add(this.btn_CancelarPartida);
            this.Controls.Add(this.lbl_PuntajeJ2);
            this.Controls.Add(this.lbl_EncabezadoPuntajeJ2);
            this.Controls.Add(this.lbl_PuntajeJ1);
            this.Controls.Add(this.lbl_EncabezadoPuntajeJ1);
            this.Controls.Add(this.lbl_J2);
            this.Controls.Add(this.lbl_J1);
            this.Controls.Add(this.dtg_JuegoDos);
            this.Controls.Add(this.dtg_JuegoUno);
            this.Controls.Add(this.dtg_Mesa);
            this.Controls.Add(this.btn_EntrarSala);
            this.Controls.Add(this.btn_CrearMesa);
            this.Controls.Add(this.rtb_LogPartida);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoDos)).EndInit();
            this.pnl_Cargando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CrearMesa;
        private System.Windows.Forms.Button btn_EntrarSala;
        private System.Windows.Forms.RichTextBox rtb_LogPartida;
        private System.Windows.Forms.DataGridView dtg_Mesa;
        private System.Windows.Forms.DataGridView dtg_JuegoUno;
        private System.Windows.Forms.DataGridView dtg_JuegoDos;
        private System.Windows.Forms.Label lbl_J1;
        private System.Windows.Forms.Label lbl_J2;
        private System.Windows.Forms.Label lbl_EncabezadoPuntajeJ1;
        private System.Windows.Forms.Label lbl_PuntajeJ1;
        private System.Windows.Forms.Label lbl_PuntajeJ2;
        private System.Windows.Forms.Label lbl_EncabezadoPuntajeJ2;
        private System.Windows.Forms.Button btn_CancelarPartida;
        private System.Windows.Forms.Panel pnl_Cargando;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
