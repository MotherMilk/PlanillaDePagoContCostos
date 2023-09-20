using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanillaDePagoContCostos
{
    public partial class RegistroInventario : Form
    {
        static string[] frm = { "PEPS", "UEPS",
            "C/PROMO" };
        static string[] frm2 = { "ACE", "JABON",
            "CLORO", "SUVITEL", "DEERGENTE" };

        public RegistroInventario()
        {
            InitializeComponent();
        }
        private void RegistroInventario_Load(object sender, EventArgs e)
        {
            cboMt1.DataSource = frm;
            cboMt2.DataSource = frm;
            cboProducto.DataSource = frm2;
        }
        private void cboMt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Principal objp = new();
            decimal M;
            M = objp.validarFrm();
        }

        private void btnAceptar1_Click(object sender, EventArgs e, decimal M)
        {
            if (M == 1)
            {
                MetodoPeps pep = new MetodoPeps();
                pep.ShowDialog();
            }
            else if (M == 2)
            {
                MetodoUeps uep = new MetodoUeps();
                uep.ShowDialog();
            }
            else if (M == 3)
            {
                MetodoCpromo prom = new MetodoCpromo();
                prom.ShowDialog();
            }
            else MessageBox.Show("Seleccione una opcion dentro de la figuras bidimencionales ");
        }

        private void cboMt2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Principal objp = new();
            decimal M;
            M = objp.validarFrm();
        }




    }
}