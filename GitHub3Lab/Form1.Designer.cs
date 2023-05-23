namespace GitHub3Lab
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OutputRun = new System.Windows.Forms.Button();
            this.buttonOpenFileRun = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DistanceCalc = new System.Windows.Forms.Label();
            this.listBoxRun = new System.Windows.Forms.ListBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.OutputTemp = new System.Windows.Forms.Button();
            this.TemperatureCalc = new System.Windows.Forms.Label();
            this.buttonOpenFileTemp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputRun
            // 
            this.OutputRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OutputRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputRun.Location = new System.Drawing.Point(363, 13);
            this.OutputRun.Margin = new System.Windows.Forms.Padding(4);
            this.OutputRun.Name = "OutputRun";
            this.OutputRun.Size = new System.Drawing.Size(296, 47);
            this.OutputRun.TabIndex = 29;
            this.OutputRun.Text = "Вывести в файл";
            this.OutputRun.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFileRun
            // 
            this.buttonOpenFileRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFileRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileRun.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFileRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFileRun.Name = "buttonOpenFileRun";
            this.buttonOpenFileRun.Size = new System.Drawing.Size(295, 47);
            this.buttonOpenFileRun.TabIndex = 28;
            this.buttonOpenFileRun.Text = "Открыть файл пробежек";
            this.buttonOpenFileRun.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(13, 77);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(646, 300);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";

            // 
            // DistanceCalc
            // 
            this.DistanceCalc.AutoSize = true;
            this.DistanceCalc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceCalc.Location = new System.Drawing.Point(9, 397);
            this.DistanceCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DistanceCalc.Name = "DistanceCalc";
            this.DistanceCalc.Size = new System.Drawing.Size(233, 24);
            this.DistanceCalc.TabIndex = 32;
            this.DistanceCalc.Text = "Пройдено за выходные: ";
            // 
            // listBoxRun
            // 
            this.listBoxRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRun.FormattingEnabled = true;
            this.listBoxRun.HorizontalScrollbar = true;
            this.listBoxRun.ItemHeight = 21;
            this.listBoxRun.Location = new System.Drawing.Point(13, 445);
            this.listBoxRun.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRun.Name = "listBoxRun";
            this.listBoxRun.ScrollAlwaysVisible = true;
            this.listBoxRun.Size = new System.Drawing.Size(646, 361);
            this.listBoxRun.TabIndex = 31;

            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(787, 77);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(647, 310);
            this.chart2.TabIndex = 37;
            this.chart2.Text = "chart2";
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.HorizontalScrollbar = true;
            this.listBoxTemp.ItemHeight = 21;
            this.listBoxTemp.Location = new System.Drawing.Point(787, 454);
            this.listBoxTemp.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.ScrollAlwaysVisible = true;
            this.listBoxTemp.Size = new System.Drawing.Size(645, 361);
            this.listBoxTemp.TabIndex = 36;
            // 
            // OutputTemp
            // 
            this.OutputTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OutputTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputTemp.Location = new System.Drawing.Point(1132, 13);
            this.OutputTemp.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTemp.Name = "OutputTemp";
            this.OutputTemp.Size = new System.Drawing.Size(300, 47);
            this.OutputTemp.TabIndex = 35;
            this.OutputTemp.Text = "Вывести в файл\r\n";
            this.OutputTemp.UseVisualStyleBackColor = false;
            // 
            // TemperatureCalc
            // 
            this.TemperatureCalc.AutoSize = true;
            this.TemperatureCalc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureCalc.Location = new System.Drawing.Point(783, 415);
            this.TemperatureCalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TemperatureCalc.Name = "TemperatureCalc";
            this.TemperatureCalc.Size = new System.Drawing.Size(238, 24);
            this.TemperatureCalc.TabIndex = 34;
            this.TemperatureCalc.Text = "Самый сильный перепад:";
            // 
            // buttonOpenFileTemp
            // 
            this.buttonOpenFileTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFileTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileTemp.Location = new System.Drawing.Point(787, 13);
            this.buttonOpenFileTemp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFileTemp.Name = "buttonOpenFileTemp";
            this.buttonOpenFileTemp.Size = new System.Drawing.Size(295, 47);
            this.buttonOpenFileTemp.TabIndex = 33;
            this.buttonOpenFileTemp.Text = "Открыть файл температур";
            this.buttonOpenFileTemp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 732);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.OutputTemp);
            this.Controls.Add(this.TemperatureCalc);
            this.Controls.Add(this.buttonOpenFileTemp);
            this.Controls.Add(this.DistanceCalc);
            this.Controls.Add(this.listBoxRun);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.OutputRun);
            this.Controls.Add(this.buttonOpenFileRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutputRun;
        private System.Windows.Forms.Button buttonOpenFileRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label DistanceCalc;
        private System.Windows.Forms.ListBox listBoxRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Button OutputTemp;
        private System.Windows.Forms.Label TemperatureCalc;
        private System.Windows.Forms.Button buttonOpenFileTemp;
    }
}