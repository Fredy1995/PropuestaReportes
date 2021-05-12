using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropuestaReportes
{
    public partial class FrmDetalles : Form
    {
        string[,] IngresadosDetalle = new string[2, 4] {
            { "10233045", "05/07/2021", "Tecali","Amozoc" },
             { "10233045", "20/04/2021", "Cholula","Calpan" }
            };
        string[,] TerCanclyProcDetalle = new string[4, 6] {
            { "10233045", "201903228210128", "REGISTRO CATASTRAL, PROGRAMA DE REGULARIZACIÓN","07/05/2021","Tecali","Amozoc"},
             { "19873945", "201903228312043", "R.P.P","20/04/2021", "Cholula","Calpan" },
              { "53574533", "201903228407106", "ALTA AL PADRÓN, PROGRAMA DE REGULARIZACIÓN","21/04/2021", "Tehuacan","Ajalpan" },
             { "53574533", "201903228505179", "ALTA AL PADRÓN, PROGRAMA DE REGULARIZACIÓN","22/04/2021", "Puebla","Puebla" }
            };
        private string tramite;
        public FrmDetalles(string Tramite)
        {
            InitializeComponent();
            this.tramite = Tramite;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            CargarDatosDetalles();
        }
        private void CargarDatosDetalles()
        {
            gcDetalles.Visible = true;
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;
            if (tramite == "Ingresados")
            {
                gcDetalles.DataSource = null;
                gvDetalles.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Folio Tenencia";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Fecha Entrada";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                for (int fil = 0; fil < IngresadosDetalle.GetLength(0); fil++)
                {
                    
                        row = dt.NewRow();
                    row["Folio Tenencia"] = IngresadosDetalle[fil, 0].ToString();
                    row["Fecha Entrada"] = IngresadosDetalle[fil, 1].ToString();
                    row["Delegación"] = IngresadosDetalle[fil, 2].ToString();
                    row["Municipio"] = IngresadosDetalle[fil, 3].ToString();
                    dt.Rows.Add(row);

                }
                lblTipotramite.Text = tramite+ " Detalle";
                gcDetalles.DataSource = dt;
            }
            else if(tramite == "Terminados")
            {
                TermCancelEnProceso();
                lblTipotramite.Text = tramite + " Detalle";
            }
            else if(tramite == "Cancelados")
            {
                TermCancelEnProceso();
                lblTipotramite.Text = tramite + " Detalle";
            }
            else if(tramite == "En proceso")
            {
                TermCancelEnProceso();
                lblTipotramite.Text = tramite + " Detalle";
            }
        }

        private void TermCancelEnProceso()
        {
            gcDetalles.Visible = true;
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;
            
                gcDetalles.DataSource = null;
                gvDetalles.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Folio Tenencia";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Trámite Server";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Tipo Trámite";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Fecha Entrada";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                for (int fil = 0; fil < TerCanclyProcDetalle.GetLength(0); fil++)
                {

                    row = dt.NewRow();
                    row["Folio Tenencia"] = TerCanclyProcDetalle[fil, 0].ToString();
                    row["Trámite Server"] = TerCanclyProcDetalle[fil, 1].ToString();
                    row["Tipo Trámite"] = TerCanclyProcDetalle[fil, 2].ToString();
                    row["Fecha Entrada"] = TerCanclyProcDetalle[fil, 3].ToString();
                    row["Delegación"] = TerCanclyProcDetalle[fil, 4].ToString();
                    row["Municipio"] = TerCanclyProcDetalle[fil, 5].ToString();
                    dt.Rows.Add(row);

                }
                gcDetalles.DataSource = dt;
            }
    }
}
