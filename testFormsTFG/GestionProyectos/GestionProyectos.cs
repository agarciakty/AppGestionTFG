﻿using Aspose.Email.Clients.Google;
using Aspose.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Google.Apis.Calendar.v3.Data;
using AppGestionTFG;
using System.Web.UI.WebControls.WebParts;
using DocumentFormat.OpenXml.EMMA;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.Xml.Linq;
using OfficeOpenXml.Style;

namespace testFormsTFG.GestionProyectos
{
    public partial class GestionProyectos : Form
    {
        static string[] Scopes = { CalendarService.Scope.Calendar };
        static string ApplicationName = "AppGestionTFG";

        FuncionesBD fbd = new FuncionesBD();

        DataTable datosPiezas = new DataTable();
        DataTable datosProy = new DataTable();

        string id_proy = "0";
        string id_padre = "0";

        DataTable operarios = new DataTable();
        DataTable operaciones = new DataTable();
        DataTable MParticulos = new DataTable();
        Events listaEventos = new Events();

        public GestionProyectos()
        {
            InitializeComponent();
            obtenerEventos();
        }

        private void cargarProys()
        {
            this.cbProys.Items.Clear();

            List <string> atb = new List<string>();
            atb.Add("*");



            datosProy = fbd.getSelect("tfgdb.dbo.PROYECTOS", atb, null, "ID_PROY");
            foreach (DataRow row in datosProy.Rows)
            {
                this.cbProys.Items.Add(row[0].ToString() + "#" + row[1].ToString());
            }
            this.cbProys.SelectedIndex = 0;

            this.labelHeader.Text = "PROYECTO";

            this.cbProys.Visible = true;
        }

        private void GestionProyectos_Load(object sender, EventArgs e)
        {
            cargarProys();
        }

        

        private void obtenerEventos()
        {
            UserCredential credential;


            using (var stream =
                new FileStream("credenciales.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Archivo de credenciales guardado en: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now.AddDays(-1);
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            listaEventos = request.Execute();
            test.Text = "";
            if (listaEventos.Items != null && listaEventos.Items.Count > 0)
            {
                foreach (var eventItem in listaEventos.Items)
                {
                    DateTime dateTime;
                    if (eventItem.Start.DateTime != null)
                    {
                        dateTime = (DateTime)eventItem.Start.DateTime;
                        test.Text += eventItem.Summary + " - " + dateTime.Date.ToShortDateString() + Environment.NewLine;
                    }
                    else if (eventItem.Start != null)
                    {
                        dateTime = DateTime.ParseExact(eventItem.Start.Date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                        test.Text += eventItem.Summary + " - " + dateTime.ToString("dd-MM-yyyy");
                    }
                }
            }
            else
            {
                test.Text = "No hay proyectos";
            }
            Console.Read();
        }

        private void getEvents_Tick(object sender, EventArgs e)
        {
            obtenerEventos();
        }


        private void resetearVistaProyecto()
        {
            this.tbNombre.Text = datosProy.Rows[this.cbProys.SelectedIndex][1].ToString();
            this.tbNombre.ReadOnly = true;

            this.tbDesc.Text = datosProy.Rows[this.cbProys.SelectedIndex][2].ToString();
            tbDesc.ReadOnly = true;

            this.tbCliente.Text = datosProy.Rows[this.cbProys.SelectedIndex][5].ToString();
            tbCliente.ReadOnly = true;

            this.dtpFIni.Value = (DateTime)datosProy.Rows[this.cbProys.SelectedIndex][3];
            dtpFIni.Enabled = false;

            this.labelEstado.Text = datosProy.Rows[this.cbProys.SelectedIndex][6].ToString();

            if (this.labelEstado.Text == "FINALIZADO")
            {
                this.labelEstado.ForeColor = Color.Lime;
            }
            else
            {
                this.labelEstado.ForeColor= Color.Blue;
            }

            poblarTreeView();
        }

        private void cbProys_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetearVistaProyecto();
        }

        private void poblarTreeView()
        {
            Cursor = Cursors.WaitCursor;
            this.treeViewProys.Nodes.Clear();
            id_proy = this.cbProys.SelectedItem.ToString().Substring(0, this.cbProys.SelectedItem.ToString().IndexOf('#'));
            this.datosPiezas = fbd.obtenerEstructs(id_proy);

            poblarNodo(null, "0", false);
            Cursor = Cursors.Default;

        }

        private void poblarNodo(TreeNode nodoPadre, string codpadre, bool altern)
        {
            TreeNode nodoHijo;

            foreach (DataRow dr in datosPiezas.Select("[CODIGO_PADRE]='" + codpadre + "'"))
            {
                TreeNode t = new TreeNode();

                if (altern)
                {
                    t.BackColor = Color.LightGray;
                }

                t.Text = dr["CODIGO"].ToString() + " - " + dr["DESCRIPCION"].ToString();
                t.Name = dr["CODIGO"].ToString();
                t.Tag = datosPiezas.Rows.IndexOf(dr);
                if (nodoPadre == null)
                {
                    this.treeViewProys.Nodes.Add(t);
                    nodoHijo = t;
                }
                else
                {
                    nodoPadre.Nodes.Add(t);
                    nodoHijo = t;
                }

                poblarNodo(nodoHijo, dr["CODIGO"].ToString(), !altern);
            }
        }


        private void treeViewProys_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right) {

                contextMenuStrip1.Show(Cursor.Position);
                treeViewProys.SelectedNode = treeViewProys.GetNodeAt(e.X, e.Y);

                //pictureBox1.ContextMenu = cm;
            }
        }

