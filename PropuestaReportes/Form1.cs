using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Extensions;

namespace PropuestaReportes
{
    public partial class Form1 : Form
    {
        
        string[,] DatosIngresados = new string[18, 4] {
            { "03/01/2021", "Atlixco", "ATLIXCO","34" },
            { "23/01/2021", "Atlixco", "ATZITZIHUACAN","12" },
             { "13/02/2021", "Atlixco", "HUAQUECHULA","2" },
            { "22/02/2021", "Atlixco", "NEALTICAN","4" },
             { "17/03/2021", "Atlixco", "TIANGUISMANALCO","5" },
            { "08/03/2021", "Atlixco", "TOCHIMILCO","6" },
             { "10/05/2021", "Tehuacan", "AJALPAN","3" },
            { "15/05/2021", "Tehuacan", "ALTEPEXI","8" },
             { "13/05/2021", "Tehuacan", "CALTEPEC","9" },
            { "21/06/2021", "Xicotepec", "FRANCISCO Z. MENA","23" },
            { "27/06/2021", "Xicotepec", "JALPAN","44" },
            { "12/06/2021", "Xicotepec", "PANTEPEC","2" },
            { "18/06/2021", "Xicotepec", "TLACUILOTEPEC","5" },
            { "23/06/2021", "Xicotepec", "TLAXCO","6" },
            { "16/06/2021", "Xicotepec", "VENUSTIANO CARRANZA","19" },
            { "11/06/2021", "Xicotepec", "XICOTEPEC DE JUÁREZ","28" },
            { "10/06/2021", "Xicotepec", "ZIHUATEUTLA","34" },
            { "05/06/2021", "Xicotepec", "PUEBLA","112" }
            };

