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
            button1 = new Button();
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblfecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 341);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 0;
            button1.Text = "EXPORTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, Concepto, CantidadE, ValorUnE, ValorTotE, CantidadS, ValorUnS, ValorTotS, CantidadSds, ValorUnSds, ValorTotSds });
            dataGridView1.Location = new Point(24, 148);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 179);
            dataGridView1.TabIndex = 1;
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
            // textBox1
            // 
            textBox1.Location = new Point(354, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(354, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 27);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "CONCEPTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 19);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 79);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 7;
            label3.Text = "VALOR UNITARIO";
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblfecha.Location = new Point(77, 97);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(51, 20);
            lblfecha.TabIndex = 8;
            lblfecha.Text = "label4";
            // 
            // frmMetodoUeps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 387);
            Controls.Add(lblfecha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMetodoUeps";
            Text = "Método UEPS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblfecha;
    }
}