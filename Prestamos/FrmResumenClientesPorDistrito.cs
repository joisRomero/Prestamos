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
    public partial class FrmResumenClientesPorDistrito : Form
    {

        public static FrmResumenClientesPorDistrito Instancia = null;
        private List<ReporteResumenClientesDistrito> listado = new List<ReporteResumenClientesDistrito>();
        private bool estaExportanto = false;
        private Thread subProceso;

        private FrmResumenClientesPorDistrito()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static FrmResumenClientesPorDistrito LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmResumenClientesPorDistrito();
                }
                return Instancia;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ProcesarClientes();
            this.DgvListado.DataSource = null;
            if (this.listado.Count > 0)
            {
                this.DgvListado.AutoGenerateColumns = false;
                this.DgvListado.DataSource = this.listado;
            }
            else
            {
                MessageBox.Show("No se han encontrado clientes", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProcesarClientes()
        {
            this.listado.Clear();
            foreach (var dist in Program.Distritos)
            {
                this.listado.Add(new ReporteResumenClientesDistrito()
                { Distrito = dist.DistritoNombre });
            }
            foreach (var per in Program.Personas)
            {
                this.listado[Program.Distritos.IndexOf(per.Distrito)].CantidadPersonas++;
            }
            foreach (var emp in Program.Empresas)
            {
                this.listado[Program.Distritos.IndexOf(emp.Distrito)].CantidadEmpresas++;
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
                GuardarArchivoDialogo.FileName = $"{this.Text}";
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
            tablaDatos.Columns.Add("Distrito", typeof(string));
            tablaDatos.Columns.Add("Cantidad de empresas", typeof(int));
            tablaDatos.Columns.Add("Cantidad de personas", typeof(int));
            tablaDatos.Columns.Add("Total", typeof(int));

            foreach (DataGridViewRow row in DgvListado.Rows)
            {
                tablaDatos.Rows.Add(row.Cells["CdDistrito"].Value.ToString(),
                    int.Parse(row.Cells["CdCantidadEmpresas"].Value.ToString()),
                    int.Parse(row.Cells["CdCantidadPersonas"].Value.ToString()),
                    int.Parse(row.Cells["CdTotal"].Value.ToString()));
            }

            return tablaDatos;
        }

        private SLDocument CrearDocumentoExcel(DataTable tablaDatos)
        {
            SLDocument documento = new SLDocument();

            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Img\principal_32.png");

            SLPicture pic = new SLPicture(ruta);

            documento.SetCellValue("B2", "GESTION DE PRESTAMOS");
            documento.SetCellValue("B3", "RESUMEN DE CLIENTES POR DISTRITO");
            SLStyle estilos = documento.CreateStyle();
            estilos.Font.Bold = true;
            estilos.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estilos.Alignment.Vertical = VerticalAlignmentValues.Center;
            estilos.Alignment.Horizontal = HorizontalAlignmentValues.Center;

            documento.MergeWorksheetCells("B2", "E2");
            documento.MergeWorksheetCells("B3", "E3");

            documento.SetCellStyle("B2", "E3", estilos);

            pic.SetPosition(1, 1.5);
            documento.InsertPicture(pic);

            int indexFilaInicio = 5;
            int indexColumnaInicio = 2;

            documento.ImportDataTable(indexFilaInicio, indexColumnaInicio, tablaDatos, true);

            int indexFilaFin = indexFilaInicio + tablaDatos.Rows.Count;
            int indexColumnaFin = indexColumnaInicio + tablaDatos.Columns.Count - 1;

            documento.AutoFitColumn(indexColumnaInicio, indexColumnaFin);

            SLTable table = documento.CreateTable(indexFilaInicio, indexColumnaInicio, indexFilaFin, indexColumnaFin);
            table.SetTableStyle(SLTableStyleTypeValues.Medium9);
            table.HasAutoFilter = false;
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

        private void FrmResumenClientesPorDistrito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (estaExportanto)
            {
                e.Cancel = true;
            }
        }
    }
}