        private void datosPieza()
        {
            this.panel2.Visible = true;

            this.labelNomPieza.Text = this.treeViewProys.SelectedNode.Name.ToString();
            this.labelDescPieza.Text = this.treeViewProys.SelectedNode.Text.ToString();

            if (this.treeViewProys.SelectedNode.Nodes.Count > 0)
            {
                this.labelNumCompo.Text = "(" + this.treeViewProys.SelectedNode.Nodes.Count.ToString() + ")";
                this.panel2.Size = new Size(659, 252);
                this.dgvCompo.Visible = false;
            }
            else
            {

                this.dgvCompo.Visible = true;
                this.panel2.Size = new Size(659, 463);
                this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
                this.labelNumCompo.Text = "(" + this.dgvCompo.Rows.Count + ", ARTÍCULOS MATERIA PRIMA)";
            }
        }

        private void treeViewProys_DoubleClick(object sender, EventArgs e)
        {
            datosPieza();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se va a eliminar el proyecto actual, ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    List<string> cond = new List<string>();
                    cond.Add("ID_PROY = '" + id_proy + "'"); 

                    fbd.eliminar("tfgdb.dbo.PROYECTOS", cond);

                    cargarProys();

                    MessageBox.Show("Proyecto eliminado", "BORRADO COMPLETO");

                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnEliminarOp_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Se van a eliminar " + dgvCompo.SelectedRows.Count + " operaciones en la pieza " + labelNomPieza.Text + ", ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvCompo.SelectedRows)
                    {
                        fbd.eliminarOperacion(labelNomPieza.Text, row.Cells[0].Value.ToString(), id_proy, row.Cells[2].Value.ToString());
                    }

