using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;
using MultimodeSales.Programacion.Marca;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Modelo;
using MultimodeSales.Programacion.Utilerias;

namespace MultimodeSales.Vistas
{
    public partial class ImportarListaMarca : Form
    {
        CMarcaBD marca = new CMarcaBD();
        CImportarCSVyExcel importarCSV = new CImportarCSVyExcel();
        CModelosDB modelos = new CModelosDB();
        public ImportarListaMarca()
        {
            InitializeComponent();
            LlenarComboBoxMarca();
            CDataGridView.FormattedDataGridView(dgvExcel);
            CRoundButton.FormattedRoundButtonCancelar(rbtnCargar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnImportar);
            CRoundButton.FormattedRoundButtonAceptar(rbtnCancelar);
            Region = Region.FromHrgn(CFormBorder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private string modelo = "MODELO";
        private string color = "COLOR";
        private string talla = "TALLA";
        private string claves = "CLAVES";
        private int MX;
        private int MY;

        public void LlenarComboBoxMarca()
        {
            List<object[]> list = marca.VerMarcas2();
            Dictionary<string, string> keyValues = new Dictionary<string, string>();
            keyValues.Add("-1", "--Elegir Marca--");
            foreach (object[] item in list)
            {
                keyValues.Add(item[0].ToString(), item[1].ToString());
            }
            cobxMarca.DataSource = new BindingSource(keyValues, null);
            cobxMarca.DisplayMember = "Value";
            cobxMarca.ValueMember = "Key";

        }
        private void rbtnCargar_Click(object sender, EventArgs e)
        {
            //CargarExcel();
            CargarCSV();
        }
        private void rbtnImportar_Click(object sender, EventArgs e)
        {
            string idmarca = cobxMarca.SelectedValue.ToString();
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                modelos.AgregarModelo(row.Cells[0].Value.ToString(), idmarca, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
            }
            CMsgBox.DisplayInfo("Importacion exitosa");
        }
        private void CargarCSV()
        {
            DataTable dt;
            dgvExcel.DataSource = null;
            string openFile = importarCSV.GetFileName();
            if (!openFile.Equals(""))
            {
                dt = importarCSV.ImportarCSV(openFile);

                if (dt.Columns.Count > 4)
                {
                    for (int i = dt.Columns.Count - 1; i > 3; i--)
                    {
                        dt.Columns.RemoveAt(i);
                    }
                }
                dgvExcel.DataSource = dt;
                FormatoTabla();
            }
        }
        private void FormatoTabla()
        {
            dgvExcel.Columns[0].Width = 200;
            dgvExcel.Columns[1].Width = 200;
            dgvExcel.Columns[2].Width = 250;
            dgvExcel.Columns[3].Width = 175;
            dgvExcel.Columns[0].HeaderText = "MODELO";
            dgvExcel.Columns[1].HeaderText = "COLOR";
            dgvExcel.Columns[2].HeaderText = "TALLA";
            dgvExcel.Columns[3].HeaderText = "PRECIO";
        }
        private void CargarExcel()
        {
            try
            {
                dgvExcel.DataSource = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Select file";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFile.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.Multiselect = false;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //string sheetName = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName);
                    Application.DoEvents();
                    string constr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={openFile.FileName};Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    excel.Application xlApp = new excel.Application();

                    //get the workbook
                    excel.Workbook excelBook = xlApp.Workbooks.Open(openFile.FileName);

                    //get the first worksheet
                    excel.Worksheet wSheet = excelBook.Sheets.Item[1];

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand($"select {modelo}, {color}, {talla}, {claves} from [{wSheet.Name}$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    DataTable data2 = new DataTable();
                    data2.Columns.Add(modelo);
                    data2.Columns.Add(color);
                    data2.Columns.Add(talla);
                    data2.Columns.Add(claves);
                    sda.Fill(data);
                    foreach (DataRow rows in data.Rows)
                    {
                        if (!rows.IsNull(modelo))
                        {
                            data2.Rows.Add(rows.ItemArray);
                        }
                    }
                    dgvExcel.DataSource = data2;
                    FormatoTabla();

                    con.Close();
                    foreach (var process in Process.GetProcessesByName("excel"))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                CMsgBox.DisplayError($"Los parametros recibidos no son validos, intente de nuevo \n Mensaje: \n {ex.Message}");
            }
        }
        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Panel Barras
        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbClientes_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void panelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }


        #endregion
    }
}
