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
    public partial class frmMetodoCpromo : Form
    {
        public frmMetodoCpromo()
        {
            InitializeComponent();
            // Crea el GridView
            var gridView = new DataGridView();
            gridView.Dock = DockStyle.Fill;

            // Agrega las columnas iniciales (entradas, salidas y saldos)
            gridView.Columns.Add("Entradas", "Entradas");
            gridView.Columns.Add("Salidas", "Salidas");
            gridView.Columns.Add("Saldos", "Saldos");

            // Agrega las columnas secundarias (cantidad, valor unitario y valor total)
            gridView.Columns.Add("Cantidad", "Cantidad");
            gridView.Columns.Add("ValorUnitario", "Valor Unitario");
            gridView.Columns.Add("ValorTotal", "Valor Total");

            // Agrega datos de ejemplo
            gridView.Rows.Add("10", "5", "15", "20", "10", "200", "5", "10", "50");

            // Agrega el GridView al formulario
            Controls.Add(gridView);

        }
    }
}
