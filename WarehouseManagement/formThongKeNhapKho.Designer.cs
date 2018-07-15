namespace WarehouseManagement
{
    partial class formThongKeNhapKho
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThongKeNhapKho));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.queryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource6 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.queryBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.queryBindingSource6;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "Query.Thang";
            series1.DataSource = this.sqlDataSource5;
            series1.Name = "Năm nay";
            series1.ValueDataMembersSerializable = "Query.Tong";
            series1.View = lineSeriesView1;
            series2.ArgumentDataMember = "Query.Thang";
            series2.DataSource = this.sqlDataSource6;
            series2.Name = "Năm trước";
            series2.ValueDataMembersSerializable = "Query.Tong";
            series2.View = lineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(854, 476);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "THỐNG KÊ TIỀN NHẬP HÀNG THEO NĂM";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // queryBindingSource1
            // 
            this.queryBindingSource1.DataMember = "Query";
            this.queryBindingSource1.DataSource = this.sqlDataSource2;
            // 
            // queryBindingSource2
            // 
            this.queryBindingSource2.DataMember = "Query";
            this.queryBindingSource2.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery5.Name = "Query";
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // queryBindingSource3
            // 
            this.queryBindingSource3.DataMember = "Query";
            this.queryBindingSource3.DataSource = this.sqlDataSource3;
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource4.Name = "sqlDataSource4";
            customSqlQuery6.Name = "Query";
            customSqlQuery6.Sql = resources.GetString("customSqlQuery6.Sql");
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery6});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // queryBindingSource4
            // 
            this.queryBindingSource4.DataMember = "Query";
            this.queryBindingSource4.DataSource = this.sqlDataSource4;
            // 
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource5.Name = "sqlDataSource5";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // queryBindingSource5
            // 
            this.queryBindingSource5.DataMember = "Query";
            this.queryBindingSource5.DataSource = this.sqlDataSource5;
            // 
            // sqlDataSource6
            // 
            this.sqlDataSource6.ConnectionName = "dangthitien.Warehouse_Management.dbo";
            this.sqlDataSource6.Name = "sqlDataSource6";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource6.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource6.ResultSchemaSerializable = resources.GetString("sqlDataSource6.ResultSchemaSerializable");
            // 
            // queryBindingSource6
            // 
            this.queryBindingSource6.DataMember = "Query";
            this.queryBindingSource6.DataSource = this.sqlDataSource6;
            // 
            // formThongKeNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 476);
            this.Controls.Add(this.chartControl1);
            this.Name = "formThongKeNhapKho";
            this.Text = "Thống kê nhập kho";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource queryBindingSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private System.Windows.Forms.BindingSource queryBindingSource2;
        private System.Windows.Forms.BindingSource queryBindingSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private System.Windows.Forms.BindingSource queryBindingSource4;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private System.Windows.Forms.BindingSource queryBindingSource5;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
        private System.Windows.Forms.BindingSource queryBindingSource6;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource6;
    }
}