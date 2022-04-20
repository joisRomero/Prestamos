using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FrmListaPrestamos : Form
    {
        public static FrmListaPrestamos Instancia = null;
        Thread subProceso;
        bool estaExportanto = false;
        private FrmListaPrestamos()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static FrmListaPrestamos LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmListaPrestamos();
                }
                return Instancia;
            }
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            //this.DgvListado.DataSource = null;
            //if (Program.Prestamos.Count > 0)
            //{
            //    this.DgvListado.AutoGenerateColumns = false;
            //    this.DgvListado.DataSource = Program.Prestamos;
            //}
            //else
            //{
            //    MessageBox.Show("No se han registrado préstamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (DgvListado.RowCount == 0)
            {
                MessageBox.Show("Primero haga click en listar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BtnListar.Focus();
            }
            else
            {
                GuardarArchivoDialogo.Filter = "Libro de Excel|*.xlsx";
                GuardarArchivoDialogo.FileName = $"{this.Text} - {DateTime.Now}";
                GuardarArchivoDialogo.DefaultExt = ".xlsx";

                if (GuardarArchivoDialogo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        estaExportanto = true;
                        ThreadStart dlg = new ThreadStart(ExportarAExcel);
                        subProceso = new Thread(dlg);
                        subProceso.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ExportarAExcel()
        {
            DataTable tablaDatos = CrearTablaDatos();
            SLDocument documento = CrearDocumentoExcel(tablaDatos);
            documento.SaveAs(GuardarArchivoDialogo.FileName);
            MostrarNotificacion();
            estaExportanto = false;
        }

        private DataTable CrearTablaDatos()
        {
            DataTable tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Documento", typeof(string));
            tablaDatos.Columns.Add("Nombre", typeof(string));
            tablaDatos.Columns.Add("Fecha", typeof(DateTime));
            tablaDatos.Columns.Add("Monto Prestado", typeof(double));
            tablaDatos.Columns.Add("Perido", typeof(string));
            tablaDatos.Columns.Add("Cantidad de cuotas", typeof(int));

            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                tablaDatos.Rows.Add(row.Cells["cdDocumento"].Value.ToString(),
                    row.Cells["cdNombre"].Value.ToString(),
                    DateTime.Parse(row.Cells["CdFecha"].Value.ToString()),
                    double.Parse(row.Cells["CdMontoPrestado"].Value.ToString()),
                    row.Cells["CdPeriodo"].Value.ToString(),
                    int.Parse(row.Cells["CdCantidadCuotas"].Value.ToString()));
            }

            return tablaDatos;
        }

        private SLDocument CrearDocumentoExcel(DataTable tablaDatos)
        {
            SLDocument documento = new SLDocument();
            
            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Img\principal_32.png");

            SLPicture pic = new SLPicture(ruta);

            documento.SetCellValue("B2", "GESTION DE PRESTAMOS");
            documento.SetCellValue("B3", "LISTA DE PRESTAMOS");
            SLStyle estilos = documento.CreateStyle();
            estilos.Font.Bold = true;
            estilos.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Alignment.Vertical = VerticalAlignmentValues.Center;
            estilos.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            documento.MergeWorksheetCells("B2", "G2");
            documento.MergeWorksheetCells("B3", "G3");
            documento.SetCellStyle("B2", "G3", estilos);

            pic.SetPosition(1, 1.5);
            documento.InsertPicture(pic);

            int indexFilaInicio = 5;
            int indexColumnaInicio = 2;

            documento.ImportDataTable(indexFilaInicio, indexColumnaInicio, tablaDatos, true);

            SLStyle style = documento.CreateStyle();
            style.FormatCode = "dd/mm/yyyy";
            documento.SetColumnStyle(4, style);

            style.FormatCode = "#,##0.00";
            documento.SetColumnStyle(5, style);

            int indexFilaFin = indexFilaInicio + tablaDatos.Rows.Count;
            int indexColumnaFin = indexColumnaInicio + tablaDatos.Columns.Count - 1;

            documento.AutoFitColumn(indexColumnaInicio, indexColumnaFin);

            SLTable table = documento.CreateTable(indexFilaInicio, indexColumnaInicio, indexFilaFin, indexColumnaFin);
            table.SetTableStyle(SLTableStyleTypeValues.Medium9);
            documento.InsertTable(table);
            documento.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Listado");

            return documento;
        }

        private void MostrarNotificacion()
        {
            Notificacion.Visible = true;
            Notificacion.ShowBalloonTip(100, "Lista de préstamos", "Exportación terminada con éxito", ToolTipIcon.Info);
        }

        private void Notificacion_BalloonTipClosed(object sender, EventArgs e)
        {
            Notificacion.Visible = false;
        }

        private void Notificacion_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(GuardarArchivoDialogo.FileName);
            Notificacion.Visible = false;
        }

        private void FrmListaPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (estaExportanto)
            {
                e.Cancel = true;
            }
        }
    }
}
