using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace PlanillaDePagoContCostos
{
    public partial class frmMetodoUeps : Form
    {
        public frmMetodoUeps()
        {
            InitializeComponent();
        }

        /* public void exportaraexcel(DataGridView tabla)
         {

             Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

             excel.Application.Workbooks.Add(true);

             int IndiceColumna = 0;

             foreach (DataGridViewColumn col in tabla.Columns)
             {

                 IndiceColumna++;

                 excel.Cells[1, IndiceColumna] = col.Name;

             }

             int IndeceFila = 0;

             foreach (DataGridViewRow row in tabla.Rows)
             {

                 IndeceFila++;

                 IndiceColumna = 0;

                 foreach (DataGridViewColumn col in tabla.Columns)
                 {

                     IndiceColumna++;

                     excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                 }

             }

             excel.Visible = true;


         }*/




        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Puedes verificar si ya existe una instancia de Excel antes de crear una nueva.
            if (excel == null)
            {
                MessageBox.Show("No se pudo iniciar Excel. Asegúrate de tenerlo instalado.");
                return;
            }

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.HeaderText; // Usar HeaderText en lugar de Name
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Index].Value;
                }
            }

            excel.Visible = true;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }
    }
}