        string[,] DatosTerminados = new string[18, 8] {
            { "03/01/2021","Atlixco" ,"ATLIXCO","","19","","x","19"},
            { "23/01/2021","Atlixco","ATZITZIHUACAN","2","3","11","","16" },
            { "13/02/2021","Atlixco","HUAQUECHULA","4","5","3","","12" },
            { "22/02/2021","Atlixco","NEALTICAN","6","5","7","","18" },
            { "17/03/2021", "Atlixco","TIANGUISMANALCO","3","21","","","27" },
            { "08/03/2021","Atlixco","TOCHIMILCO","2","1","2","","5" },

             { "10/05/2021","Tehuacan", "AJALPAN","3","3","21","","27" },
            { "15/05/2021","Tehuacan" ,"ALTEPEXI","8","16","3","","26"},
             { "13/05/2021", "Tehuacan","CALTEPEC","4","5","3","","12"},

            { "21/06/2021","Xicotepec", "FRANCISCO Z. MENA","4" ,"12","11","","27"},
            { "27/06/2021","Xicotepec", "JALPAN","7","4","12","","23"},
            { "12/06/2021", "Xicotepec","PANTEPEC","12" ,"6","19","","37"},
            { "18/06/2021", "Xicotepec","TLACUILOTEPEC","3","8","22","","33"},
            { "23/06/2021", "Xicotepec","TLAXCO","8","16","3","","27"},
            { "16/06/2021", "Xicotepec","VENUSTIANO CARRANZA","5","13","5","","23"},
            { "11/06/2021", "Xicotepec","XICOTEPEC DE JUÁREZ","9","10","2","","21"},
            { "10/06/2021", "Xicotepec","ZIHUATEUTLA","7","8","9","","24"},

            { "05/06/2021","Puebla" ,"PUEBLA","","66","","x","66"}
            };
        string[,] DatosCancelados = new string[18, 8] {
            { "03/01/2021","Atlixco" ,"ATLIXCO","","19","","x","19"},
            { "23/01/2021","Atlixco","ATZITZIHUACAN","2","3","11","","16" },
            { "13/02/2021","Atlixco","HUAQUECHULA","4","5","3","","12" },
            { "22/02/2021","Atlixco","NEALTICAN","6","5","7","","18" },
            { "17/03/2021", "Atlixco","TIANGUISMANALCO","3","21","","","27" },
            { "08/03/2021","Atlixco","TOCHIMILCO","2","1","2","","5" },

             { "10/05/2021","Tehuacan", "AJALPAN","3","3","21","","27" },
            { "15/05/2021","Tehuacan" ,"ALTEPEXI","8","16","3","","26"},
             { "13/05/2021", "Tehuacan","CALTEPEC","4","5","3","","12"},

            { "21/06/2021","Xicotepec", "FRANCISCO Z. MENA","4" ,"12","11","","27"},
            { "27/06/2021","Xicotepec", "JALPAN","7","4","12","","23"},
            { "12/06/2021", "Xicotepec","PANTEPEC","12" ,"6","19","","37"},
            { "18/06/2021", "Xicotepec","TLACUILOTEPEC","3","8","22","","33"},
            { "23/06/2021", "Xicotepec","TLAXCO","8","16","3","","27"},
            { "16/06/2021", "Xicotepec","VENUSTIANO CARRANZA","5","13","5","","23"},
            { "11/06/2021", "Xicotepec","XICOTEPEC DE JUÁREZ","9","10","2","","21"},
             { "10/06/2021", "Xicotepec","ZIHUATEUTLA","7","8","9","","24"},

            { "05/06/2021","Puebla" ,"PUEBLA","","66","","x","66"}
            };
        string[,] DatosEnProceso = new string[18, 8] {
            { "03/01/2021","Atlixco" ,"ATLIXCO","","19","","x","19"},
            { "23/01/2021","Atlixco","ATZITZIHUACAN","2","3","11","","16" },
             { "13/02/2021","Atlixco","HUAQUECHULA","4","5","3","","12" },
            { "22/02/2021","Atlixco","NEALTICAN","6","5","7","","18" },
            { "17/03/2021", "Atlixco","TIANGUISMANALCO","3","21","","","27" },
            { "08/03/2021","Atlixco","TOCHIMILCO","2","1","2","","5" },

             { "10/05/2021","Tehuacan", "AJALPAN","3","3","21","","27" },
            { "15/05/2021","Tehuacan" ,"ALTEPEXI","8","16","3","","26"},
             { "13/05/2021", "Tehuacan","CALTEPEC","4","5","3","","12"},

            { "21/06/2021","Xicotepec", "FRANCISCO Z. MENA","4" ,"12","11","","27"},
            { "27/06/2021","Xicotepec", "JALPAN","7","4","12","","23"},
            { "12/06/2021", "Xicotepec","PANTEPEC","12" ,"6","19","","37"},
            { "18/06/2021", "Xicotepec","TLACUILOTEPEC","3","8","22","","33"},
            { "23/06/2021", "Xicotepec","TLAXCO","8","16","3","","27"},
            { "16/06/2021", "Xicotepec","VENUSTIANO CARRANZA","5","13","5","","23"},
            { "11/06/2021", "Xicotepec","XICOTEPEC DE JUÁREZ","9","10","2","","21"},
            { "10/06/2021", "Xicotepec","ZIHUATEUTLA","7","8","9","","24"},

            { "05/06/2021","Puebla" ,"PUEBLA","","66","","x","66"}
            };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int suma;
            gcReportes.Visible = true;
            lbletiquetaTotal.Visible = true;
            lblTotal.Visible = true;
            lblEtiqueta1.Visible = true;
            DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicial.Value).Date;
            DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.Value).Date;
            DataTable dt = new DataTable();
            // Variables para las columnas y las filas
            DataColumn column;
            DataRow row;
            // Se tiene que crear primero la columna asignandole Nombre y Tipo de datos    

            try
            {

            
            if (cbTipoTramite.SelectedItem.ToString() == "Ingresados")
            {
                suma = 0;
                gcReportes.DataSource = null;
                gvContendio.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Totales";
                dt.Columns.Add(column);
                    for (int fil = 0; fil < DatosIngresados.GetLength(0); fil++)
                    {
                        if (Convert.ToDateTime(DatosIngresados[fil, 0].ToString()) >= fechaInicial && Convert.ToDateTime(DatosIngresados[fil, 0].ToString()) <= fechaFinal)
                    {
                            
                        row = dt.NewRow();
                        row["Delegación"] = DatosIngresados[fil, 1].ToString();
                        row["Municipio"] = DatosIngresados[fil, 2].ToString();
                        row["Totales"] = DatosIngresados[fil, 3].ToString();
                        suma += Convert.ToInt32(DatosIngresados[fil, 3]);
                        dt.Rows.Add(row);

                    }
                }
                lblEtiqueta1.Text = "Ingresados concentrado";
                gcReportes.DataSource = dt;
                lblTotal.Text = suma.ToString();
               
            }
            else
            if (cbTipoTramite.SelectedItem.ToString() == "Terminados")
            {
                suma = 0;
                gcReportes.DataSource = null;
                gvContendio.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Registro";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "RPP";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Alta";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Descentralizados";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Totales";
                dt.Columns.Add(column);
                for (int fil = 0; fil < DatosTerminados.GetLength(0); fil++)
                {
                    if (Convert.ToDateTime(DatosTerminados[fil, 0].ToString()) >= fechaInicial && Convert.ToDateTime(DatosTerminados[fil, 0].ToString()) <= fechaFinal)
                    {
                        row = dt.NewRow();
                        row["Delegación"] = DatosTerminados[fil, 1].ToString();
                        row["Municipio"] = DatosTerminados[fil, 2].ToString();
                        row["Registro"] = DatosTerminados[fil, 3].ToString();
                        row["RPP"] = DatosTerminados[fil, 4].ToString();
                        row["Alta"] = DatosTerminados[fil, 5].ToString();
                        row["Descentralizados"] = DatosTerminados[fil, 6].ToString();
                        row["Totales"] = DatosTerminados[fil, 7].ToString();
                        suma += Convert.ToInt32(DatosTerminados[fil, 7]);
                        dt.Rows.Add(row);

                    }
                }
                lblEtiqueta1.Text = "Terminados concentrado";
                gcReportes.DataSource = dt;
                lblTotal.Text = suma.ToString();
            }
            else
            if (cbTipoTramite.SelectedItem.ToString() == "Cancelados")
            {
                suma = 0;
                gcReportes.DataSource = null;
                gvContendio.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Registro";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "RPP";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Alta";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Descentralizados";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Totales";
                dt.Columns.Add(column);
                for (int fil = 0; fil < DatosCancelados.GetLength(0); fil++)
                {
                    if (Convert.ToDateTime(DatosCancelados[fil, 0].ToString()) >= fechaInicial && Convert.ToDateTime(DatosCancelados[fil, 0].ToString()) <= fechaFinal)
                    {
                        row = dt.NewRow();
                        row["Delegación"] = DatosCancelados[fil, 1].ToString();
                        row["Municipio"] = DatosCancelados[fil, 2].ToString();
                        row["Registro"] = DatosCancelados[fil, 3].ToString();
                        row["RPP"] = DatosCancelados[fil, 4].ToString();
                        row["Alta"] = DatosCancelados[fil, 5].ToString();
                        row["Descentralizados"] = DatosCancelados[fil, 6].ToString();
                        row["Totales"] = DatosCancelados[fil, 7].ToString();
                        suma += Convert.ToInt32(DatosCancelados[fil, 7]);
                        dt.Rows.Add(row);

                    }
                }
                lblEtiqueta1.Text = "Cancelados concentrado";
                gcReportes.DataSource = dt;
                lblTotal.Text = suma.ToString();
            } else
            if (cbTipoTramite.SelectedItem.ToString() == "En proceso")
            {
                suma = 0;
                gcReportes.DataSource = null;
                gvContendio.Columns.Clear();
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Delegación";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Municipio";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Registro";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "RPP";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Alta";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Descentralizados";
                dt.Columns.Add(column);
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Totales";
                dt.Columns.Add(column);
                for (int fil = 0; fil < DatosEnProceso.GetLength(0); fil++)
                {
                    if (Convert.ToDateTime(DatosEnProceso[fil, 0].ToString()) >= fechaInicial && Convert.ToDateTime(DatosEnProceso[fil, 0].ToString()) <= fechaFinal)
                    {
                        row = dt.NewRow();
                        row["Delegación"] = DatosEnProceso[fil, 1].ToString();
                        row["Municipio"] = DatosEnProceso[fil, 2].ToString();
                        row["Registro"] = DatosEnProceso[fil, 3].ToString();
                        row["RPP"] = DatosEnProceso[fil, 4].ToString();
                        row["Alta"] = DatosEnProceso[fil, 5].ToString();
                        row["Descentralizados"] = DatosEnProceso[fil, 6].ToString();
                        row["Totales"] = DatosEnProceso[fil, 7].ToString();
                        suma += Convert.ToInt32(DatosEnProceso[fil, 7]);
                        dt.Rows.Add(row);

                    }
                }
                lblEtiqueta1.Text = "En proceso...";
                gcReportes.DataSource = dt;
                lblTotal.Text = suma.ToString();
                    
            }
            }
            catch (Exception ex)
            {
                gcReportes.Visible = false;
                lbletiquetaTotal.Visible= false;
                lblTotal.Visible = false;
                lblEtiqueta1.Visible = false;
                MessageBox.Show("¡Debe seleccionar un tipo de tramite!");
            }
        }

        private void gvContendio_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          
            //int valor;
            /*if (gvContendio.SelectedRowsCount > 0)
            {
                valor = Convert.ToInt32(gvContendio.GetRowCellValue(gvContendio, "Totales"));

            }*/
            FrmDetalles frmdetalles = new FrmDetalles(cbTipoTramite.SelectedItem.ToString());
            frmdetalles.ShowDialog(this);
        }
    }
}
