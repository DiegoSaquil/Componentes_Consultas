using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Usando capa controlador 
using Capa_Controlador_Componente_Consultas;

namespace Capa_Vista_Componente_Consultas
// Realizado por: Nelson Jose Godinez Mendez 0901-22-3550
{
    public partial class Frm_Consulta_Compleja : Form
    {
        public Frm_Consulta_Compleja()
        {
            InitializeComponent();
        }

        private void Btn_consimple_Click(object sender, EventArgs e)
        {


            Frm_Consulta_Simple consultas = new Frm_Consulta_Simple();
            consultas.Show();
            this.Hide();
        }
        // --------------------------------------------------
    }
  }

