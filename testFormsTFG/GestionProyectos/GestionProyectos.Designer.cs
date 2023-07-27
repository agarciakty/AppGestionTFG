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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProyectos));
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.getEvents = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.treeViewProys = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbProys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFIni = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 606);
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
            this.test.Location = new System.Drawing.Point(12, 540);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(28, 39);
            this.test.TabIndex = 1;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getEvents
            // 
            this.getEvents.Enabled = true;
            this.getEvents.Interval = 5000;
            this.getEvents.Tick += new System.EventHandler(this.getEvents_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeViewProys
            // 
            this.treeViewProys.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewProys.FullRowSelect = true;
            this.treeViewProys.Location = new System.Drawing.Point(12, 207);
            this.treeViewProys.Name = "treeViewProys";
            this.treeViewProys.Size = new System.Drawing.Size(1214, 330);
            this.treeViewProys.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1161, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "ELIMINAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1055, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "NUEVO\r\nPROYECTO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(1164, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 60);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(1063, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 60);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // cbProys
            // 
            this.cbProys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProys.FormattingEnabled = true;
            this.cbProys.Location = new System.Drawing.Point(227, 12);
            this.cbProys.Name = "cbProys";
            this.cbProys.Size = new System.Drawing.Size(176, 33);
            this.cbProys.TabIndex = 38;
            this.cbProys.SelectedIndexChanged += new System.EventHandler(this.cbProys_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 39;
            this.label1.Text = "PROYECTO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(462, 39);
            this.label12.TabIndex = 48;
            this.label12.Text = "ESTRUCTURA DE PIEZAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelFIni);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.labelDesc);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 99);
            this.panel1.TabIndex = 49;
            // 
            // labelFIni
            // 
            this.labelFIni.AutoSize = true;
            this.labelFIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIni.Location = new System.Drawing.Point(654, 53);
            this.labelFIni.Name = "labelFIni";
            this.labelFIni.Size = new System.Drawing.Size(98, 25);
            this.labelFIni.TabIndex = 55;
            this.labelFIni.Text = "NOMBRE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 25);
            this.label11.TabIndex = 54;
            this.label11.Text = "FECHA DE INICIO";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(654, 12);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(98, 25);
            this.labelCliente.TabIndex = 53;
            this.labelCliente.Text = "NOMBRE";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(205, 53);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(98, 25);
            this.labelDesc.TabIndex = 52;
            this.labelDesc.Text = "NOMBRE";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(205, 12);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(98, 25);
            this.labelNom.TabIndex = 51;
            this.labelNom.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "CLIENTE";
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProys);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.treeViewProys);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Name = "GestionProyectos";
            this.Text = "Gestión de Proyectos";
            this.Load += new System.EventHandler(this.GestionProyectos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Timer getEvents;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeViewProys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbProys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFIni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}