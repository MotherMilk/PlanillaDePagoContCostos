﻿namespace PlanillaDePagoContCostos
{
    partial class RegistroInventario
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
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            btnAceptar1 = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cboMt1
            // 
            cboMt1.FormattingEnabled = true;
            cboMt1.Items.AddRange(new object[] { "PEPS", "UEPS", "C/PROMO" });
            cboMt1.Location = new Point(40, 77);
            cboMt1.Name = "cboMt1";
            cboMt1.Size = new Size(121, 23);
            cboMt1.TabIndex = 0;
            cboMt1.SelectedIndexChanged += cboMt1_SelectedIndexChanged;
            // 
            // cboMt2
            // 
            cboMt2.FormattingEnabled = true;
            cboMt2.Items.AddRange(new object[] { "PEPS", "UEPS", "C/PROMO" });
            cboMt2.Location = new Point(42, 77);
            cboMt2.Name = "cboMt2";
            cboMt2.Size = new Size(121, 23);
            cboMt2.TabIndex = 1;
            cboMt2.SelectedIndexChanged += cboMt2_SelectedIndexChanged;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(210, 77);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "METODO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 4;
            label2.Text = "REGISTRO DE INVENTARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 47);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "METODO";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(123, 121);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 30);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAceptar1);
            groupBox1.Controls.Add(cboMt1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 169);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "REALIZAR REGISTRO";
            // 
            // btnAceptar1
            // 
            btnAceptar1.Location = new Point(40, 121);
            btnAceptar1.Name = "btnAceptar1";
            btnAceptar1.Size = new Size(123, 30);
            btnAceptar1.TabIndex = 7;
            btnAceptar1.Text = "ACEPTAR";
            btnAceptar1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboMt2);
            groupBox2.Controls.Add(cboProducto);
            groupBox2.Controls.Add(btnAceptar);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(262, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 169);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "VISULIZAR FICHERO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 47);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "PRODUCTO";
            // 
            // RegistroInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 255);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistroInventario";
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
        private Button btnAceptar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnAceptar1;
    }
}