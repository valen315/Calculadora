namespace WindowsFormsApp2
{
    partial class EnvioDeMail
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.TextBox();
            this.btnAsunto = new System.Windows.Forms.TextBox();
            this.btnMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Alerta = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImpotarImagen = new System.Windows.Forms.Button();
            this.ImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.AgregarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Location = new System.Drawing.Point(836, 396);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(128, 41);
            this.BtnEnviar.TabIndex = 0;
            this.BtnEnviar.Text = "ENVIAR";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnPara
            // 
            this.btnPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPara.Location = new System.Drawing.Point(138, 60);
            this.btnPara.Multiline = true;
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(355, 39);
            this.btnPara.TabIndex = 1;
            // 
            // btnAsunto
            // 
            this.btnAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsunto.Location = new System.Drawing.Point(138, 118);
            this.btnAsunto.Name = "btnAsunto";
            this.btnAsunto.Size = new System.Drawing.Size(355, 24);
            this.btnAsunto.TabIndex = 2;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensaje.Location = new System.Drawing.Point(138, 163);
            this.btnMensaje.Multiline = true;
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(355, 225);
            this.btnMensaje.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asunto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensaje :";
            // 
            // Alerta
            // 
            this.Alerta.AutoSize = true;
            this.Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alerta.Location = new System.Drawing.Point(814, 25);
            this.Alerta.Name = "Alerta";
            this.Alerta.Size = new System.Drawing.Size(122, 18);
            this.Alerta.TabIndex = 7;
            this.Alerta.Text = "Mensaje envida!!!!";
            this.Alerta.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ImpotarImagen
            // 
            this.ImpotarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpotarImagen.Location = new System.Drawing.Point(562, 213);
            this.ImpotarImagen.Name = "ImpotarImagen";
            this.ImpotarImagen.Size = new System.Drawing.Size(189, 31);
            this.ImpotarImagen.TabIndex = 8;
            this.ImpotarImagen.Text = "Importar imagen principal";
            this.ImpotarImagen.UseVisualStyleBackColor = true;
            this.ImpotarImagen.Click += new System.EventHandler(this.ImpotarImagen_Click);
            // 
            // ImagenPrincipal
            // 
            this.ImagenPrincipal.Location = new System.Drawing.Point(562, 60);
            this.ImagenPrincipal.Name = "ImagenPrincipal";
            this.ImagenPrincipal.Size = new System.Drawing.Size(188, 147);
            this.ImagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPrincipal.TabIndex = 9;
            this.ImagenPrincipal.TabStop = false;
            // 
            // AgregarArchivo
            // 
            this.AgregarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarArchivo.Location = new System.Drawing.Point(562, 267);
            this.AgregarArchivo.Name = "AgregarArchivo";
            this.AgregarArchivo.Size = new System.Drawing.Size(188, 28);
            this.AgregarArchivo.TabIndex = 10;
            this.AgregarArchivo.Text = "Agregar archivos";
            this.AgregarArchivo.UseVisualStyleBackColor = true;
            // 
            // EnvioDeMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 449);
            this.Controls.Add(this.AgregarArchivo);
            this.Controls.Add(this.ImagenPrincipal);
            this.Controls.Add(this.ImpotarImagen);
            this.Controls.Add(this.Alerta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMensaje);
            this.Controls.Add(this.btnAsunto);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.BtnEnviar);
            this.Name = "EnvioDeMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnvioDeMail";
            this.Load += new System.EventHandler(this.EnvioDeMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox btnPara;
        private System.Windows.Forms.TextBox btnAsunto;
        private System.Windows.Forms.TextBox btnMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Alerta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ImpotarImagen;
        private System.Windows.Forms.Button AgregarArchivo;
        private System.Windows.Forms.PictureBox ImagenPrincipal;
    }
}

