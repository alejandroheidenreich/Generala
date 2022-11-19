using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmEstadisticas : Form
    {
        BaseDeDatos? db;
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                db = new BaseDeDatos();
                BindingSource bs = new BindingSource();
                BindingSource bs2 = new BindingSource();
                bs.DataSource = db.InformarRankingVictorias();
                bs2.DataSource = db.InformarRankingPuntaje();
                this.dtg_RankingVictorias.DataSource = bs;
                this.dtg_RankingPuntajes.DataSource = bs2;
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void MostrarError(string msj)
        {
            this.lbl_mensajeDeError.Visible = true;
            this.lbl_mensajeDeError.Text = msj;
        }
    }
}
