namespace PlanillaDePagoContCostos
{
    partial class frmMetodoUeps
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
            btnExportar = new Button();
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
            txtValorU = new TextBox();
            txtCantidad = new TextBox();
            cboConcepto = new ComboBox();
            label1 = new Label();
            lblCan = new Label();
            lblValor = new Label();
            lblfecha = new Label();
            btnBorrar = new Button();
            btnInicio = new Button();
            lblTitulo = new Label();
            btnAgg = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(255, 224, 192);
            btnExportar.Location = new Point(27, 530);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 47);
            btnExportar.TabIndex = 0;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, CantidadE, ValorUnE, ValorTotE, CantidadS, ValorUnS, ValorTotS, CantidadSds, ValorUnSds, ValorTotSds });
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1398, 330);
            dataGridView1.TabIndex = 1;
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
            // txtValorU
            // 
            txtValorU.Location = new Point(407, 141);
            txtValorU.Margin = new Padding(3, 4, 3, 4);
            txtValorU.Name = "txtValorU";
            txtValorU.Size = new Size(114, 27);
            txtValorU.TabIndex = 2;
            txtValorU.TextChanged += txtValorU_TextChanged;
            txtValorU.KeyPress += txtValorU_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(407, 61);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 3;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // cboConcepto
            // 
            cboConcepto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConcepto.FormattingEnabled = true;
            cboConcepto.Items.AddRange(new object[] { "Venta", "Compra" });
            cboConcepto.Location = new Point(88, 60);
            cboConcepto.Margin = new Padding(3, 4, 3, 4);
            cboConcepto.Name = "cboConcepto";
            cboConcepto.Size = new Size(138, 28);
            cboConcepto.TabIndex = 4;
            cboConcepto.SelectedIndexChanged += CboConcepto_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "CONCEPTO";
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(407, 37);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(83, 20);
            lblCan.TabIndex = 6;
            lblCan.Text = "CANTIDAD";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(407, 117);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(123, 20);
            lblValor.TabIndex = 7;
            lblValor.Text = "VALOR UNITARIO";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.Location = new Point(88, 117);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(65, 25);
            lblfecha.TabIndex = 8;
            lblfecha.Text = "label4";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 224, 192);
            btnBorrar.Location = new Point(1184, 537);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(101, 49);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "🗑";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(255, 224, 192);
            btnInicio.Location = new Point(1307, 537);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(105, 49);
            btnInicio.TabIndex = 12;
            btnInicio.Text = "🏠";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(407, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(59, 23);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "label4";
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(606, 140);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(94, 29);
            btnAgg.TabIndex = 14;
            btnAgg.Text = "Agregar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // frmMetodoUeps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 598);
            Controls.Add(btnAgg);
            Controls.Add(lblTitulo);
            Controls.Add(btnInicio);
            Controls.Add(btnBorrar);
            Controls.Add(lblfecha);
            Controls.Add(lblValor);
            Controls.Add(lblCan);
            Controls.Add(label1);
            Controls.Add(cboConcepto);
            Controls.Add(txtCantidad);
            Controls.Add(txtValorU);
            Controls.Add(dataGridView1);
            Controls.Add(btnExportar);
            Name = "frmMetodoUeps";
            Text = "Método UEPS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportar;
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
        private TextBox txtValorU;
        private TextBox txtCantidad;
        private ComboBox cboConcepto;
        private Label label1;
        private Label lblCan;
        private Label lblValor;
        private Label lblfecha;
        private Button btnBorrar;
        private Button btnInicio;
        private Label lblTitulo;
        private Button btnAgg;
    }
}