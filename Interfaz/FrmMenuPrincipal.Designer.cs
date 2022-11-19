namespace Interfaz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_MensajeDeSala = new System.Windows.Forms.Label();
            this.lbl_MensajeDeError = new System.Windows.Forms.Label();
            this.lbl_Ganador = new System.Windows.Forms.Label();
            this.imglst_Dados = new System.Windows.Forms.ImageList(this.components);
            this.gb_Dados = new System.Windows.Forms.GroupBox();
            this.lbl_Dado5 = new System.Windows.Forms.Label();
            this.lbl_Dado4 = new System.Windows.Forms.Label();
            this.lbl_Dado3 = new System.Windows.Forms.Label();
            this.lbl_Dado2 = new System.Windows.Forms.Label();
            this.lbl_Dado1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_Recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb_Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CrearMesa
            // 
            this.btn_CrearMesa.BackColor = System.Drawing.Color.Transparent;
            this.btn_CrearMesa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CrearMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearMesa.ForeColor = System.Drawing.Color.Lavender;
            this.btn_CrearMesa.Image = ((System.Drawing.Image)(resources.GetObject("btn_CrearMesa.Image")));
            this.btn_CrearMesa.Location = new System.Drawing.Point(12, 557);
            this.btn_CrearMesa.Name = "btn_CrearMesa";
            this.btn_CrearMesa.Size = new System.Drawing.Size(139, 75);
            this.btn_CrearMesa.TabIndex = 2;
            this.btn_CrearMesa.Text = "Crear Mesa";
            this.btn_CrearMesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CrearMesa.UseVisualStyleBackColor = false;
            this.btn_CrearMesa.Click += new System.EventHandler(this.btn_CrearMesa_Click);
            // 
            // btn_EntrarSala
            // 
            this.btn_EntrarSala.BackColor = System.Drawing.Color.Transparent;
            this.btn_EntrarSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EntrarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EntrarSala.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_EntrarSala.Image = ((System.Drawing.Image)(resources.GetObject("btn_EntrarSala.Image")));
            this.btn_EntrarSala.Location = new System.Drawing.Point(157, 557);
            this.btn_EntrarSala.Name = "btn_EntrarSala";
            this.btn_EntrarSala.Size = new System.Drawing.Size(139, 75);
            this.btn_EntrarSala.TabIndex = 12;
            this.btn_EntrarSala.Text = "Iniciar Partida";
            this.btn_EntrarSala.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_EntrarSala.UseVisualStyleBackColor = false;
            this.btn_EntrarSala.Click += new System.EventHandler(this.btn_IniciarPartida_Click);
            // 
            // rtb_LogPartida
            // 
            this.rtb_LogPartida.BackColor = System.Drawing.Color.DimGray;
            this.rtb_LogPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_LogPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtb_LogPartida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rtb_LogPartida.Location = new System.Drawing.Point(1070, 413);
            this.rtb_LogPartida.Name = "rtb_LogPartida";
            this.rtb_LogPartida.ReadOnly = true;
            this.rtb_LogPartida.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_LogPartida.Size = new System.Drawing.Size(314, 194);
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
            this.dtg_Mesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Mesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Mesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Mesa.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Mesa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Mesa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_Mesa.Location = new System.Drawing.Point(32, 33);
            this.dtg_Mesa.MultiSelect = false;
            this.dtg_Mesa.Name = "dtg_Mesa";
            this.dtg_Mesa.ReadOnly = true;
            this.dtg_Mesa.RowHeadersVisible = false;
            this.dtg_Mesa.RowTemplate.Height = 25;
            this.dtg_Mesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Mesa.Size = new System.Drawing.Size(429, 360);
            this.dtg_Mesa.TabIndex = 18;
            this.dtg_Mesa.TabStop = false;
            this.dtg_Mesa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Mesa_CellClick);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_JuegoUno.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_JuegoUno.Enabled = false;
            this.dtg_JuegoUno.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_JuegoUno.Location = new System.Drawing.Point(513, 59);
            this.dtg_JuegoUno.MultiSelect = false;
            this.dtg_JuegoUno.Name = "dtg_JuegoUno";
            this.dtg_JuegoUno.ReadOnly = true;
            this.dtg_JuegoUno.RowHeadersVisible = false;
            this.dtg_JuegoUno.RowTemplate.Height = 25;
            this.dtg_JuegoUno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_JuegoUno.Size = new System.Drawing.Size(187, 262);
            this.dtg_JuegoUno.TabIndex = 19;
            this.dtg_JuegoUno.TabStop = false;
            this.dtg_JuegoUno.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_JuegoUno_CellFormatting);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_JuegoDos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_JuegoDos.Enabled = false;
            this.dtg_JuegoDos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_JuegoDos.Location = new System.Drawing.Point(1068, 59);
            this.dtg_JuegoDos.MultiSelect = false;
            this.dtg_JuegoDos.Name = "dtg_JuegoDos";
            this.dtg_JuegoDos.ReadOnly = true;
            this.dtg_JuegoDos.RowHeadersVisible = false;
            this.dtg_JuegoDos.RowTemplate.Height = 25;
            this.dtg_JuegoDos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_JuegoDos.Size = new System.Drawing.Size(187, 262);
            this.dtg_JuegoDos.TabIndex = 20;
            this.dtg_JuegoDos.TabStop = false;
            this.dtg_JuegoDos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_JuegoDos_CellFormatting);
            // 
            // lbl_J1
            // 
            this.lbl_J1.AutoSize = true;
            this.lbl_J1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_J1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_J1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_J1.Location = new System.Drawing.Point(559, 22);
            this.lbl_J1.Name = "lbl_J1";
            this.lbl_J1.Size = new System.Drawing.Size(89, 20);
            this.lbl_J1.TabIndex = 22;
            this.lbl_J1.Text = "Jugador 1";
            // 
            // lbl_J2
            // 
            this.lbl_J2.AutoSize = true;
            this.lbl_J2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_J2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_J2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_J2.Location = new System.Drawing.Point(1113, 22);
            this.lbl_J2.Name = "lbl_J2";
            this.lbl_J2.Size = new System.Drawing.Size(89, 20);
            this.lbl_J2.TabIndex = 23;
            this.lbl_J2.Text = "Jugador 2";
            // 
            // lbl_EncabezadoPuntajeJ1
            // 
            this.lbl_EncabezadoPuntajeJ1.AutoSize = true;
            this.lbl_EncabezadoPuntajeJ1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EncabezadoPuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntajeJ1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_EncabezadoPuntajeJ1.Location = new System.Drawing.Point(553, 336);
            this.lbl_EncabezadoPuntajeJ1.Name = "lbl_EncabezadoPuntajeJ1";
            this.lbl_EncabezadoPuntajeJ1.Size = new System.Drawing.Size(63, 16);
            this.lbl_EncabezadoPuntajeJ1.TabIndex = 24;
            this.lbl_EncabezadoPuntajeJ1.Text = "Puntaje:";
            // 
            // lbl_PuntajeJ1
            // 
            this.lbl_PuntajeJ1.AutoSize = true;
            this.lbl_PuntajeJ1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PuntajeJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJ1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_PuntajeJ1.Location = new System.Drawing.Point(622, 336);
            this.lbl_PuntajeJ1.Name = "lbl_PuntajeJ1";
            this.lbl_PuntajeJ1.Size = new System.Drawing.Size(15, 16);
            this.lbl_PuntajeJ1.TabIndex = 25;
            this.lbl_PuntajeJ1.Text = "0";
            // 
            // lbl_PuntajeJ2
            // 
            this.lbl_PuntajeJ2.AutoSize = true;
            this.lbl_PuntajeJ2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntajeJ2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_PuntajeJ2.Location = new System.Drawing.Point(1187, 336);
            this.lbl_PuntajeJ2.Name = "lbl_PuntajeJ2";
            this.lbl_PuntajeJ2.Size = new System.Drawing.Size(15, 16);
            this.lbl_PuntajeJ2.TabIndex = 27;
            this.lbl_PuntajeJ2.Text = "0";
            // 
            // lbl_EncabezadoPuntajeJ2
            // 
            this.lbl_EncabezadoPuntajeJ2.AutoSize = true;
            this.lbl_EncabezadoPuntajeJ2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EncabezadoPuntajeJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntajeJ2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_EncabezadoPuntajeJ2.Location = new System.Drawing.Point(1118, 336);
            this.lbl_EncabezadoPuntajeJ2.Name = "lbl_EncabezadoPuntajeJ2";
            this.lbl_EncabezadoPuntajeJ2.Size = new System.Drawing.Size(63, 16);
            this.lbl_EncabezadoPuntajeJ2.TabIndex = 26;
            this.lbl_EncabezadoPuntajeJ2.Text = "Puntaje:";
            // 
            // btn_CancelarPartida
            // 
            this.btn_CancelarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CancelarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarPartida.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CancelarPartida.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarPartida.Image")));
            this.btn_CancelarPartida.Location = new System.Drawing.Point(302, 557);
            this.btn_CancelarPartida.Name = "btn_CancelarPartida";
            this.btn_CancelarPartida.Size = new System.Drawing.Size(139, 75);
            this.btn_CancelarPartida.TabIndex = 28;
            this.btn_CancelarPartida.Text = "Cancelar Partida";
            this.btn_CancelarPartida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CancelarPartida.UseVisualStyleBackColor = false;
            this.btn_CancelarPartida.Click += new System.EventHandler(this.btn_CancelarPartida_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(712, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 595);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_MensajeDeSala
            // 
            this.lbl_MensajeDeSala.AutoSize = true;
            this.lbl_MensajeDeSala.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MensajeDeSala.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MensajeDeSala.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_MensajeDeSala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MensajeDeSala.Location = new System.Drawing.Point(1113, 377);
            this.lbl_MensajeDeSala.Name = "lbl_MensajeDeSala";
            this.lbl_MensajeDeSala.Size = new System.Drawing.Size(106, 16);
            this.lbl_MensajeDeSala.TabIndex = 30;
            this.lbl_MensajeDeSala.Text = "Mensaje de Sala";
            this.lbl_MensajeDeSala.Visible = false;
            // 
            // lbl_MensajeDeError
            // 
            this.lbl_MensajeDeError.AutoSize = true;
            this.lbl_MensajeDeError.BackColor = System.Drawing.Color.Black;
            this.lbl_MensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_MensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MensajeDeError.Location = new System.Drawing.Point(173, 519);
            this.lbl_MensajeDeError.Name = "lbl_MensajeDeError";
            this.lbl_MensajeDeError.Size = new System.Drawing.Size(111, 16);
            this.lbl_MensajeDeError.TabIndex = 31;
            this.lbl_MensajeDeError.Text = "Mensaje de Error";
            this.lbl_MensajeDeError.Visible = false;
            // 
            // lbl_Ganador
            // 
            this.lbl_Ganador.AutoSize = true;
            this.lbl_Ganador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ganador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Ganador.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Ganador.Location = new System.Drawing.Point(775, 12);
            this.lbl_Ganador.Name = "lbl_Ganador";
            this.lbl_Ganador.Size = new System.Drawing.Size(98, 25);
            this.lbl_Ganador.TabIndex = 34;
            this.lbl_Ganador.Text = "ganador";
            this.lbl_Ganador.Visible = false;
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
            // gb_Dados
            // 
            this.gb_Dados.BackColor = System.Drawing.Color.DarkGreen;
            this.gb_Dados.Controls.Add(this.lbl_Dado5);
            this.gb_Dados.Controls.Add(this.lbl_Dado4);
            this.gb_Dados.Controls.Add(this.lbl_Dado3);
            this.gb_Dados.Controls.Add(this.lbl_Dado2);
            this.gb_Dados.Controls.Add(this.lbl_Dado1);
            this.gb_Dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Dados.Location = new System.Drawing.Point(839, 129);
            this.gb_Dados.Name = "gb_Dados";
            this.gb_Dados.Size = new System.Drawing.Size(92, 417);
            this.gb_Dados.TabIndex = 35;
            this.gb_Dados.TabStop = false;
            this.gb_Dados.Visible = false;
            // 
            // lbl_Dado5
            // 
            this.lbl_Dado5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dado5.ImageList = this.imglst_Dados;
            this.lbl_Dado5.Location = new System.Drawing.Point(6, 328);
            this.lbl_Dado5.Name = "lbl_Dado5";
            this.lbl_Dado5.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado5.TabIndex = 9;
            // 
            // lbl_Dado4
            // 
            this.lbl_Dado4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dado4.ImageList = this.imglst_Dados;
            this.lbl_Dado4.Location = new System.Drawing.Point(6, 248);
            this.lbl_Dado4.Name = "lbl_Dado4";
            this.lbl_Dado4.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado4.TabIndex = 8;
            // 
            // lbl_Dado3
            // 
            this.lbl_Dado3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dado3.ImageList = this.imglst_Dados;
            this.lbl_Dado3.Location = new System.Drawing.Point(6, 168);
            this.lbl_Dado3.Name = "lbl_Dado3";
            this.lbl_Dado3.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado3.TabIndex = 7;
            // 
            // lbl_Dado2
            // 
            this.lbl_Dado2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dado2.ImageList = this.imglst_Dados;
            this.lbl_Dado2.Location = new System.Drawing.Point(6, 89);
            this.lbl_Dado2.Name = "lbl_Dado2";
            this.lbl_Dado2.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado2.TabIndex = 6;
            // 
            // lbl_Dado1
            // 
            this.lbl_Dado1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dado1.ImageList = this.imglst_Dados;
            this.lbl_Dado1.Location = new System.Drawing.Point(6, 9);
            this.lbl_Dado1.Name = "lbl_Dado1";
            this.lbl_Dado1.Size = new System.Drawing.Size(80, 80);
            this.lbl_Dado1.TabIndex = 5;
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
            this.btn_Salir.Location = new System.Drawing.Point(1341, 12);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 38);
            this.btn_Salir.TabIndex = 36;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btn_Estadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Estadisticas.BackgroundImage")));
            this.btn_Estadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Estadisticas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Estadisticas.Location = new System.Drawing.Point(498, 557);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(139, 75);
            this.btn_Estadisticas.TabIndex = 37;
            this.btn_Estadisticas.Text = "ESTADISTICAS";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btn_Recargar
            // 
            this.btn_Recargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Recargar.FlatAppearance.BorderSize = 0;
            this.btn_Recargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Recargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Recargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recargar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Recargar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Recargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Recargar.Image")));
            this.btn_Recargar.Location = new System.Drawing.Point(418, 401);
            this.btn_Recargar.Name = "btn_Recargar";
            this.btn_Recargar.Size = new System.Drawing.Size(43, 38);
            this.btn_Recargar.TabIndex = 38;
            this.btn_Recargar.UseVisualStyleBackColor = false;
            this.btn_Recargar.Click += new System.EventHandler(this.btn_Recargar_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1396, 636);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Recargar);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_MensajeDeSala);
            this.Controls.Add(this.gb_Dados);
            this.Controls.Add(this.lbl_Ganador);
            this.Controls.Add(this.lbl_MensajeDeError);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtb_LogPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenuPrincipal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenuPrincipal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMenuPrincipal_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_JuegoDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb_Dados.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_MensajeDeSala;
        private System.Windows.Forms.Label lbl_MensajeDeError;
        private System.Windows.Forms.Label lbl_Ganador;
        private System.Windows.Forms.ImageList imglst_Dados;
        private System.Windows.Forms.GroupBox gb_Dados;
        private System.Windows.Forms.Label lbl_Dado5;
        private System.Windows.Forms.Label lbl_Dado4;
        private System.Windows.Forms.Label lbl_Dado3;
        private System.Windows.Forms.Label lbl_Dado2;
        private System.Windows.Forms.Label lbl_Dado1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btn_Recargar;
    }
}
