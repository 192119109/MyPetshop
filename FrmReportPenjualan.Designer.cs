namespace PetShop
{
    partial class FrmReportPenjualan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartLaba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartPendapatanKotor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartItemTerjual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboJenis = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPeriodeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodeStart = new System.Windows.Forms.DateTimePicker();
            this.btnCetak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaba)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPendapatanKotor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemTerjual)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartLaba);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laba Keuntungan";
            // 
            // chartLaba
            // 
            chartArea7.Name = "ChartArea1";
            this.chartLaba.ChartAreas.Add(chartArea7);
            this.chartLaba.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartLaba.Legends.Add(legend7);
            this.chartLaba.Location = new System.Drawing.Point(3, 16);
            this.chartLaba.Name = "chartLaba";
            this.chartLaba.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Laba Bersih";
            this.chartLaba.Series.Add(series7);
            this.chartLaba.Size = new System.Drawing.Size(852, 339);
            this.chartLaba.TabIndex = 0;
            this.chartLaba.Text = "Laba Bersih";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartPendapatanKotor);
            this.groupBox2.Location = new System.Drawing.Point(12, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pendapatan Kotor";
            // 
            // chartPendapatanKotor
            // 
            chartArea8.Name = "ChartArea1";
            this.chartPendapatanKotor.ChartAreas.Add(chartArea8);
            this.chartPendapatanKotor.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Name = "Pendapatan Kotor";
            this.chartPendapatanKotor.Legends.Add(legend8);
            this.chartPendapatanKotor.Location = new System.Drawing.Point(3, 16);
            this.chartPendapatanKotor.Name = "chartPendapatanKotor";
            this.chartPendapatanKotor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Pendapatan Kotor";
            series8.Name = "Pendapatan Kotor";
            this.chartPendapatanKotor.Series.Add(series8);
            this.chartPendapatanKotor.Size = new System.Drawing.Size(730, 289);
            this.chartPendapatanKotor.TabIndex = 0;
            this.chartPendapatanKotor.Text = "Total Penjualan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartItemTerjual);
            this.groupBox3.Location = new System.Drawing.Point(876, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 388);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Terjual";
            // 
            // chartItemTerjual
            // 
            chartArea9.Name = "ChartArea1";
            this.chartItemTerjual.ChartAreas.Add(chartArea9);
            this.chartItemTerjual.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chartItemTerjual.Legends.Add(legend9);
            this.chartItemTerjual.Location = new System.Drawing.Point(3, 16);
            this.chartItemTerjual.Name = "chartItemTerjual";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "ItemTerjual";
            this.chartItemTerjual.Series.Add(series9);
            this.chartItemTerjual.Size = new System.Drawing.Size(476, 369);
            this.chartItemTerjual.TabIndex = 0;
            this.chartItemTerjual.Text = "Item Terjual";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvData);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnCetak);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(754, 406);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 278);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tools";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 69);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(586, 162);
            this.dgvData.TabIndex = 29;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboJenis);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 47);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jenis";
            // 
            // cboJenis
            // 
            this.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJenis.FormattingEnabled = true;
            this.cboJenis.Items.AddRange(new object[] {
            "Laba Keuntungan",
            "Jumlah Item Terjual",
            "Total Penjualan Item"});
            this.cboJenis.Location = new System.Drawing.Point(6, 16);
            this.cboJenis.Name = "cboJenis";
            this.cboJenis.Size = new System.Drawing.Size(228, 23);
            this.cboJenis.TabIndex = 26;
            this.cboJenis.SelectedIndexChanged += new System.EventHandler(this.CboJenis_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dtpPeriodeEnd);
            this.groupBox5.Controls.Add(this.dtpPeriodeStart);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(252, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 47);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Periode";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "s/d";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpPeriodeEnd
            // 
            this.dtpPeriodeEnd.CustomFormat = "MMMM yyyy";
            this.dtpPeriodeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodeEnd.Location = new System.Drawing.Point(188, 18);
            this.dtpPeriodeEnd.Name = "dtpPeriodeEnd";
            this.dtpPeriodeEnd.Size = new System.Drawing.Size(144, 20);
            this.dtpPeriodeEnd.TabIndex = 1;
            this.dtpPeriodeEnd.ValueChanged += new System.EventHandler(this.DtpPeriodeStart_ValueChanged);
            // 
            // dtpPeriodeStart
            // 
            this.dtpPeriodeStart.CustomFormat = "MMMM yyyy";
            this.dtpPeriodeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodeStart.Location = new System.Drawing.Point(6, 18);
            this.dtpPeriodeStart.Name = "dtpPeriodeStart";
            this.dtpPeriodeStart.Size = new System.Drawing.Size(144, 20);
            this.dtpPeriodeStart.TabIndex = 0;
            this.dtpPeriodeStart.ValueChanged += new System.EventHandler(this.DtpPeriodeStart_ValueChanged);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Image = global::PetShop.Properties.Resources.edit_AeQ_icon;
            this.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCetak.Location = new System.Drawing.Point(456, 237);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(142, 37);
            this.btnCetak.TabIndex = 25;
            this.btnCetak.Text = "Cetak Laporan";
            this.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCetak.UseVisualStyleBackColor = false;
            // 
            // FrmReportPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReportPenjualan";
            this.Text = "Report Penjualan";
            this.Load += new System.EventHandler(this.FrmReportPenjualan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLaba)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPendapatanKotor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartItemTerjual)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLaba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPendapatanKotor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartItemTerjual;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cboJenis;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPeriodeEnd;
        private System.Windows.Forms.DateTimePicker dtpPeriodeStart;
        private System.Windows.Forms.Button btnCetak;
    }
}