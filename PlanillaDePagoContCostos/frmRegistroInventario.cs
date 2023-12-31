﻿using MODELO;
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
    public partial class frmRegistroInventario : Form
    {
        static string[] frm = { "UEPS", "PEPS",
            "C/PROMO" };
        static string[] frm2 = { "ACE", "JABON",
            "CLORO", "SUVITEL", "DEERGENTE" };
        int M;

        public frmRegistroInventario()
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
            /* Principal objp = new();
             int M;
             M = objp.validarFrm();*/

            Principal objp = new Principal();
#pragma warning disable CS8601 // Possible null reference assignment.
            objp.validar1 = cboMt1.SelectedItem.ToString(); // Establece validar1 según la selección del usuario.
#pragma warning restore CS8601 // Possible null reference assignment.
            M = objp.validarFrm();
        }


        private void btnAceptarR_Click(object sender, EventArgs e)
        {
            if (M == 1)
            {
                this.Hide();
                frmMetodoUeps uep = new frmMetodoUeps();
                uep.ShowDialog();
            }
            else if (M == 2)
            {
                this.Hide();
                frmMetodoPeps pep = new frmMetodoPeps();
                pep.ShowDialog();

            }
            else if (M == 3)
            {
                this.Hide();
                frmMetodoCpromo prom = new frmMetodoCpromo();
                prom.ShowDialog();
            }
            else MessageBox.Show("Seleccione una opcion dentro de las opciones.");
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
                Application.Exit();
        }





        /*  private void cboMt2_SelectedIndexChanged(object sender, EventArgs e)
          {
              Principal objp = new();
              decimal M;
              M = objp.validarFrm();
          }
        */



    }
}