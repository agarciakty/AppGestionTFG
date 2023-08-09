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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOps)).BeginInit();
            this.SuspendLayout();
            // 
            // tbInvOper
            // 
            this.tbInvOper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInvOper.Location = new System.Drawing.Point(1202, 12);
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
            this.dgvOps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOps.Location = new System.Drawing.Point(12, 161);
            this.dgvOps.Name = "dgvOps";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOps.Size = new System.Drawing.Size(959, 655);
            this.dgvOps.TabIndex = 4;
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
            this.cbProy.Location = new System.Drawing.Point(1104, 116);
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
            this.label3.Location = new System.Drawing.Point(882, 119);
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
            this.btnIni.Location = new System.Drawing.Point(977, 204);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(325, 124);
            this.btnIni.TabIndex = 8;
            this.btnIni.Text = "INICIO";
            this.btnIni.UseVisualStyleBackColor = false;
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Location = new System.Drawing.Point(978, 334);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(325, 124);
            this.btnFin.TabIndex = 9;
            this.btnFin.Text = "FIN";
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(978, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(325, 94);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FichajeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 828);
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
    }
}