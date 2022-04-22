using DocumentFormat.OpenXml.Spreadsheet;
using Entidades;
using ReglaNegocio;
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
    public partial class FrmEstadoPrestamo : Form
    {
        private ICliente Cliente;
        private static FrmEstadoPrestamo Instancia;
        List<TipoDocumento> tipoDocumentos;
        Prestamo prestamo;
        List<Prestamo> prestamos;
        Thread subProceso;
        bool estaExportanto = false;
        public FrmEstadoPrestamo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public static FrmEstadoPrestamo LlamarFormulario
        {
            get
            {
                if (Instancia == null || Instancia.IsDisposed)
                {
                    Instancia = new FrmEstadoPrestamo();
                }
                return Instancia;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string numeroDocumento = this.TxtNumeroDocumento.Text.Trim();
            LimpiarTablas();

            if (this.CboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar el tipo de cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoCliente.Focus();
            }
            else if (this.CboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar el tipo de documento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CboTipoDocumento.Focus();
            }
            else if (this.CboTipoCliente.SelectedIndex == 0)
            {
                TipoDocumento tipoDocumento = (TipoDocumento)this.CboTipoDocumento.SelectedItem;
                this.BuscarClientePersona(numeroDocumento, tipoDocumento.Codigo);
            }
            else
            {
                this.BuscarClienteEmpresa(numeroDocumento);
            }

            if (this.Cliente != null)
            {
                this.TxtCliente.Text = this.Cliente.Nombre;
            }
            else
            {
                if (this.CboTipoCliente.SelectedIndex > -1 && this.CboTipoDocumento.SelectedIndex > -1)
                {
                    MessageBox.Show("Cliente no encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.TxtCliente.Text = "";
            }
        }

        private void LimpiarTablas()
        {
            this.DgvPrestamos.DataSource = null;
            this.DgvCuotas.DataSource = null;
        }

        private void BuscarClientePersona(string numeroDocumento, int codigoTipoDocumento)
        {
            RNClientePersona rnPersona;
            rnPersona = new RNClientePersona();
            try
            {
                this.Cliente = rnPersona.Leer(numeroDocumento, codigoTipoDocumento);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarClienteEmpresa(string numeroDocumento)
        {
            RNClienteEmpresa rnEmpresa;
            rnEmpresa = new RNClienteEmpresa();
            try
            {
                this.Cliente = rnEmpresa.Leer(numeroDocumento);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener al cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarAvanzada_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();

            this.Cliente = frm.Buscar(this.CboTipoCliente.SelectedIndex);

            if (this.Cliente != null)
            {
                this.PresentarDatos();
            }
            else
            {
                this.TxtCliente.Text = "";
            }
        }

        private void PresentarDatos()
        {
            LimpiarTablas();
            BorrarErrores();

            if (this.Cliente is ClientePersona)
            {
                this.CboTipoCliente.SelectedIndex = 0;
                this.CboTipoDocumento.SelectedValue = ((ClientePersona)this.Cliente).TipoDocumento.Codigo;
                this.TxtNumeroDocumento.Text = ((ClientePersona)this.Cliente).NumeroDocumento;
            }
            else
            {
                this.CboTipoCliente.SelectedIndex = 1;
                this.CboTipoDocumento.SelectedIndex = 0;
                this.TxtNumeroDocumento.Text = ((ClienteEmpresa)this.Cliente).RUC;
            }
            this.TxtCliente.Text = this.Cliente.Nombre;
        }

        private void CboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CboTipoCliente.SelectedIndex == 0)
            {
                this.CboTipoDocumento.DataSource = null;
                if (tipoDocumentos.Count > 0)
                {
                    CboTipoDocumento.DataSource = tipoDocumentos;
                    this.CboTipoDocumento.DisplayMember = "Nombre";
                    this.CboTipoDocumento.ValueMember = "Codigo";
                }
            }
            else
            {
                this.CboTipoDocumento.DataSource = null;
                this.CboTipoDocumento.Items.Add("RUC");
                this.CboTipoDocumento.SelectedIndex = 0;
            }
        }

        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            RNTipoDocumento rn = new RNTipoDocumento();
            try
            {
                tipoDocumentos = rn.Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los tipos de documentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarErrores()
        {
            this.ErrNotificador.SetError(this.BtnBuscar, "");
            this.ErrNotificador.SetError(this.BtnBuscarPrestamo, "");
        }

        private void BtnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BorrarErrores();
                RNPrestamo rn = new RNPrestamo(); ;
                this.prestamos = new List<Prestamo>();
                this.DgvPrestamos.DataSource = null;

                try
                {
                    prestamos = rn.PrestamosPorPagar(Cliente);
                    if (this.prestamos != null && this.prestamos.Count > 0)
                    {
                        this.DgvPrestamos.AutoGenerateColumns = false;
                        this.DgvPrestamos.DataSource = this.prestamos;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no registra préstamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener la lista de prestamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && DgvPrestamos.DataSource != null)
            {
                RNPrestamo rn = new RNPrestamo(); ;
                List<Cuota> cuotas = new List<Cuota>();
                this.DgvCuotas.DataSource = null;
                prestamo = (Prestamo)this.DgvPrestamos.CurrentRow.DataBoundItem;
                try
                {
                    cuotas = rn.CuotasPorPagar(prestamo);
                    if (cuotas != null && cuotas.Count > 0)
                    {
                        this.DgvCuotas.AutoGenerateColumns = false;
                        this.DgvCuotas.DataSource = cuotas;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo obtener la lista de prestamos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Busque los préstamos del cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBuscarPrestamo_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNumeroDocumento.Text = this.TxtNumeroDocumento.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNumeroDocumento.Text) == false)
            {
                this.ErrNotificador.SetError(this.TxtNumeroDocumento, "");
            }
            else
            {
                this.ErrNotificador.SetError(this.BtnBuscar, "Debe buscar un cliente");
                e.Cancel = true;
            }
        }
        private void CargarTiposDocumentos()
        {
            RNTipoDocumento rn = new RNTipoDocumento();
            try
            {
                tipoDocumentos = rn.Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar los tipos de documentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEstadoPrestamo_Load(object sender, EventArgs e)
        {
            CargarTiposDocumentos();
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (DgvCuotas.RowCount == 0)
            {
                MessageBox.Show("Primero haga liste todas las cuotas de un préstamo", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GuardarArchivoDialogo.Filter = "Libro de Excel|*.xlsx";
                GuardarArchivoDialogo.FileName = $"{this.Text}{DateTime.Now:ddMMyyHHmmss}";
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
            tablaDatos.Columns.Add("Fecha vencimiento", typeof(DateTime));
            tablaDatos.Columns.Add("Saldo", typeof(double));

            foreach (DataGridViewRow row in DgvCuotas.Rows)
            {
                tablaDatos.Rows.Add(
                    DateTime.Parse(row.Cells["CdFechaVencimiento"].Value.ToString()),
                    double.Parse(row.Cells["CdSaldo"].Value.ToString()));
            }

            return tablaDatos;
        }

        private SLDocument CrearDocumentoExcel(DataTable tablaDatos)
        {
            SLDocument documento = new SLDocument();

            string ruta = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @"\Img\principal_32.png");

            SLPicture pic = new SLPicture(ruta);

            documento.SetCellValue("B2", "GESTION DE PRÉSTAMOS");
            documento.SetCellValue("B3", "LISTA ESTADO PRESTAMO");
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
            int indexColumnaInicio = 3;

            documento.ImportDataTable(indexFilaInicio, indexColumnaInicio, tablaDatos, true);

            SLStyle style = documento.CreateStyle();
            style.FormatCode = "dd/mm/yyyy";
            documento.SetColumnStyle(3, style);

            style.FormatCode = "#,##0.00";
            documento.SetColumnStyle(4, style);


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
            Notificacion.ShowBalloonTip(100, "Lista total de préstamos", "Exportación terminada con éxito", ToolTipIcon.Info);
        }

        private void FrmEstadoPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (estaExportanto)
            {
                e.Cancel = true;
            }
        }

        private void Notificacion_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(GuardarArchivoDialogo.FileName);
            Notificacion.Visible = false;
        }

        private void Notificacion_BalloonTipClosed(object sender, EventArgs e)
        {
            Notificacion.Visible = false;
        }

        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
