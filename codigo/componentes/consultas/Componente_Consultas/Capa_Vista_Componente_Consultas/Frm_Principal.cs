using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Componente_Consultas
// Realizado por: Nelson Jose Godinez Mendez 0901-22-3550
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_ConsultaSimple_Click(object sender, EventArgs e)
        {
                //Consulta simple
                Frm_Consulta_Simple consultas = new Frm_Consulta_Simple();
                consultas.Show();
                this.Hide();
        }

        private void Btn_ConsultaCompleja_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Compleja consulta_compleja = new Frm_Consulta_Compleja();
            consulta_compleja.Show();
            this.Hide();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // --------------------------------------
    }
}
