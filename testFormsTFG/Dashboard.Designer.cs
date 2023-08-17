using ImeApps;

namespace testFormsTFG
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonal = new ImeApps.BotonAplicacion();
            this.btnRecMP = new ImeApps.BotonAplicacion();
            this.btnOps = new ImeApps.BotonAplicacion();
            this.btnArt = new ImeApps.BotonAplicacion();
            this.btnProys = new ImeApps.BotonAplicacion();
            this.btnPaqs = new ImeApps.BotonAplicacion();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "TFG APPS";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(622, 16);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(34, 46);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnPersonal);
            this.flowLayoutPanel1.Controls.Add(this.btnRecMP);
            this.flowLayoutPanel1.Controls.Add(this.btnOps);
            this.flowLayoutPanel1.Controls.Add(this.btnArt);
            this.flowLayoutPanel1.Controls.Add(this.btnProys);
            this.flowLayoutPanel1.Controls.Add(this.btnPaqs);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 97);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 346);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUCCIÓN";
            // 
            // btnPersonal
            // 
            this.btnPersonal.Imagen = ((System.Drawing.Image)(resources.GetObject("btnPersonal.Imagen")));
            this.btnPersonal.Location = new System.Drawing.Point(13, 13);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(255, 157);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Texto = "CONTROL DE PERSONAL";
            this.btnPersonal.Load += new System.EventHandler(this.btnPersonal_Load);
            // 
            // btnRecMP
            // 
            this.btnRecMP.Imagen = ((System.Drawing.Image)(resources.GetObject("btnRecMP.Imagen")));
            this.btnRecMP.Location = new System.Drawing.Point(274, 13);
            this.btnRecMP.Name = "btnRecMP";
            this.btnRecMP.Size = new System.Drawing.Size(255, 157);
            this.btnRecMP.TabIndex = 3;
            this.btnRecMP.Texto = "RECEPCIÓN MATERIA PRIMA";
            this.btnRecMP.Load += new System.EventHandler(this.btnRecMP_Load);
            // 
            // btnOps
            // 
            this.btnOps.Imagen = ((System.Drawing.Image)(resources.GetObject("btnOps.Imagen")));
            this.btnOps.Location = new System.Drawing.Point(535, 13);
            this.btnOps.Name = "btnOps";
            this.btnOps.Size = new System.Drawing.Size(255, 157);
            this.btnOps.TabIndex = 2;
            this.btnOps.Texto = "FICHAJE OPERACIONES";
            this.btnOps.Load += new System.EventHandler(this.btnOps_Load);
            // 
            // btnArt
            // 
            this.btnArt.Imagen = ((System.Drawing.Image)(resources.GetObject("btnArt.Imagen")));
            this.btnArt.Location = new System.Drawing.Point(13, 176);
            this.btnArt.Name = "btnArt";
            this.btnArt.Size = new System.Drawing.Size(255, 157);
            this.btnArt.TabIndex = 1;
            this.btnArt.Texto = "LSITADO DE ARTÍCULOS";
            this.btnArt.Load += new System.EventHandler(this.btnArt_Load);
            // 
            // btnProys
            // 
            this.btnProys.Imagen = ((System.Drawing.Image)(resources.GetObject("btnProys.Imagen")));
            this.btnProys.Location = new System.Drawing.Point(274, 176);
            this.btnProys.Name = "btnProys";
            this.btnProys.Size = new System.Drawing.Size(255, 157);
            this.btnProys.TabIndex = 5;
            this.btnProys.Texto = "GESTIÓN DE PROYECTOS";
            this.btnProys.Load += new System.EventHandler(this.btnProys_Load);
            // 
            // btnPaqs
            // 
            this.btnPaqs.Imagen = ((System.Drawing.Image)(resources.GetObject("btnPaqs.Imagen")));
            this.btnPaqs.Location = new System.Drawing.Point(535, 176);
            this.btnPaqs.Name = "btnPaqs";
            this.btnPaqs.Size = new System.Drawing.Size(255, 157);
            this.btnPaqs.TabIndex = 4;
            this.btnPaqs.Texto = "LOCALIZACIÓN DE PAQUETES";
            this.btnPaqs.Load += new System.EventHandler(this.btnPaqs_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ImeApps.BotonAplicacion btnPersonal;
        private ImeApps.BotonAplicacion btnArt;
        private ImeApps.BotonAplicacion btnOps;
        private ImeApps.BotonAplicacion btnRecMP;
        private ImeApps.BotonAplicacion btnPaqs;
        private ImeApps.BotonAplicacion btnProys;
        private System.Windows.Forms.Label label2;
    }
}