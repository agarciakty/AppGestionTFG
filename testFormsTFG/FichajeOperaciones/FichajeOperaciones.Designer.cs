namespace testFormsTFG.FichajeOperaciones
{
    partial class FichajeOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichajeOperaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbInvOper = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbOperario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOps = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIni = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelNomPro = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarPanel3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelParcela = new System.Windows.Forms.Label();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.labelParcelasPieza = new System.Windows.Forms.Label();
            this.labelProy = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOps)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInvOper
            // 
            this.tbInvOper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInvOper.Location = new System.Drawing.Point(1425, 12);
            this.tbInvOper.Name = "tbInvOper";
            this.tbInvOper.Size = new System.Drawing.Size(100, 20);
            this.tbInvOper.TabIndex = 0;
            this.tbInvOper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 89);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbOperario
            // 
            this.tbOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperario.Location = new System.Drawing.Point(219, 47);
            this.tbOperario.Name = "tbOperario";
            this.tbOperario.ReadOnly = true;
            this.tbOperario.Size = new System.Drawing.Size(630, 45);
            this.tbOperario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPERARIO";
            // 
            // dgvOps
            // 
            this.dgvOps.AllowUserToAddRows = false;
            this.dgvOps.AllowUserToDeleteRows = false;
            this.dgvOps.AllowUserToResizeRows = false;
            this.dgvOps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOps.Location = new System.Drawing.Point(12, 161);
            this.dgvOps.MultiSelect = false;
            this.dgvOps.Name = "dgvOps";
            this.dgvOps.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOps.Size = new System.Drawing.Size(1182, 655);
            this.dgvOps.TabIndex = 4;
            this.dgvOps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOps_CellContentClick);
            this.dgvOps.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvOps_RowStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "OPERACIONES PENDIENTES";
            // 
            // cbProy
            // 
            this.cbProy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProy.FormattingEnabled = true;
            this.cbProy.Location = new System.Drawing.Point(1326, 46);
            this.cbProy.Name = "cbProy";
            this.cbProy.Size = new System.Drawing.Size(198, 46);
            this.cbProy.TabIndex = 6;
            this.cbProy.SelectedIndexChanged += new System.EventHandler(this.cbProy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1104, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "PROYECTO";
            // 
            // btnIni
            // 
            this.btnIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIni.BackColor = System.Drawing.Color.Yellow;
            this.btnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.Location = new System.Drawing.Point(1199, 462);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(325, 124);
            this.btnIni.TabIndex = 8;
            this.btnIni.Text = "INICIO";
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Location = new System.Drawing.Point(1200, 592);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(325, 124);
            this.btnFin.TabIndex = 9;
            this.btnFin.Text = "FIN";
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1200, 722);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(325, 94);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelNomPro
            // 
            this.labelNomPro.AutoSize = true;
            this.labelNomPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPro.Location = new System.Drawing.Point(1200, 161);
            this.labelNomPro.Name = "labelNomPro";
            this.labelNomPro.Size = new System.Drawing.Size(173, 30);
            this.labelNomPro.TabIndex = 11;
            this.labelNomPro.Text = "PROYECTO:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1255, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 89);
            this.button2.TabIndex = 12;
            this.button2.Text = "INFO ALMACÉN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.labelParcelasPieza);
            this.panel1.Controls.Add(this.dgvParcelas);
            this.panel1.Controls.Add(this.btnCerrarPanel3);
            this.panel1.Location = new System.Drawing.Point(231, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 550);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // btnCerrarPanel3
            // 
            this.btnCerrarPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrarPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPanel3.Location = new System.Drawing.Point(758, 6);
            this.btnCerrarPanel3.Name = "btnCerrarPanel3";
            this.btnCerrarPanel3.Size = new System.Drawing.Size(58, 50);
            this.btnCerrarPanel3.TabIndex = 52;
            this.btnCerrarPanel3.Text = "X";
            this.btnCerrarPanel3.UseVisualStyleBackColor = false;
            this.btnCerrarPanel3.Click += new System.EventHandler(this.btnCerrarPanel3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1200, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "PARCELA MATERIAL:";
            // 
            // labelParcela
            // 
            this.labelParcela.AutoSize = true;
            this.labelParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcela.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelParcela.Location = new System.Drawing.Point(1244, 268);
            this.labelParcela.Name = "labelParcela";
            this.labelParcela.Size = new System.Drawing.Size(46, 63);
            this.labelParcela.TabIndex = 15;
            this.labelParcela.Text = "-";
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.AllowUserToResizeColumns = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvParcelas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(27, 99);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(768, 342);
            this.dgvParcelas.TabIndex = 53;
            // 
            // labelParcelasPieza
            // 
            this.labelParcelasPieza.AutoSize = true;
            this.labelParcelasPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcelasPieza.Location = new System.Drawing.Point(20, 19);
            this.labelParcelasPieza.Name = "labelParcelasPieza";
            this.labelParcelasPieza.Size = new System.Drawing.Size(28, 39);
            this.labelParcelasPieza.TabIndex = 54;
            this.labelParcelasPieza.Text = "-";
            // 
            // labelProy
            // 
            this.labelProy.AutoSize = true;
            this.labelProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProy.Location = new System.Drawing.Point(1379, 161);
            this.labelProy.Name = "labelProy";
            this.labelProy.Size = new System.Drawing.Size(23, 30);
            this.labelProy.TabIndex = 16;
            this.labelProy.Text = "-";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(521, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 92);
            this.button3.TabIndex = 55;
            this.button3.Text = "SELECCIONAR PARCELA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FichajeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 828);
            this.Controls.Add(this.labelProy);
            this.Controls.Add(this.labelParcela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelNomPro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOperario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbInvOper);
            this.Name = "FichajeOperaciones";
            this.Text = "FichajeOperaciones";
            this.Load += new System.EventHandler(this.FichajeOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOps)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvOper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOperario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelNomPro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelParcela;
        private System.Windows.Forms.Label labelParcelasPieza;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Label labelProy;
        private System.Windows.Forms.Button button3;
    }
}