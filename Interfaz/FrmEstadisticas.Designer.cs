namespace Interfaz
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.dtg_RankingPuntajes = new System.Windows.Forms.DataGridView();
            this.lbl_EncabezadoPuntajes = new System.Windows.Forms.Label();
            this.lbl_mensajeDeError = new System.Windows.Forms.Label();
            this.dtg_RankingVictorias = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_EncabezadoVictorias = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RankingPuntajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RankingVictorias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Fondo.BackgroundImage")));
            this.pnl_Fondo.Controls.Add(this.dtg_RankingPuntajes);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoPuntajes);
            this.pnl_Fondo.Controls.Add(this.lbl_mensajeDeError);
            this.pnl_Fondo.Controls.Add(this.dtg_RankingVictorias);
            this.pnl_Fondo.Controls.Add(this.btn_Salir);
            this.pnl_Fondo.Controls.Add(this.lbl_EncabezadoVictorias);
            this.pnl_Fondo.Location = new System.Drawing.Point(12, 12);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(776, 426);
            this.pnl_Fondo.TabIndex = 0;
            // 
            // dtg_RankingPuntajes
            // 
            this.dtg_RankingPuntajes.AllowUserToAddRows = false;
            this.dtg_RankingPuntajes.AllowUserToDeleteRows = false;
            this.dtg_RankingPuntajes.AllowUserToResizeColumns = false;
            this.dtg_RankingPuntajes.AllowUserToResizeRows = false;
            this.dtg_RankingPuntajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_RankingPuntajes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_RankingPuntajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_RankingPuntajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_RankingPuntajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RankingPuntajes.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_RankingPuntajes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_RankingPuntajes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_RankingPuntajes.Location = new System.Drawing.Point(423, 63);
            this.dtg_RankingPuntajes.MultiSelect = false;
            this.dtg_RankingPuntajes.Name = "dtg_RankingPuntajes";
            this.dtg_RankingPuntajes.ReadOnly = true;
            this.dtg_RankingPuntajes.RowHeadersVisible = false;
            this.dtg_RankingPuntajes.RowTemplate.Height = 25;
            this.dtg_RankingPuntajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_RankingPuntajes.Size = new System.Drawing.Size(265, 311);
            this.dtg_RankingPuntajes.TabIndex = 43;
            this.dtg_RankingPuntajes.TabStop = false;
            // 
            // lbl_EncabezadoPuntajes
            // 
            this.lbl_EncabezadoPuntajes.AutoSize = true;
            this.lbl_EncabezadoPuntajes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EncabezadoPuntajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoPuntajes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_EncabezadoPuntajes.Location = new System.Drawing.Point(439, 35);
            this.lbl_EncabezadoPuntajes.Name = "lbl_EncabezadoPuntajes";
            this.lbl_EncabezadoPuntajes.Size = new System.Drawing.Size(230, 25);
            this.lbl_EncabezadoPuntajes.TabIndex = 42;
            this.lbl_EncabezadoPuntajes.Text = "Ranking de Puntajes";
            // 
            // lbl_mensajeDeError
            // 
            this.lbl_mensajeDeError.AutoSize = true;
            this.lbl_mensajeDeError.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mensajeDeError.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeDeError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_mensajeDeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeDeError.Location = new System.Drawing.Point(286, 399);
            this.lbl_mensajeDeError.Name = "lbl_mensajeDeError";
            this.lbl_mensajeDeError.Size = new System.Drawing.Size(109, 16);
            this.lbl_mensajeDeError.TabIndex = 41;
            this.lbl_mensajeDeError.Text = "Mensaje de Error";
            this.lbl_mensajeDeError.Visible = false;
            // 
            // dtg_RankingVictorias
            // 
            this.dtg_RankingVictorias.AllowUserToAddRows = false;
            this.dtg_RankingVictorias.AllowUserToDeleteRows = false;
            this.dtg_RankingVictorias.AllowUserToResizeColumns = false;
            this.dtg_RankingVictorias.AllowUserToResizeRows = false;
            this.dtg_RankingVictorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_RankingVictorias.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtg_RankingVictorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_RankingVictorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_RankingVictorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_RankingVictorias.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_RankingVictorias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_RankingVictorias.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtg_RankingVictorias.Location = new System.Drawing.Point(71, 63);
            this.dtg_RankingVictorias.MultiSelect = false;
            this.dtg_RankingVictorias.Name = "dtg_RankingVictorias";
            this.dtg_RankingVictorias.ReadOnly = true;
            this.dtg_RankingVictorias.RowHeadersVisible = false;
            this.dtg_RankingVictorias.RowTemplate.Height = 25;
            this.dtg_RankingVictorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_RankingVictorias.Size = new System.Drawing.Size(265, 311);
            this.dtg_RankingVictorias.TabIndex = 40;
            this.dtg_RankingVictorias.TabStop = false;
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
            this.btn_Salir.Location = new System.Drawing.Point(730, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 38);
            this.btn_Salir.TabIndex = 37;
            this.btn_Salir.Text = "X";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_EncabezadoVictorias
            // 
            this.lbl_EncabezadoVictorias.AutoSize = true;
            this.lbl_EncabezadoVictorias.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EncabezadoVictorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EncabezadoVictorias.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_EncabezadoVictorias.Location = new System.Drawing.Point(87, 35);
            this.lbl_EncabezadoVictorias.Name = "lbl_EncabezadoVictorias";
            this.lbl_EncabezadoVictorias.Size = new System.Drawing.Size(230, 25);
            this.lbl_EncabezadoVictorias.TabIndex = 0;
            this.lbl_EncabezadoVictorias.Text = "Ranking de Victorias";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstadisticas";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RankingPuntajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_RankingVictorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_EncabezadoVictorias;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dtg_RankingVictorias;
        private System.Windows.Forms.Label lbl_mensajeDeError;
        private System.Windows.Forms.DataGridView dtg_RankingPuntajes;
        private System.Windows.Forms.Label lbl_EncabezadoPuntajes;
    }
}