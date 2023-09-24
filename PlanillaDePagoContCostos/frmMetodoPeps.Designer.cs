namespace PlanillaDePagoContCostos
{
    partial class frmMetodoPeps
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, CantidadE, ValorUnE, ValorTotE, CantidadS, ValorUnS, ValorTotS, CantidadSds, ValorUnSds, ValorTotSds });
            dataGridView1.Location = new Point(25, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(750, 226);
            dataGridView1.TabIndex = 2;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Resizable = DataGridViewTriState.True;
            Fecha.Width = 95;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Concepto";
            Concepto.MinimumWidth = 6;
            Concepto.Name = "Concepto";
            Concepto.Width = 125;
            // 
            // CantidadE
            // 
            CantidadE.HeaderText = "Cantidad";
            CantidadE.MinimumWidth = 6;
            CantidadE.Name = "CantidadE";
            CantidadE.Width = 125;
            // 
            // ValorUnE
            // 
            ValorUnE.HeaderText = "Valor Unitario";
            ValorUnE.MinimumWidth = 6;
            ValorUnE.Name = "ValorUnE";
            ValorUnE.Width = 125;
            // 
            // ValorTotE
            // 
            ValorTotE.HeaderText = "Valor Total";
            ValorTotE.MinimumWidth = 6;
            ValorTotE.Name = "ValorTotE";
            ValorTotE.Width = 125;
            // 
            // CantidadS
            // 
            CantidadS.HeaderText = "Cantidad";
            CantidadS.MinimumWidth = 6;
            CantidadS.Name = "CantidadS";
            CantidadS.Width = 125;
            // 
            // ValorUnS
            // 
            ValorUnS.HeaderText = "Valor Unitario";
            ValorUnS.MinimumWidth = 6;
            ValorUnS.Name = "ValorUnS";
            ValorUnS.Width = 125;
            // 
            // ValorTotS
            // 
            ValorTotS.HeaderText = "Valor Total";
            ValorTotS.MinimumWidth = 6;
            ValorTotS.Name = "ValorTotS";
            ValorTotS.Width = 125;
            // 
            // CantidadSds
            // 
            CantidadSds.HeaderText = "Cantidad";
            CantidadSds.MinimumWidth = 6;
            CantidadSds.Name = "CantidadSds";
            CantidadSds.Width = 125;
            // 
            // ValorUnSds
            // 
            ValorUnSds.HeaderText = "Valor Unitario";
            ValorUnSds.MinimumWidth = 6;
            ValorUnSds.Name = "ValorUnSds";
            ValorUnSds.Width = 125;
            // 
            // ValorTotSds
            // 
            ValorTotSds.HeaderText = "Valor Total";
            ValorTotSds.MinimumWidth = 6;
            ValorTotSds.Name = "ValorTotSds";
            ValorTotSds.Width = 125;
            // 
            // frmMetodoPeps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "frmMetodoPeps";
            Text = "Método PEPS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
    }
}