namespace ImeApps
{
    partial class BotonAplicacion
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(3, 0);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(249, 106);
            this.btnImagen.TabIndex = 1;
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTexto.Location = new System.Drawing.Point(3, 112);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(249, 42);
            this.btnTexto.TabIndex = 7;
            this.btnTexto.UseVisualStyleBackColor = false;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // BotonAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.btnImagen);
            this.Name = "BotonAplicacion";
            this.Size = new System.Drawing.Size(255, 157);
            this.Load += new System.EventHandler(this.BotonAplicacion_Load);
            this.Click += new System.EventHandler(this.BotonAplicacion_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnTexto;
    }
}
