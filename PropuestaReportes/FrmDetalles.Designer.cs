namespace PropuestaReportes
{
    partial class FrmDetalles
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
            this.gcDetalles = new DevExpress.XtraGrid.GridControl();
            this.gvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTipotramite = new DevExpress.XtraEditors.LabelControl();
            this.btnCerrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDetalles
            // 
            this.gcDetalles.Location = new System.Drawing.Point(13, 42);
            this.gcDetalles.MainView = this.gvDetalles;
            this.gcDetalles.Name = "gcDetalles";
            this.gcDetalles.Size = new System.Drawing.Size(711, 332);
            this.gcDetalles.TabIndex = 0;
            this.gcDetalles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalles});
            // 
            // gvDetalles
            // 
            this.gvDetalles.GridControl = this.gcDetalles;
            this.gvDetalles.Name = "gvDetalles";
            // 
            // lblTipotramite
            // 
            this.lblTipotramite.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipotramite.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipotramite.Appearance.Options.UseFont = true;
            this.lblTipotramite.Appearance.Options.UseForeColor = true;
            this.lblTipotramite.Location = new System.Drawing.Point(13, 13);
            this.lblTipotramite.Name = "lblTipotramite";
            this.lblTipotramite.Size = new System.Drawing.Size(102, 19);
            this.lblTipotramite.TabIndex = 2;
            this.lblTipotramite.Text = "Tipo trámite";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.btnCerrar.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Appearance.Options.UseBackColor = true;
            this.btnCerrar.Appearance.Options.UseBorderColor = true;
            this.btnCerrar.Appearance.Options.UseFont = true;
            this.btnCerrar.Appearance.Options.UseForeColor = true;
            this.btnCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(601, 399);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 29);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 463);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTipotramite);
            this.Controls.Add(this.gcDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.FrmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDetalles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalles;
        private DevExpress.XtraEditors.LabelControl lblTipotramite;
        private DevExpress.XtraEditors.SimpleButton btnCerrar;
    }
}