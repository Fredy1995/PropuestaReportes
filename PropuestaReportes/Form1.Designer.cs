namespace PropuestaReportes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoTramite = new System.Windows.Forms.ComboBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcReportes = new DevExpress.XtraGrid.GridControl();
            this.gvContendio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbletiquetaTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblEtiqueta1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContendio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cbTipoTramite);
            this.groupBox1.Controls.Add(this.dtpFechaFinal);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Reporte";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(398, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tipo tramite:";
            // 
            // cbTipoTramite
            // 
            this.cbTipoTramite.AutoCompleteCustomSource.AddRange(new string[] {
            "Ingresados"});
            this.cbTipoTramite.FormattingEnabled = true;
            this.cbTipoTramite.Items.AddRange(new object[] {
            "Ingresados",
            "Terminados",
            "Cancelados",
            "En proceso"});
            this.cbTipoTramite.Location = new System.Drawing.Point(481, 42);
            this.cbTipoTramite.Name = "cbTipoTramite";
            this.cbTipoTramite.Size = new System.Drawing.Size(99, 24);
            this.cbTipoTramite.TabIndex = 5;
            this.cbTipoTramite.Text = "Seleccione";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(289, 44);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(99, 22);
            this.dtpFechaFinal.TabIndex = 4;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(100, 44);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(99, 22);
            this.dtpFechaInicial.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConsultar.Appearance.BackColor2 = System.Drawing.Color.DarkCyan;
            this.btnConsultar.Appearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnConsultar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Appearance.Options.UseBackColor = true;
            this.btnConsultar.Appearance.Options.UseBorderColor = true;
            this.btnConsultar.Appearance.Options.UseFont = true;
            this.btnConsultar.Appearance.Options.UseForeColor = true;
            this.btnConsultar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnConsultar.Location = new System.Drawing.Point(586, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 25);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(216, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha final:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha inicial:";
            // 
            // gcReportes
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gcReportes.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcReportes.Location = new System.Drawing.Point(12, 144);
            this.gcReportes.MainView = this.gvContendio;
            this.gcReportes.Name = "gcReportes";
            this.gcReportes.Size = new System.Drawing.Size(683, 254);
            this.gcReportes.TabIndex = 1;
            this.gcReportes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContendio});
            this.gcReportes.Visible = false;
            // 
            // gvContendio
            // 
            this.gvContendio.GridControl = this.gcReportes;
            this.gvContendio.Name = "gvContendio";
            this.gvContendio.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvContendio_RowClick);
            // 
            // lbletiquetaTotal
            // 
            this.lbletiquetaTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbletiquetaTotal.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lbletiquetaTotal.Appearance.Options.UseFont = true;
            this.lbletiquetaTotal.Appearance.Options.UseForeColor = true;
            this.lbletiquetaTotal.Location = new System.Drawing.Point(610, 404);
            this.lbletiquetaTotal.Name = "lbletiquetaTotal";
            this.lbletiquetaTotal.Size = new System.Drawing.Size(37, 16);
            this.lbletiquetaTotal.TabIndex = 2;
            this.lbletiquetaTotal.Text = "Total:";
            this.lbletiquetaTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Appearance.Options.UseFont = true;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(662, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(7, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            this.lblTotal.Visible = false;
            // 
            // lblEtiqueta1
            // 
            this.lblEtiqueta1.AutoSize = true;
            this.lblEtiqueta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEtiqueta1.Location = new System.Drawing.Point(13, 123);
            this.lblEtiqueta1.Name = "lblEtiqueta1";
            this.lblEtiqueta1.Size = new System.Drawing.Size(144, 18);
            this.lblEtiqueta1.TabIndex = 4;
            this.lblEtiqueta1.Text = "Tipo de concentrado";
            this.lblEtiqueta1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 424);
            this.Controls.Add(this.lblEtiqueta1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbletiquetaTotal);
            this.Controls.Add(this.gcReportes);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propuesta Reportes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContendio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbTipoTramite;
        private DevExpress.XtraGrid.GridControl gcReportes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContendio;
        private DevExpress.XtraEditors.LabelControl lbletiquetaTotal;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private System.Windows.Forms.Label lblEtiqueta1;
    }
}

