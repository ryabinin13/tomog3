
namespace tomog3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonScan = new System.Windows.Forms.Button();
            this.numericUpDownPhi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonClearGrafic = new System.Windows.Forms.Button();
            this.buttonGraficAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(250, 558);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(139, 50);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "жестко сканировать";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // numericUpDownPhi
            // 
            this.numericUpDownPhi.Location = new System.Drawing.Point(517, 120);
            this.numericUpDownPhi.Name = "numericUpDownPhi";
            this.numericUpDownPhi.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPhi.TabIndex = 2;
            this.numericUpDownPhi.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "угол";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(517, 209);
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownN.TabIndex = 4;
            this.numericUpDownN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "номер старшего датчика";
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(517, 42);
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownH.TabIndex = 6;
            this.numericUpDownH.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Расстояние между датчиками";
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(517, 300);
            this.numericUpDownS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownS.TabIndex = 8;
            this.numericUpDownS.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "параметр s";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(707, 13);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "график";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(692, 626);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // buttonClearGrafic
            // 
            this.buttonClearGrafic.Location = new System.Drawing.Point(504, 568);
            this.buttonClearGrafic.Name = "buttonClearGrafic";
            this.buttonClearGrafic.Size = new System.Drawing.Size(133, 50);
            this.buttonClearGrafic.TabIndex = 12;
            this.buttonClearGrafic.Text = "Очистить график";
            this.buttonClearGrafic.UseVisualStyleBackColor = true;
            this.buttonClearGrafic.Click += new System.EventHandler(this.buttonClearGrafic_Click);
            // 
            // buttonGraficAdd
            // 
            this.buttonGraficAdd.Location = new System.Drawing.Point(504, 473);
            this.buttonGraficAdd.Name = "buttonGraficAdd";
            this.buttonGraficAdd.Size = new System.Drawing.Size(133, 53);
            this.buttonGraficAdd.TabIndex = 13;
            this.buttonGraficAdd.Text = "Добавить график";
            this.buttonGraficAdd.UseVisualStyleBackColor = true;
            this.buttonGraficAdd.Click += new System.EventHandler(this.buttonGraficAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 676);
            this.Controls.Add(this.buttonGraficAdd);
            this.Controls.Add(this.buttonClearGrafic);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPhi);
            this.Controls.Add(this.buttonScan);
            this.Name = "Form1";
            this.Text = "форма";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.NumericUpDown numericUpDownPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonClearGrafic;
        private System.Windows.Forms.Button buttonGraficAdd;
    }
}

