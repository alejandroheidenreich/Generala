namespace Interfaz
{
    partial class FrmMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Dados = new System.Windows.Forms.GroupBox();
            this.lbl_Dado5 = new System.Windows.Forms.Label();
            this.imglst_Dados = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Dado4 = new System.Windows.Forms.Label();
            this.lbl_Dado3 = new System.Windows.Forms.Label();
            this.lbl_Dado2 = new System.Windows.Forms.Label();
            this.lbl_Dado1 = new System.Windows.Forms.Label();
            this.btn_TirarDados = new System.Windows.Forms.Button();
            this.lbl_InfoDados = new System.Windows.Forms.Label();
            this.dtg_Juegos = new System.Windows.Forms.DataGridView();
            this.btn_Tachar = new System.Windows.Forms.Button();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.btn_Realizar = new System.Windows.Forms.Button();
            this.lst_JuegosPosibles = new System.Windows.Forms.ListBox();
            this.lbl_EncabezadoPuntaje = new System.Windows.Forms.Label();
            this.lbl_Puntaje = new System.Windows.Forms.Label();
            this.pnl_FinPartida = new System.Windows.Forms.Panel();
            this.btn_SalirDePartida = new System.Windows.Forms.Button();
            this.btn_ReiniciarPartida = new System.Windows.Forms.Button();
            this.lbl_PuntajeFinal = new System.Windows.Forms.Label();
            this.lbl_JugadorUno = new System.Windows.Forms.Label();
            this.gb_Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Juegos)).BeginInit();
            this.pnl_FinPartida.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Dados
            // 
            this.gb_Dados.Controls.Add(this.lbl_Dado5);
            this.gb_Dados.Controls.Add(this.lbl_Dado4);
            this.gb_Dados.Controls.Add(this.lbl_Dado3);
            this.gb_Dados.Controls.Add(this.lbl_Dado2);
            this.gb_Dados.Controls.Add(this.lbl_Dado1);
            this.gb_Dados.Location = new System.Drawing.Point(104, 211);
            this.gb_Dados.Name = "gb_Dados";
            this.gb_Dados.Size = new System.Drawing.Size(438, 120);
            this.gb_Dados.TabIndex = 5;
            this.gb_Dados.TabStop = false;
            this.gb_Dados.Visible = false;
            // 
            // lbl_Dado5
            // 
            this.lbl_Dado5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Dado5.ImageList = this.imglst_Dados;
            this.lbl_Dado5.Location = new System.Drawing.Point(350, 19);
            this.lbl_Dado5.Name = "lbl_Dado5";
            this.lbl_Dado5.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado5.TabIndex = 9;
            this.lbl_Dado5.Click += new System.EventHandler(this.lbl_Dado5_Click);
            // 
            // imglst_Dados
            // 
            this.imglst_Dados.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglst_Dados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_Dados.ImageStream")));
            this.imglst_Dados.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_Dados.Images.SetKeyName(0, "1.png");
            this.imglst_Dados.Images.SetKeyName(1, "2.png");
            this.imglst_Dados.Images.SetKeyName(2, "3.png");
            this.imglst_Dados.Images.SetKeyName(3, "4.png");
            this.imglst_Dados.Images.SetKeyName(4, "5.png");
            this.imglst_Dados.Images.SetKeyName(5, "6.png");
            // 
            // lbl_Dado4
            // 
            this.lbl_Dado4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Dado4.ImageList = this.imglst_Dados;
            this.lbl_Dado4.Location = new System.Drawing.Point(264, 19);
            this.lbl_Dado4.Name = "lbl_Dado4";
            this.lbl_Dado4.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado4.TabIndex = 8;
            this.lbl_Dado4.Click += new System.EventHandler(this.lbl_Dado4_Click);
            // 
            // lbl_Dado3
            // 
            this.lbl_Dado3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Dado3.ImageList = this.imglst_Dados;
            this.lbl_Dado3.Location = new System.Drawing.Point(178, 19);
            this.lbl_Dado3.Name = "lbl_Dado3";
            this.lbl_Dado3.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado3.TabIndex = 7;
            this.lbl_Dado3.Click += new System.EventHandler(this.lbl_Dado3_Click);
            // 
            // lbl_Dado2
            // 
            this.lbl_Dado2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Dado2.ImageList = this.imglst_Dados;
            this.lbl_Dado2.Location = new System.Drawing.Point(92, 19);
            this.lbl_Dado2.Name = "lbl_Dado2";
            this.lbl_Dado2.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado2.TabIndex = 6;
            this.lbl_Dado2.Click += new System.EventHandler(this.lbl_Dado2_Click);
            // 
            // lbl_Dado1
            // 
            this.lbl_Dado1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Dado1.ImageList = this.imglst_Dados;
            this.lbl_Dado1.Location = new System.Drawing.Point(6, 19);
            this.lbl_Dado1.Name = "lbl_Dado1";
            this.lbl_Dado1.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado1.TabIndex = 5;
            this.lbl_Dado1.Click += new System.EventHandler(this.lbl_Dado1_Click);
            // 
            // btn_TirarDados
            // 
            this.btn_TirarDados.Location = new System.Drawing.Point(78, 373);
            this.btn_TirarDados.Name = "btn_TirarDados";
            this.btn_TirarDados.Size = new System.Drawing.Size(140, 83);
            this.btn_TirarDados.TabIndex = 6;
            this.btn_TirarDados.Text = "Tirar Dados";
            this.btn_TirarDados.UseVisualStyleBackColor = true;
            this.btn_TirarDados.Click += new System.EventHandler(this.btn_TirarDados_Click);
            // 
            // lbl_InfoDados
            // 
            this.lbl_InfoDados.AutoSize = true;
            this.lbl_InfoDados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InfoDados.Location = new System.Drawing.Point(47, 44);
            this.lbl_InfoDados.Name = "lbl_InfoDados";
            this.lbl_InfoDados.Size = new System.Drawing.Size(65, 25);
            this.lbl_InfoDados.TabIndex = 8;
            this.lbl_InfoDados.Text = "Dados";
            // 
            // dtg_Juegos
            // 
            this.dtg_Juegos.AllowUserToAddRows = false;
            this.dtg_Juegos.AllowUserToDeleteRows = false;
            this.dtg_Juegos.AllowUserToResizeColumns = false;
            this.dtg_Juegos.AllowUserToResizeRows = false;
            this.dtg_Juegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Juegos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_Juegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Juegos.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Juegos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Juegos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Juegos.Location = new System.Drawing.Point(799, 64);
            this.dtg_Juegos.MultiSelect = false;
            this.dtg_Juegos.Name = "dtg_Juegos";
            this.dtg_Juegos.ReadOnly = true;
            this.dtg_Juegos.RowHeadersVisible = false;
            this.dtg_Juegos.RowTemplate.Height = 25;
            this.dtg_Juegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Juegos.Size = new System.Drawing.Size(286, 293);
            this.dtg_Juegos.TabIndex = 9;
            this.dtg_Juegos.TabStop = false;
            // 
            // btn_Tachar
            // 
            this.btn_Tachar.Location = new System.Drawing.Point(256, 373);
            this.btn_Tachar.Name = "btn_Tachar";
            this.btn_Tachar.Size = new System.Drawing.Size(140, 83);
            this.btn_Tachar.TabIndex = 10;
            this.btn_Tachar.Text = "Tachar";
            this.btn_Tachar.UseVisualStyleBackColor = true;
            this.btn_Tachar.Click += new System.EventHandler(this.btn_Tachar_Click);
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.Image = ((System.Drawing.Image)(resources.GetObject("lbl_mensajeDeError.Image")));
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(638, 35);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(129, 16);
            this.lbl_mensajeDeError.TabIndex = 12;
            this.lbl_mensajeDeError.Text = "     Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
            // 
            // btn_Realizar
            // 
            this.btn_Realizar.Location = new System.Drawing.Point(420, 373);
            this.btn_Realizar.Name = "btn_Realizar";
            this.btn_Realizar.Size = new System.Drawing.Size(140, 83);
            this.btn_Realizar.TabIndex = 13;
            this.btn_Realizar.Text = "Realizar";
            this.btn_Realizar.UseVisualStyleBackColor = true;
            this.btn_Realizar.Click += new System.EventHandler(this.btn_Realizar_Click);
            // 
            // lst_JuegosPosibles
            // 
            this.lst_JuegosPosibles.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_JuegosPosibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_JuegosPosibles.FormattingEnabled = true;
            this.lst_JuegosPosibles.ItemHeight = 20;
            this.lst_JuegosPosibles.Location = new System.Drawing.Point(294, 64);
            this.lst_JuegosPosibles.Name = "lst_JuegosPosibles";
            this.lst_JuegosPosibles.Size = new System.Drawing.Size(266, 124);
            this.lst_JuegosPosibles.TabIndex = 15;
            // 
            // lbl_EncabezadoPuntaje
            // 
            this.lbl_EncabezadoPuntaje.AutoSize = true;
            this.lbl_EncabezadoPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntaje.Location = new System.Drawing.Point(799, 416);
            this.lbl_EncabezadoPuntaje.Name = "lbl_EncabezadoPuntaje";
            this.lbl_EncabezadoPuntaje.Size = new System.Drawing.Size(108, 29);
            this.lbl_EncabezadoPuntaje.TabIndex = 16;
            this.lbl_EncabezadoPuntaje.Text = "Puntaje:";
            // 
            // lbl_Puntaje
            // 
            this.lbl_Puntaje.AutoSize = true;
            this.lbl_Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Puntaje.Location = new System.Drawing.Point(913, 416);
            this.lbl_Puntaje.Name = "lbl_Puntaje";
            this.lbl_Puntaje.Size = new System.Drawing.Size(27, 29);
            this.lbl_Puntaje.TabIndex = 17;
            this.lbl_Puntaje.Text = "0";
            // 
            // pnl_FinPartida
            // 
            this.pnl_FinPartida.Controls.Add(this.btn_SalirDePartida);
            this.pnl_FinPartida.Controls.Add(this.btn_ReiniciarPartida);
            this.pnl_FinPartida.Controls.Add(this.lbl_PuntajeFinal);
            this.pnl_FinPartida.Controls.Add(this.lbl_JugadorUno);
            this.pnl_FinPartida.Location = new System.Drawing.Point(47, 511);
            this.pnl_FinPartida.Name = "pnl_FinPartida";
            this.pnl_FinPartida.Size = new System.Drawing.Size(1111, 609);
            this.pnl_FinPartida.TabIndex = 18;
            this.pnl_FinPartida.Visible = false;
            // 
            // btn_SalirDePartida
            // 
            this.btn_SalirDePartida.Location = new System.Drawing.Point(638, 373);
            this.btn_SalirDePartida.Name = "btn_SalirDePartida";
            this.btn_SalirDePartida.Size = new System.Drawing.Size(174, 91);
            this.btn_SalirDePartida.TabIndex = 3;
            this.btn_SalirDePartida.Text = "Salir de Mesa";
            this.btn_SalirDePartida.UseVisualStyleBackColor = true;
            this.btn_SalirDePartida.Click += new System.EventHandler(this.btn_SalirDePartida_Click);
            // 
            // btn_ReiniciarPartida
            // 
            this.btn_ReiniciarPartida.Location = new System.Drawing.Point(110, 373);
            this.btn_ReiniciarPartida.Name = "btn_ReiniciarPartida";
            this.btn_ReiniciarPartida.Size = new System.Drawing.Size(174, 91);
            this.btn_ReiniciarPartida.TabIndex = 2;
            this.btn_ReiniciarPartida.Text = "Reiniciar";
            this.btn_ReiniciarPartida.UseVisualStyleBackColor = true;
            this.btn_ReiniciarPartida.Click += new System.EventHandler(this.btn_ReiniciarPartida_Click);
            // 
            // lbl_PuntajeFinal
            // 
            this.lbl_PuntajeFinal.AutoSize = true;
            this.lbl_PuntajeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeFinal.Location = new System.Drawing.Point(214, 222);
            this.lbl_PuntajeFinal.Name = "lbl_PuntajeFinal";
            this.lbl_PuntajeFinal.Size = new System.Drawing.Size(25, 25);
            this.lbl_PuntajeFinal.TabIndex = 1;
            this.lbl_PuntajeFinal.Text = "0";
            // 
            // lbl_JugadorUno
            // 
            this.lbl_JugadorUno.AutoSize = true;
            this.lbl_JugadorUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_JugadorUno.Location = new System.Drawing.Point(133, 110);
            this.lbl_JugadorUno.Name = "lbl_JugadorUno";
            this.lbl_JugadorUno.Size = new System.Drawing.Size(213, 37);
            this.lbl_JugadorUno.TabIndex = 0;
            this.lbl_JugadorUno.Text = "Jugador Uno";
            // 
            // FrmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1111, 609);
            this.Controls.Add(this.pnl_FinPartida);
            this.Controls.Add(this.lbl_Puntaje);
            this.Controls.Add(this.lbl_EncabezadoPuntaje);
            this.Controls.Add(this.lst_JuegosPosibles);
            this.Controls.Add(this.btn_Realizar);
            this.Controls.Add(this.lbl_mensajeDeError);
            this.Controls.Add(this.btn_Tachar);
            this.Controls.Add(this.dtg_Juegos);
            this.Controls.Add(this.lbl_InfoDados);
            this.Controls.Add(this.btn_TirarDados);
            this.Controls.Add(this.gb_Dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMesa";
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.Mesa_Load);
            this.gb_Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Juegos)).EndInit();
            this.pnl_FinPartida.ResumeLayout(false);
            this.pnl_FinPartida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Dados;
        private System.Windows.Forms.ImageList imglst_Dados;
        private System.Windows.Forms.Button btn_TirarDados;
        private System.Windows.Forms.Label lbl_Dado5;
        private System.Windows.Forms.Label lbl_Dado4;
        private System.Windows.Forms.Label lbl_Dado3;
        private System.Windows.Forms.Label lbl_Dado2;
        private System.Windows.Forms.Label lbl_Dado1;
        private System.Windows.Forms.Label lbl_InfoDados;
        private System.Windows.Forms.DataGridView dtg_Juegos;
        private System.Windows.Forms.Button btn_Tachar;
        private System.Windows.Forms.Label lbl_mensajeDeError;
        private System.Windows.Forms.Button btn_Realizar;
        private System.Windows.Forms.ListBox lst_JuegosPosibles;
        private System.Windows.Forms.Label lbl_EncabezadoPuntaje;
        private System.Windows.Forms.Label lbl_Puntaje;
        private System.Windows.Forms.Panel pnl_FinPartida;
        private System.Windows.Forms.Label lbl_PuntajeFinal;
        private System.Windows.Forms.Label lbl_JugadorUno;
        private System.Windows.Forms.Button btn_SalirDePartida;
        private System.Windows.Forms.Button btn_ReiniciarPartida;
    }
}