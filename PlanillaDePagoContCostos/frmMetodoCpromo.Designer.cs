namespace PlanillaDePagoContCostos
{
    partial class frmMetodoCpromo
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
            btnAgg = new Button();
            lblTitulo = new Label();
            lblfecha = new Label();
            lblValor = new Label();
            lblCan = new Label();
            label1 = new Label();
            cboConcepto = new ComboBox();
            txtCantidad = new TextBox();
            txtValorU = new TextBox();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Concepto = new DataGridViewTextBoxColumn();
            CantidadE = new DataGridViewTextBoxColumn();
            ValorUnE = new DataGridViewTextBoxColumn();
            ValorTotE = new DataGridViewTextBoxColumn();
            CantidadS = new DataGridViewTextBoxColumn();
            ValorUnS = new DataGridViewTextBoxColumn();
            ValorTotS = new DataGridViewTextBoxColumn();
            CantidadSds = new DataGridViewTextBoxColumn();
            ValorUnSds = new DataGridViewTextBoxColumn();
            ValorTotSds = new DataGridViewTextBoxColumn();
            btnInicio = new Button();
            btnBorrar = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(612, 136);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(94, 29);
            btnAgg.TabIndex = 34;
            btnAgg.Text = "Agregar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(413, 5);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(59, 23);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "label4";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.Location = new Point(94, 113);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(65, 25);
            lblfecha.TabIndex = 32;
            lblfecha.Text = "label4";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(413, 113);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(123, 20);
            lblValor.TabIndex = 31;
            lblValor.Text = "VALOR UNITARIO";
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(413, 33);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(83, 20);
            lblCan.TabIndex = 30;
            lblCan.Text = "CANTIDAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 32);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 29;
            label1.Text = "CONCEPTO";
            // 
            // cboConcepto
            // 
            cboConcepto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConcepto.FormattingEnabled = true;
            cboConcepto.Items.AddRange(new object[] { "Venta", "Compra" });
            cboConcepto.Location = new Point(94, 56);
            cboConcepto.Margin = new Padding(3, 4, 3, 4);
            cboConcepto.Name = "cboConcepto";
            cboConcepto.Size = new Size(138, 28);
            cboConcepto.TabIndex = 28;
            cboConcepto.SelectedIndexChanged += CboConcepto_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(413, 57);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 27;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtValorU
            // 
            txtValorU.Location = new Point(413, 137);
            txtValorU.Margin = new Padding(3, 4, 3, 4);
            txtValorU.Name = "txtValorU";
            txtValorU.Size = new Size(114, 27);
            txtValorU.TabIndex = 26;
            txtValorU.TextChanged += txtValorU_TextChanged;
            txtValorU.KeyPress += txtValorU_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, CantidadE, ValorUnE, ValorTotE, CantidadS, ValorUnS, ValorTotS, CantidadSds, ValorUnSds, ValorTotSds });
            dataGridView1.Location = new Point(18, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1398, 330);
            dataGridView1.TabIndex = 25;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Resizable = DataGridViewTriState.True;
            Fecha.Width = 95;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.MinimumWidth = 6;
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            Concepto.Width = 125;
            // 
            // CantidadE
            // 
            CantidadE.HeaderText = "Cantidad";
            CantidadE.MinimumWidth = 6;
            CantidadE.Name = "CantidadE";
            CantidadE.ReadOnly = true;
            CantidadE.Width = 125;
            // 
            // ValorUnE
            // 
            ValorUnE.HeaderText = "Valor Unitario";
            ValorUnE.MinimumWidth = 6;
            ValorUnE.Name = "ValorUnE";
            ValorUnE.ReadOnly = true;
            ValorUnE.Width = 125;
            // 
            // ValorTotE
            // 
            ValorTotE.HeaderText = "Valor Total";
            ValorTotE.MinimumWidth = 6;
            ValorTotE.Name = "ValorTotE";
            ValorTotE.ReadOnly = true;
            ValorTotE.Width = 125;
            // 
            // CantidadS
            // 
            CantidadS.HeaderText = "Cantidad";
            CantidadS.MinimumWidth = 6;
            CantidadS.Name = "CantidadS";
            CantidadS.ReadOnly = true;
            CantidadS.Width = 125;
            // 
            // ValorUnS
            // 
            ValorUnS.HeaderText = "Valor Unitario";
            ValorUnS.MinimumWidth = 6;
            ValorUnS.Name = "ValorUnS";
            ValorUnS.ReadOnly = true;
            ValorUnS.Width = 125;
            // 
            // ValorTotS
            // 
            ValorTotS.HeaderText = "Valor Total";
            ValorTotS.MinimumWidth = 6;
            ValorTotS.Name = "ValorTotS";
            ValorTotS.ReadOnly = true;
            ValorTotS.Width = 125;
            // 
            // CantidadSds
            // 
            CantidadSds.HeaderText = "Cantidad";
            CantidadSds.MinimumWidth = 6;
            CantidadSds.Name = "CantidadSds";
            CantidadSds.ReadOnly = true;
            CantidadSds.Width = 125;
            // 
            // ValorUnSds
            // 
            ValorUnSds.HeaderText = "Valor Unitario";
            ValorUnSds.MinimumWidth = 6;
            ValorUnSds.Name = "ValorUnSds";
            ValorUnSds.ReadOnly = true;
            ValorUnSds.Width = 125;
            // 
            // ValorTotSds
            // 
            ValorTotSds.HeaderText = "Valor Total";
            ValorTotSds.MinimumWidth = 6;
            ValorTotSds.Name = "ValorTotSds";
            ValorTotSds.ReadOnly = true;
            ValorTotSds.Width = 125;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(255, 224, 192);
            btnInicio.Location = new Point(1293, 537);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 49);
            btnInicio.TabIndex = 37;
            btnInicio.Text = "🏠";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrar.Location = new Point(1170, 537);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 49);
            btnBorrar.TabIndex = 36;
            btnBorrar.Text = "🗑";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(255, 224, 192);
            btnExportar.Location = new Point(12, 539);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 47);
            btnExportar.TabIndex = 35;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmMetodoCpromo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 598);
            Controls.Add(btnInicio);
            Controls.Add(btnBorrar);
            Controls.Add(btnExportar);
            Controls.Add(btnAgg);
            Controls.Add(lblTitulo);
            Controls.Add(lblfecha);
            Controls.Add(lblValor);
            Controls.Add(lblCan);
            Controls.Add(label1);
            Controls.Add(cboConcepto);
            Controls.Add(txtCantidad);
            Controls.Add(txtValorU);
            Controls.Add(dataGridView1);
            Name = "frmMetodoCpromo";
            Text = "Método PROMEDIO";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgg;
        private Label lblTitulo;
        private Label lblfecha;
        private Label lblValor;
        private Label lblCan;
        private Label label1;
        private ComboBox cboConcepto;
        private TextBox txtCantidad;
        private TextBox txtValorU;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn CantidadE;
        private DataGridViewTextBoxColumn ValorUnE;
        private DataGridViewTextBoxColumn ValorTotE;
        private DataGridViewTextBoxColumn CantidadS;
        private DataGridViewTextBoxColumn ValorUnS;
        private DataGridViewTextBoxColumn ValorTotS;
        private DataGridViewTextBoxColumn CantidadSds;
        private DataGridViewTextBoxColumn ValorUnSds;
        private DataGridViewTextBoxColumn ValorTotSds;
        private Button btnInicio;
        private Button btnBorrar;
        private Button btnExportar;
    }
}