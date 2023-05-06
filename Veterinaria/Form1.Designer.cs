namespace Veterinaria
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnModuloCliente = new System.Windows.Forms.Button();
            this.btnModuloMascota = new System.Windows.Forms.Button();
            this.btnModuloVacuna = new System.Windows.Forms.Button();
            this.btnModuloDesparasitacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pets Healty";
            // 
            // btnModuloCliente
            // 
            this.btnModuloCliente.BackColor = System.Drawing.Color.Tomato;
            this.btnModuloCliente.ForeColor = System.Drawing.Color.Snow;
            this.btnModuloCliente.Location = new System.Drawing.Point(25, 134);
            this.btnModuloCliente.Name = "btnModuloCliente";
            this.btnModuloCliente.Size = new System.Drawing.Size(210, 87);
            this.btnModuloCliente.TabIndex = 1;
            this.btnModuloCliente.Text = "Registro Clientes";
            this.btnModuloCliente.UseVisualStyleBackColor = false;
            this.btnModuloCliente.Click += new System.EventHandler(this.btnModuloCliente_Click);
            // 
            // btnModuloMascota
            // 
            this.btnModuloMascota.BackColor = System.Drawing.Color.Tomato;
            this.btnModuloMascota.ForeColor = System.Drawing.Color.Snow;
            this.btnModuloMascota.Location = new System.Drawing.Point(578, 134);
            this.btnModuloMascota.Name = "btnModuloMascota";
            this.btnModuloMascota.Size = new System.Drawing.Size(210, 87);
            this.btnModuloMascota.TabIndex = 2;
            this.btnModuloMascota.Text = "Registro Veterinario";
            this.btnModuloMascota.UseVisualStyleBackColor = false;
            this.btnModuloMascota.Click += new System.EventHandler(this.btnModuloMascota_Click);
            // 
            // btnModuloVacuna
            // 
            this.btnModuloVacuna.BackColor = System.Drawing.Color.Tomato;
            this.btnModuloVacuna.ForeColor = System.Drawing.Color.Snow;
            this.btnModuloVacuna.Location = new System.Drawing.Point(142, 267);
            this.btnModuloVacuna.Name = "btnModuloVacuna";
            this.btnModuloVacuna.Size = new System.Drawing.Size(210, 87);
            this.btnModuloVacuna.TabIndex = 3;
            this.btnModuloVacuna.Text = "Desparasitación";
            this.btnModuloVacuna.UseVisualStyleBackColor = false;
            this.btnModuloVacuna.Click += new System.EventHandler(this.btnModuloVacuna_Click);
            // 
            // btnModuloDesparasitacion
            // 
            this.btnModuloDesparasitacion.BackColor = System.Drawing.Color.Tomato;
            this.btnModuloDesparasitacion.ForeColor = System.Drawing.Color.Snow;
            this.btnModuloDesparasitacion.Location = new System.Drawing.Point(483, 267);
            this.btnModuloDesparasitacion.Name = "btnModuloDesparasitacion";
            this.btnModuloDesparasitacion.Size = new System.Drawing.Size(210, 87);
            this.btnModuloDesparasitacion.TabIndex = 4;
            this.btnModuloDesparasitacion.Text = "Vacunas";
            this.btnModuloDesparasitacion.UseVisualStyleBackColor = false;
            this.btnModuloDesparasitacion.Click += new System.EventHandler(this.btnModuloDesparasitacion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(289, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registro Mascota";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModuloDesparasitacion);
            this.Controls.Add(this.btnModuloVacuna);
            this.Controls.Add(this.btnModuloMascota);
            this.Controls.Add(this.btnModuloCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModuloCliente;
        private System.Windows.Forms.Button btnModuloMascota;
        private System.Windows.Forms.Button btnModuloVacuna;
        private System.Windows.Forms.Button btnModuloDesparasitacion;
        private System.Windows.Forms.Button button1;
    }
}