                    this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
                    MessageBox.Show("Operaciones eliminadas", "BORRADO COMPLETO");
                    break;
                case DialogResult.No:
                    break;
            }

            
        }

        private void btnAñadirOp_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = true;
            this.panel2.Visible = false;
            this.cbMPOp.Items.Clear();
            this.cbOperaciones.Items.Clear();
            this.cbOperario.Items.Clear();

            operaciones = fbd.obtenerOperaciones();
            operarios = fbd.obtenerPersonal();
            MParticulos = fbd.getArticulos();

            foreach (DataRow row in operaciones.Rows)
            {
                this.cbOperaciones.Items.Add(row[1].ToString());
            }

            this.cbOperaciones.SelectedIndex = 0;

            foreach (DataRow row2 in MParticulos.Rows)
            {
                this.cbMPOp.Items.Add(row2[1].ToString());
            }
            this.cbMPOp.SelectedIndex = 0;

            foreach(DataRow row3 in operarios.Rows)
            {
                this.cbOperario.Items.Add(row3[1].ToString() + "( " + row3[2].ToString() + " )");
            }
            this.cbOperario.SelectedIndex = 0;


        }

        private void btnCerrarPanelOps_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = false;
            this.panel2.Visible = true;
        }

        private void cbMPOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDenomiOp.Text = this.MParticulos.Rows[this.cbMPOp.SelectedIndex][2].ToString();
        }

        private void btnAceptarOp_Click(object sender, EventArgs e)
        {
            this.panelOps.Visible = false;
            this.panel2.Visible = true;


            List<string> atb = new List<string>();
            atb.Add("PROYECTO");
            atb.Add("PIEZA");
            atb.Add("OPERACION");
            atb.Add("DNI_EMP_ASIGNADO");
            atb.Add("FECHA_CRE");
            atb.Add("MP_BASE");
            atb.Add("ESTADO");

            List<string> valores = new List<string>();
            valores.Add("'" + id_proy + "'");
            valores.Add("'" + this.labelNomPieza.Text + "'");
            valores.Add("'" + (this.cbOperaciones.SelectedIndex + 1).ToString() + "'");
            valores.Add("'" + operarios.Rows[this.cbOperario.SelectedIndex]["DNI"].ToString() + "'");
            valores.Add("GETDATE()");
            valores.Add("'" + this.cbMPOp.SelectedItem.ToString() + "'");
            valores.Add("'PENDIENTE'");

            fbd.insertar("tfgdb.dbo.OPERACIONES", atb, valores, null);

            this.dgvCompo.DataSource = fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy);
            MessageBox.Show("Nueva operación añadida", "INSERCIÓN COMPLETA");

        }

        private void cbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbOperario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nUEVOCOMPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;

            if (id_padre == "0")
            {
                this.tbCodigoPieza.Text = "P" + id_proy + "-" + (this.treeViewProys.Nodes.Count + 1);
            }
            else
            {
                this.tbCodigoPieza.Text = this.treeViewProys.SelectedNode.Name.ToString() + "." + (this.treeViewProys.SelectedNode.Nodes.Count + 1);
            }

        }

        private void eLIMNARCOMPONENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if  (treeViewProys.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("El nodo seleccionado no se puede eliminar porque contiene hijos", "ATENCIÓN");
            }
            else
            {
                foreach( DataRow row in fbd.obtenerComponentesMP(this.treeViewProys.SelectedNode.Name.ToString(), id_proy).Rows)
                {
                    //AQUÍ LO SUYO ES PONER EL ON DELETE CASCADE PARA NO HACERLO POR CÓDIGO
                    //fbd.eliminarOperacion()
                }

                DialogResult dr = MessageBox.Show("Se va a eliminar la pieza " + this.treeViewProys.SelectedNode.Name.ToString() + ", ¿Continuar?",
                      "ATENCIÓN", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        string padre = "0";
                        if (treeViewProys.SelectedNode.Parent != null)
                        {
                            padre = treeViewProys.SelectedNode.Parent.Name.ToString();
                        }
                        fbd.eliminarPieza(this.treeViewProys.SelectedNode.Name.ToString(), id_proy,padre);
                        this.treeViewProys.SelectedNode.Remove();
                        MessageBox.Show("Operaciones eliminadas", "BORRADO COMPLETO");
                        break;
                    case DialogResult.No:
                        break;
                }

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void treeViewProys_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                contextMenuStrip1.Show(Cursor.Position);

                TreeNode node = treeViewProys.GetNodeAt(e.X, e.Y);

                if (node == null)
                {
                    id_padre = "0";
                }
                else
                {
                    id_padre = node.Name.ToString();
                }

                //pictureBox1.ContextMenu = cm;
            }
        }

        private void btnAceptarNuevaPieza_Click(object sender, EventArgs e)
        {
            fbd.nuevaPieza(this.tbCodigoPieza.Text, this.tbDescPieza.Text, id_proy, id_padre);
            
            this.treeViewProys.Nodes.Clear();
            poblarTreeView();

            MessageBox.Show("Se ha insertado una nueva pieza para el proyecto " + this.cbProys.Text, "NUEVA PIEZA AÑADIDA");

            this.panel3.Visible = false;

        }

        private void btnCerrarPanel3_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }

        private void treeViewProys_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnCalendar.Enabled = false;
            this.btnExcel.Enabled = false;
            this.btnAcepNuevoProy.Visible = true;
            this.btnCancNuevoproy.Visible = true;

            this.treeViewProys.Nodes.Clear();

            this.tbNombre.Text = "";
            this.tbNombre.ReadOnly = false;

            this.tbDesc.Text = "";
            tbDesc.ReadOnly = false;

            this.tbCliente.Text = "";
            tbCliente.ReadOnly = false;

            this.dtpFIni.Value = DateTime.Now;
            dtpFIni.Enabled = true;

            this.cbProys.Visible = false;

            this.btnNuevo.Enabled = false;
            this.btnEliminar.Enabled = false;

            this.labelHeader.Text = "PROYECTO NUEVO";
        }

        private void btnCancNuevoproy_Click(object sender, EventArgs e)
        {
            this.labelHeader.Text = "PROYECTO";
            this.cbProys.Visible = true;

            this.btnAcepNuevoProy.Visible = false;
            this.btnCancNuevoproy.Visible = false;

            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = true;

            resetearVistaProyecto();

            this.btnCalendar.Enabled = true;
            this.btnExcel.Enabled = true;

        }

        private void btnAcepNuevoProy_Click(object sender, EventArgs e)
        {
            List<string> listaAtb = new List<string>();
            listaAtb.Add("NOMBRE_PROY");
            listaAtb.Add("DESC_PROY");
            listaAtb.Add("FECHA_INI");
            listaAtb.Add("CLIENTE");
            listaAtb.Add("ESTADO");

            List<string> listaValores = new List<string>();
            listaValores.Add(tbNombre.Text);
            listaValores.Add(tbDesc.Text);
            listaValores.Add(dtpFIni.Text);
            listaValores.Add(tbCliente.Text);
            listaValores.Add("EN PROCESO");


            string id_proy_aux = fbd.insertar("tfgdb.dbo.PROYECTOS", listaAtb, listaValores, "ID_PROY").ToString();
            string nombre_aux = tbNombre.Text;
            cargarProys();

            string proyCombo = id_proy_aux + "#" + nombre_aux;

            cbProys.SelectedIndex = cbProys.FindStringExact(proyCombo);

            this.btnCalendar.Enabled = true;
            this.btnExcel.Enabled = true;
        }

        private void dATOSDEPIEZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datosPieza();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.panelCalendar.Visible = true;
        }

        private void btnCerraCalendar_Click(object sender, EventArgs e)
        {
            this.panelCalendar.Visible = false;
        }

        private void dtpCalendar_DropDown(object sender, EventArgs e)
        {

        }

        private void btnAceptarCalendar_Click(object sender, EventArgs e)
        {

            string titulo = "ENTREGA " + id_proy + " (" + this.tbNombre.Text + ")";

            bool programado = false;
            string fechaProg = "";

            foreach (var eventItem in listaEventos.Items)
            {
                if (eventItem.Summary == titulo)
                {
                    programado = true;
                    fechaProg = DateTime.ParseExact(eventItem.Start.Date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture).ToString("dd-MM-yyyy");
                }
            }

            if (!programado)
            {
                UserCredential credential;


                using (var stream =
                    new FileStream("credenciales.json", FileMode.Open, FileAccess.Read))
                {
                    // The file token.json stores the user's access and refresh tokens, and is created
                    // automatically when the authorization flow completes for the first time.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Archivo de credenciales guardado en : " + credPath);
                }



                Event ev = new Event();
                EventDateTime start = new EventDateTime();
                EventDateTime end = new EventDateTime();
                start.Date = dtpCalendar.Value.Date.ToString("yyyy-MM-dd");
                end.Date = dtpCalendar.Value.Date.ToString("yyyy-MM-dd");


                ev.Start = start;
                ev.End = end;
                ev.Summary = titulo;
                ev.Description = "Entrega de proyecto " + id_proy + ": " + this.tbNombre.Text;
                ev.Description += "\nCliente: " + this.tbCliente.Text;



                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var calendarId = "primary";
                Event recurringEvent = service.Events.Insert(ev, calendarId).Execute();

                MessageBox.Show("Entrega programada. Consulte Google Calendar para más información.", "ENTREGA DE PROYECTO PROGRAMADA");

                this.panelCalendar.Visible = false;
                this.dtpCalendar.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("El proyecto actual ya se encuentra programado para el día " + fechaProg + ".\nRevise el evento en Google Calendar.", "ATENCIÓN");
            }



            
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                DialogResult result = fd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    ExcelPackage excel = new ExcelPackage();
                    var worksheet = excel.Workbook.Worksheets.Add("ESTRUCTURA PROYECTO " + id_proy);
                    int rowCounter = 1;

                    worksheet.Cells["A1:J3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A1:J3"].Style.Fill.BackgroundColor.SetColor(SystemColors.ActiveCaption);
                    worksheet.Cells["A1:J3"].Style.Font.Bold = true;
                    worksheet.Cells["A1:J3"].Style.Font.Size = 20;

                    worksheet.Cells[1, 1].Value = "PROYECTO " + id_proy;

                    worksheet.Cells[3, 1].Value = this.tbDesc.Text;

                    worksheet.Cells[1, 5].Value = "CLIENTE: " + this.tbCliente.Text;

                    worksheet.Cells[3, 5].Value = "F. INICIO: " + this.dtpFIni.Text;


                    rowCounter = 5;

                    RecurseNodes(treeViewProys.Nodes, 1, true, true);

                    void RecurseNodes(TreeNodeCollection currentNode, int col, bool inicio, bool altern)
                    {
                        foreach (TreeNode node in currentNode)
                        {
                            if (inicio)
                            {
                                rowCounter = rowCounter + 2;
                                worksheet.Cells[rowCounter, col].Style.Font.Bold = true;
                                worksheet.Cells[rowCounter, col].Style.Font.Size = 17;
                            }
                            else
                            {
                                rowCounter = rowCounter + 1;
                            }

                            if (altern)
                            {
                                string rango = "A" + rowCounter + ":J" + rowCounter;
                                worksheet.Cells[rango].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[rango].Style.Fill.BackgroundColor.SetColor(SystemColors.GrayText);
                            }

                            worksheet.Cells[rowCounter, col].Value = node.Text;


                            if (node.FirstNode != null)
                                RecurseNodes(node.Nodes, col + 1, false, !altern);
                        }
                    }


                    excel.SaveAs(new FileInfo(@"" + fd.SelectedPath + "\\ESQUEMA_PIEZAS_PROY_" + id_proy + ".xlsx"));


                    System.Windows.Forms.MessageBox.Show("Exportación completa", "ATENCIÓN");
                }
            }
        }
    }
}
