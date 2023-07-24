namespace testFormsTFG.GestionProyectos
{
    partial class GestionProyectos
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.getEvents = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1088, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(12, 91);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(28, 39);
            this.test.TabIndex = 1;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getEvents
            // 
            this.getEvents.Interval = 10000;
            this.getEvents.Tick += new System.EventHandler(this.getEvents_Tick);
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 686);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Name = "GestionProyectos";
            this.Text = "Gestión de Proyectos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Timer getEvents;
    }
}