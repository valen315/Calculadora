namespace WindowsFormsApp2
{
    partial class calculadora2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora2));
            this.cmdNumero7 = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.cmdNumero8 = new System.Windows.Forms.Button();
            this.bntDivision = new System.Windows.Forms.Button();
            this.cmdNumero9 = new System.Windows.Forms.Button();
            this.bntBorrar = new System.Windows.Forms.Button();
            this.cmdNumero5 = new System.Windows.Forms.Button();
            this.cmdNumero4 = new System.Windows.Forms.Button();
            this.cmdNumero6 = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.cmdNumero0 = new System.Windows.Forms.Button();
            this.bntPunto = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.cmdNumero1 = new System.Windows.Forms.Button();
            this.cmdNumero2 = new System.Windows.Forms.Button();
            this.cmdNumero3 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Historial = new System.Windows.Forms.Label();
            this.btnEliminarNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNumero7
            // 
            this.cmdNumero7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero7.Location = new System.Drawing.Point(22, 105);
            this.cmdNumero7.Name = "cmdNumero7";
            this.cmdNumero7.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero7.TabIndex = 0;
            this.cmdNumero7.Text = "7";
            this.cmdNumero7.UseVisualStyleBackColor = true;
            this.cmdNumero7.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(22, 47);
            this.txtPantalla.MaxLength = 16;
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(235, 33);
            this.txtPantalla.TabIndex = 1;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdNumero8
            // 
            this.cmdNumero8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero8.Location = new System.Drawing.Point(67, 105);
            this.cmdNumero8.Name = "cmdNumero8";
            this.cmdNumero8.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero8.TabIndex = 2;
            this.cmdNumero8.Text = "8";
            this.cmdNumero8.UseVisualStyleBackColor = true;
            this.cmdNumero8.Click += new System.EventHandler(this.Button_Click);
            // 
            // bntDivision
            // 
            this.bntDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bntDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDivision.Location = new System.Drawing.Point(161, 105);
            this.bntDivision.Name = "bntDivision";
            this.bntDivision.Size = new System.Drawing.Size(39, 35);
            this.bntDivision.TabIndex = 3;
            this.bntDivision.Text = "/";
            this.bntDivision.UseVisualStyleBackColor = false;
            this.bntDivision.Click += new System.EventHandler(this.Operador_Click);
            // 
            // cmdNumero9
            // 
            this.cmdNumero9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero9.Location = new System.Drawing.Point(112, 105);
            this.cmdNumero9.Name = "cmdNumero9";
            this.cmdNumero9.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero9.TabIndex = 4;
            this.cmdNumero9.Text = "9";
            this.cmdNumero9.UseVisualStyleBackColor = true;
            this.cmdNumero9.Click += new System.EventHandler(this.Button_Click);
            // 
            // bntBorrar
            // 
            this.bntBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBorrar.Location = new System.Drawing.Point(206, 105);
            this.bntBorrar.Name = "bntBorrar";
            this.bntBorrar.Size = new System.Drawing.Size(39, 35);
            this.bntBorrar.TabIndex = 5;
            this.bntBorrar.Text = "C";
            this.bntBorrar.UseVisualStyleBackColor = true;
            this.bntBorrar.Click += new System.EventHandler(this.bntBorrar_Click);
            // 
            // cmdNumero5
            // 
            this.cmdNumero5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero5.Location = new System.Drawing.Point(67, 146);
            this.cmdNumero5.Name = "cmdNumero5";
            this.cmdNumero5.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero5.TabIndex = 6;
            this.cmdNumero5.Text = "5";
            this.cmdNumero5.UseVisualStyleBackColor = true;
            this.cmdNumero5.Click += new System.EventHandler(this.Button_Click);
            // 
            // cmdNumero4
            // 
            this.cmdNumero4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero4.Location = new System.Drawing.Point(22, 146);
            this.cmdNumero4.Name = "cmdNumero4";
            this.cmdNumero4.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero4.TabIndex = 7;
            this.cmdNumero4.Text = "4";
            this.cmdNumero4.UseVisualStyleBackColor = true;
            this.cmdNumero4.Click += new System.EventHandler(this.Button_Click);
            // 
            // cmdNumero6
            // 
            this.cmdNumero6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero6.Location = new System.Drawing.Point(112, 146);
            this.cmdNumero6.Name = "cmdNumero6";
            this.cmdNumero6.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero6.TabIndex = 8;
            this.cmdNumero6.Text = "6";
            this.cmdNumero6.UseVisualStyleBackColor = true;
            this.cmdNumero6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(161, 146);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(39, 35);
            this.btnResta.TabIndex = 9;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.Operador_Click);
            // 
            // cmdNumero0
            // 
            this.cmdNumero0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero0.Location = new System.Drawing.Point(22, 228);
            this.cmdNumero0.Name = "cmdNumero0";
            this.cmdNumero0.Size = new System.Drawing.Size(84, 35);
            this.cmdNumero0.TabIndex = 10;
            this.cmdNumero0.Text = "0";
            this.cmdNumero0.UseVisualStyleBackColor = true;
            this.cmdNumero0.Click += new System.EventHandler(this.Button_Click);
            // 
            // bntPunto
            // 
            this.bntPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPunto.Location = new System.Drawing.Point(112, 228);
            this.bntPunto.Name = "bntPunto";
            this.bntPunto.Size = new System.Drawing.Size(39, 35);
            this.bntPunto.TabIndex = 11;
            this.bntPunto.Text = ".";
            this.bntPunto.UseVisualStyleBackColor = true;
            this.bntPunto.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(161, 228);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(39, 35);
            this.btnSuma.TabIndex = 12;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.Operador_Click);
            // 
            // cmdNumero1
            // 
            this.cmdNumero1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero1.Location = new System.Drawing.Point(22, 187);
            this.cmdNumero1.Name = "cmdNumero1";
            this.cmdNumero1.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero1.TabIndex = 13;
            this.cmdNumero1.Text = "1";
            this.cmdNumero1.UseVisualStyleBackColor = true;
            this.cmdNumero1.Click += new System.EventHandler(this.Button_Click);
            // 
            // cmdNumero2
            // 
            this.cmdNumero2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero2.Location = new System.Drawing.Point(67, 187);
            this.cmdNumero2.Name = "cmdNumero2";
            this.cmdNumero2.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero2.TabIndex = 14;
            this.cmdNumero2.Text = "2";
            this.cmdNumero2.UseVisualStyleBackColor = true;
            this.cmdNumero2.Click += new System.EventHandler(this.Button_Click);
            // 
            // cmdNumero3
            // 
            this.cmdNumero3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNumero3.Location = new System.Drawing.Point(112, 187);
            this.cmdNumero3.Name = "cmdNumero3";
            this.cmdNumero3.Size = new System.Drawing.Size(39, 35);
            this.cmdNumero3.TabIndex = 15;
            this.cmdNumero3.Text = "3";
            this.cmdNumero3.UseVisualStyleBackColor = true;
            this.cmdNumero3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(161, 187);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(39, 35);
            this.btnMultiplicacion.TabIndex = 16;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(206, 187);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(39, 76);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            this.label1.Visible = false;
            // 
            // Historial
            // 
            this.Historial.Location = new System.Drawing.Point(26, 18);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(231, 23);
            this.Historial.TabIndex = 0;
            // 
            // btnEliminarNumero
            // 
            this.btnEliminarNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNumero.Location = new System.Drawing.Point(206, 146);
            this.btnEliminarNumero.Name = "btnEliminarNumero";
            this.btnEliminarNumero.Size = new System.Drawing.Size(39, 35);
            this.btnEliminarNumero.TabIndex = 19;
            this.btnEliminarNumero.Text = "<<<";
            this.btnEliminarNumero.UseVisualStyleBackColor = true;
            this.btnEliminarNumero.Click += new System.EventHandler(this.btnEliminarNumero_Click);
            // 
            // calculadora2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 296);
            this.Controls.Add(this.btnEliminarNumero);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.cmdNumero3);
            this.Controls.Add(this.cmdNumero2);
            this.Controls.Add(this.cmdNumero1);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.bntPunto);
            this.Controls.Add(this.cmdNumero0);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.cmdNumero6);
            this.Controls.Add(this.cmdNumero4);
            this.Controls.Add(this.cmdNumero5);
            this.Controls.Add(this.bntBorrar);
            this.Controls.Add(this.cmdNumero9);
            this.Controls.Add(this.bntDivision);
            this.Controls.Add(this.cmdNumero8);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.cmdNumero7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora2";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.calculadora2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNumero7;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button cmdNumero8;
        private System.Windows.Forms.Button bntDivision;
        private System.Windows.Forms.Button cmdNumero9;
        private System.Windows.Forms.Button bntBorrar;
        private System.Windows.Forms.Button cmdNumero5;
        private System.Windows.Forms.Button cmdNumero4;
        private System.Windows.Forms.Button cmdNumero6;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button cmdNumero0;
        private System.Windows.Forms.Button bntPunto;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button cmdNumero1;
        private System.Windows.Forms.Button cmdNumero2;
        private System.Windows.Forms.Button cmdNumero3;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Historial;
        private System.Windows.Forms.Button btnEliminarNumero;
    }
}