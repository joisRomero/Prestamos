using Entidades;
using ReglaNegocio;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FrmListaPagos : Form
    {
        public static FrmListaPagos Instancia = null;
        Thread subProceso;
        bool estaExportanto = false;
        public FrmListaPagos()
        {
            InitializeComponent();
        }
        public static FrmListaPagos LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmListaPagos();
                }
                return Instancia;
            }
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNReporteListaPagos rn = new RNReporteListaPagos();
            List<ReporteListaPagos> listPagos;

            this.DgvListado.DataSource = null;

            try
            {
                listPagos = rn.Listar();
                if (listPagos.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = listPagos;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el listado", this.Text);
            }
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

        private void MostrarNotificacion()
        {
            Notificacion.Visible = true;
            Notificacion.ShowBalloonTip(100, "Lista de préstamos", "Exportación terminada con éxito", ToolTipIcon.Info);
        }

        private SLDocument CrearDocumentoExcel(DataTable tablaDatos)
        {
            SLDocument documento = new SLDocument();

            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Img\principal_32.png");

            SLPicture pic = new SLPicture(ruta);

            documento.SetCellValue("B2", "GESTION DE PAGOS");
            documento.SetCellValue("B3", "LISTA DE PAGOS");
            SLStyle estilos = documento.CreateStyle();
            estilos.Font.Bold = true;
            estilos.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Alignment.Vertical = VerticalAlignmentValues.Center;
            estilos.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            documento.MergeWorksheetCells("C2", "F2");
            documento.MergeWorksheetCells("C3", "F3");
            documento.SetCellStyle("C2", "F3", estilos);

            pic.SetPosition(1, 1.5);
            documento.InsertPicture(pic);

            int indexFilaInicio = 5;
            int indexColumnaInicio = 3;

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

        private DataTable CrearTablaDatos()
        {
            DataTable tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Cliente", typeof(string));
            tablaDatos.Columns.Add("Fecha", typeof(DateTime));
            tablaDatos.Columns.Add("Monto Pagado", typeof(double));
            tablaDatos.Columns.Add("Forma Pago", typeof(string));

            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                tablaDatos.Rows.Add(row.Cells["cdNombreCliente"].Value.ToString(),
                    DateTime.Parse(row.Cells["cdFecha"].Value.ToString()),
                    double.Parse(row.Cells["cdMontoPagado"].Value.ToString()),
                    row.Cells["cdFormaPago"].Value.ToString());
            };

            return tablaDatos;
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

        private void FrmListaPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (estaExportanto)
            {
                e.Cancel = true;
            }
        }
    }
}
