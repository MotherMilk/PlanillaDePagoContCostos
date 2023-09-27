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
        DateTime fecha = DateTime.Now;
        public frmMetodoCpromo()
        {

            InitializeComponent();
            // Crea el GridView
            string fechaFormateada = fecha.ToString("dd/MM/yyyy");
            lblfecha.Text = "Fecha: " + fechaFormateada;
            lblTitulo.Visible = false;
            lblCan.Visible = false;
            lblValor.Visible = false;

            // Maneja el evento de selección del ComboBox
            cboConcepto.SelectedIndexChanged += CboConcepto_SelectedIndexChanged;


            btnAgg.Visible = false;
            btnExportar.Visible = false;
            btnBorrar.Visible = false;

            txtCantidad.Visible = false;
            txtValorU.Visible = false;
        }

        private void CboConcepto_SelectedIndexChanged(object? sender, EventArgs e)
        {

            // Obtén la opción seleccionada
            string opcionSeleccionada = cboConcepto.SelectedItem.ToString();

            // Actualiza los TextBox según la opción seleccionada

            if (opcionSeleccionada == "Venta")
            {
                txtCantidad.Text = "";
                txtValorU.Text = "";
                txtCantidad.Focus();

                btnAgg.Visible = true;
                btnAgg.Enabled = false;
                btnBorrar.Visible = true;
                btnBorrar.Enabled = false;
                btnExportar.Visible = true;

                lblCan.Visible = true;
                lblValor.Visible = false;
                txtCantidad.Visible = true;
                txtValorU.Visible = false;
                lblTitulo.Visible = true;
                lblTitulo.Text = "Datos de Venta:";
            }
            else if (opcionSeleccionada == "Compra")
            {
                txtCantidad.Text = "";
                txtValorU.Text = "";
                txtCantidad.Focus();

                btnAgg.Visible = true;
                btnAgg.Enabled = false;
                btnBorrar.Visible = true;
                btnBorrar.Enabled = false;
                btnExportar.Visible = true;


                lblCan.Visible = true;
                lblValor.Visible = true;
                txtCantidad.Visible = true;
                txtValorU.Visible = true;
                lblTitulo.Visible = true;
                lblTitulo.Text = "Datos de Compra:";
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear caracteres no numéricos
            }
        }

        private void txtValorU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.Contains(".")))
                e.Handled = true;

            if ((e.KeyChar == '.') && (sender as System.Windows.Forms.TextBox).Text.Length == 0)
                e.Handled = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();

            HabilitarBotonBorrar();
        }

        private void txtValorU_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();

            HabilitarBotonBorrar();
        }




        //Este método habilita y deshabilita los botones "Calcular" de cada figura, verificando los textbox vacíos.

        private void VerificarCamposNoVacios()
        {

            if (cboConcepto.SelectedItem.ToString() == "Venta")
            {
                btnAgg.Enabled = !string.IsNullOrWhiteSpace(txtCantidad.Text);

            }
            else if (cboConcepto.SelectedItem.ToString() == "Compra")
            {
                // Si la opción seleccionada es "Compra", habilitar cuando ambos TextBox tengan contenido
                btnAgg.Enabled = !string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtValorU.Text);
                //btnBorrar.Enabled = !string.IsNullOrWhiteSpace(txtCantidad.Text) && !string.IsNullOrWhiteSpace(txtValorU.Text);
            }
            else
            {
                btnAgg.Enabled = false;
                // btnBorrar.Enabled = false;
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            HabilitarBotonBorrar();
            DialogResult resultado = MessageBox.Show("¿Desea borrar los datos ingresados?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                txtCantidad.Text = "";
                txtValorU.Text = "";
                txtCantidad.Focus();
                btnBorrar.Enabled = false;
            }
        }

        private void HabilitarBotonBorrar()
        {
            // Verifica si los TextBox tienen datos y habilita el botón de limpiar en consecuencia
            btnBorrar.Enabled = !string.IsNullOrWhiteSpace(txtCantidad.Text) || !string.IsNullOrWhiteSpace(txtValorU.Text);
        }



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





        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar al menú principal?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                this.Hide();
                frmRegistroInventario menu = new();
                menu.ShowDialog();
            }
        }

        private void btnAgg_Click_1(object sender, EventArgs e)
        {
            // Obtén la opción seleccionada en el ComboBox
            string opcionSeleccionada = cboConcepto.SelectedItem.ToString();
            double Pventa = CalcularPrecioVenta();
            double total = double.Parse(txtCantidad.Text) * double.Parse(txtValorU.Text);
            double totalV = Pventa * double.Parse(txtCantidad.Text);
            decimal saldo = totalDebe() - totalHaber();

            // Obtén la fecha actual formateada
            string fechaFormateada = fecha.ToString("dd/MM/yyyy");

            // Agrega una nueva fila al DataGridView
            int rowIndex = dataGridView1.Rows.Add();

            // Establece la fecha en la primera columna
            dataGridView1.Rows[rowIndex].Cells[0].Value = fechaFormateada;

            // Establece la opción seleccionada en la segunda columna
            dataGridView1.Rows[rowIndex].Cells[1].Value = opcionSeleccionada;

            // Verifica la opción y agrega los datos correspondientes en las columnas restantes
            if (opcionSeleccionada == "Venta")
            {
                // Agrega la cantidad en la sexta columna
                dataGridView1.Rows[rowIndex].Cells[5].Value = txtCantidad.Text;
                dataGridView1.Rows[rowIndex].Cells[6].Value = Pventa;
                dataGridView1.Rows[rowIndex].Cells[7].Value = totalV;
                dataGridView1.Rows[rowIndex].Cells[10].Value = totalV;
            }
            else if (opcionSeleccionada == "Compra")
            {
                // Agrega el valor unitario en la tercera columna y la cantidad en la segunda columna
                dataGridView1.Rows[rowIndex].Cells[2].Value = txtCantidad.Text;// Si deseas poner cantidad en la columna 2
                dataGridView1.Rows[rowIndex].Cells[3].Value = txtValorU.Text;
                dataGridView1.Rows[rowIndex].Cells[4].Value = total;
                dataGridView1.Rows[rowIndex].Cells[9].Value = total;
            }
            dataGridView1.Rows[rowIndex].Cells[11].Value = saldo.ToString();

            //dataGridView1.Rows[rowIndex].Cells[11].Value = ;
            // Limpia los TextBox después de agregar los datos
            txtCantidad.Text = "";
            txtValorU.Text = "";

            // Deshabilita el botón "Agregar"
            btnAgg.Enabled = false;

            // Vuelve a verificar si debe habilitar el botón "Borrar"
            HabilitarBotonBorrar();
        }

        private decimal totalHaber()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total = Convert.ToDecimal(row.Cells["Cantidads"].Value);
            }
            return Total;
        }

        private decimal totalDebe()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total = Convert.ToDecimal(row.Cells["CantidadSds"].Value);
            }
            return Total;
        }

        private decimal totalProductoSal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total = Convert.ToDecimal(row.Cells["ValorUnSds"].Value);
            }
            return Total;
        }

        private decimal totalProductoEnt()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Total = Convert.ToDecimal(row.Cells["CantidadE"].Value);
            }
            return Total;
        }

        private double CalcularPrecioVenta()
        {
            decimal PrecioVenta = 0;
            PrecioVenta = (totalDebe() - totalHaber()) * totalProductoEnt() - totalProductoSal();
            return Convert.ToDouble(PrecioVenta);
        }
    }
}
