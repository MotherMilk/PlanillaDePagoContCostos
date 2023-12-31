﻿namespace PlanillaDePagoContCostos
{
    partial class frmRegistroInventario
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
            cboMt1 = new ComboBox();
            cboMt2 = new ComboBox();
            cboProducto = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAceptarF = new Button();
            groupBox1 = new GroupBox();
            btnAceptarR = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            btnCerrarPrograma = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cboMt1
            // 
            cboMt1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMt1.FormattingEnabled = true;
            cboMt1.Items.AddRange(new object[] { "UEPS", "PEPS", "C/PROMO" });
            cboMt1.Location = new Point(46, 103);
            cboMt1.Margin = new Padding(3, 4, 3, 4);
            cboMt1.Name = "cboMt1";
            cboMt1.Size = new Size(138, 28);
            cboMt1.TabIndex = 0;
            cboMt1.SelectedIndexChanged += cboMt1_SelectedIndexChanged;
            // 
            // cboMt2
            // 
            cboMt2.FormattingEnabled = true;
            cboMt2.Items.AddRange(new object[] { "PEPS", "UEPS", "C/PROMO" });
            cboMt2.Location = new Point(48, 103);
            cboMt2.Margin = new Padding(3, 4, 3, 4);
            cboMt2.Name = "cboMt2";
            cboMt2.Size = new Size(138, 28);
            cboMt2.TabIndex = 1;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(240, 103);
            cboProducto.Margin = new Padding(3, 4, 3, 4);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(138, 28);
            cboProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 63);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "METODO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 12);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 4;
            label2.Text = "REGISTRO DE INVENTARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 63);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "METODO";
            // 
            // btnAceptarF
            // 
            btnAceptarF.Location = new Point(141, 161);
            btnAceptarF.Margin = new Padding(3, 4, 3, 4);
            btnAceptarF.Name = "btnAceptarF";
            btnAceptarF.Size = new Size(141, 40);
            btnAceptarF.TabIndex = 6;
            btnAceptarF.Text = "ACEPTAR";
            btnAceptarF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAceptarR);
            groupBox1.Controls.Add(cboMt1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 36);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(261, 225);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "REALIZAR REGISTRO";
            // 
            // btnAceptarR
            // 
            btnAceptarR.Location = new Point(46, 161);
            btnAceptarR.Margin = new Padding(3, 4, 3, 4);
            btnAceptarR.Name = "btnAceptarR";
            btnAceptarR.Size = new Size(141, 40);
            btnAceptarR.TabIndex = 7;
            btnAceptarR.Text = "ACEPTAR";
            btnAceptarR.UseVisualStyleBackColor = true;
            btnAceptarR.Click += btnAceptarR_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboMt2);
            groupBox2.Controls.Add(cboProducto);
            groupBox2.Controls.Add(btnAceptarF);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(299, 36);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(427, 225);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "VISULIZAR FICHERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 63);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "PRODUCTO";
            // 
            // btnCerrarPrograma
            // 
            btnCerrarPrograma.Location = new Point(14, 288);
            btnCerrarPrograma.Margin = new Padding(3, 4, 3, 4);
            btnCerrarPrograma.Name = "btnCerrarPrograma";
            btnCerrarPrograma.Size = new Size(86, 36);
            btnCerrarPrograma.TabIndex = 9;
            btnCerrarPrograma.Text = "SALIR";
            btnCerrarPrograma.UseVisualStyleBackColor = true;
            btnCerrarPrograma.Click += btnCerrarPrograma_Click;
            // 
            // frmRegistroInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 340);
            Controls.Add(btnCerrarPrograma);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistroInventario";
            Text = "REGISTRO DE INVENTARIO";
            Load += RegistroInventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMt1;
        private ComboBox cboMt2;
        private ComboBox cboProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptarF;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnAceptarR;
        private Button btnCerrarPrograma;
    }
}