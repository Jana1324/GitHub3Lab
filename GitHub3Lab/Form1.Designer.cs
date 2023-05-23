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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OutputRun = new System.Windows.Forms.Button();
            this.buttonOpenFileRun = new System.Windows.Forms.Button();
            this.DistanceCalc = new System.Windows.Forms.Label();
            this.listBoxRun = new System.Windows.Forms.ListBox();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.OutputTemp = new System.Windows.Forms.Button();
            this.TemperatureCalc = new System.Windows.Forms.Label();
            this.buttonOpenFileTemp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputRun
            // 
            this.OutputRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OutputRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputRun.Location = new System.Drawing.Point(272, 11);
            this.OutputRun.Name = "OutputRun";
            this.OutputRun.Size = new System.Drawing.Size(222, 38);
            this.OutputRun.TabIndex = 29;
            this.OutputRun.Text = "Вывести в файл";
            this.OutputRun.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFileRun
            // 
            this.buttonOpenFileRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFileRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileRun.Location = new System.Drawing.Point(10, 11);
            this.buttonOpenFileRun.Name = "buttonOpenFileRun";
            this.buttonOpenFileRun.Size = new System.Drawing.Size(221, 38);
            this.buttonOpenFileRun.TabIndex = 28;
            this.buttonOpenFileRun.Text = "Открыть файл пробежек";
            this.buttonOpenFileRun.UseVisualStyleBackColor = false;
            this.buttonOpenFileRun.Click += new System.EventHandler(this.buttonOpenFileRun_Click);
            // 
            // DistanceCalc
            // 
            this.DistanceCalc.AutoSize = true;
            this.DistanceCalc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceCalc.Location = new System.Drawing.Point(7, 323);
            this.DistanceCalc.Name = "DistanceCalc";
            this.DistanceCalc.Size = new System.Drawing.Size(186, 19);
            this.DistanceCalc.TabIndex = 32;
            this.DistanceCalc.Text = "Пройдено за выходные: ";
            // 
            // listBoxRun
            // 
            this.listBoxRun.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRun.FormattingEnabled = true;
            this.listBoxRun.HorizontalScrollbar = true;
            this.listBoxRun.ItemHeight = 19;
            this.listBoxRun.Location = new System.Drawing.Point(10, 362);
            this.listBoxRun.Name = "listBoxRun";
            this.listBoxRun.ScrollAlwaysVisible = true;
            this.listBoxRun.Size = new System.Drawing.Size(486, 289);
            this.listBoxRun.TabIndex = 31;
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.HorizontalScrollbar = true;
            this.listBoxTemp.ItemHeight = 19;
            this.listBoxTemp.Location = new System.Drawing.Point(590, 369);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.ScrollAlwaysVisible = true;
            this.listBoxTemp.Size = new System.Drawing.Size(485, 289);
            this.listBoxTemp.TabIndex = 36;
            // 
            // OutputTemp
            // 
            this.OutputTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.OutputTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputTemp.Location = new System.Drawing.Point(849, 11);
            this.OutputTemp.Name = "OutputTemp";
            this.OutputTemp.Size = new System.Drawing.Size(225, 38);
            this.OutputTemp.TabIndex = 35;
            this.OutputTemp.Text = "Вывести в файл\r\n";
            this.OutputTemp.UseVisualStyleBackColor = false;
            // 
            // TemperatureCalc
            // 
            this.TemperatureCalc.AutoSize = true;
            this.TemperatureCalc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureCalc.Location = new System.Drawing.Point(587, 337);
            this.TemperatureCalc.Name = "TemperatureCalc";
            this.TemperatureCalc.Size = new System.Drawing.Size(190, 19);
            this.TemperatureCalc.TabIndex = 34;
            this.TemperatureCalc.Text = "Самый сильный перепад:";
            // 
            // buttonOpenFileTemp
            // 
            this.buttonOpenFileTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFileTemp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFileTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenFileTemp.Location = new System.Drawing.Point(590, 11);
            this.buttonOpenFileTemp.Name = "buttonOpenFileTemp";
            this.buttonOpenFileTemp.Size = new System.Drawing.Size(221, 38);
            this.buttonOpenFileTemp.TabIndex = 33;
            this.buttonOpenFileTemp.Text = "Открыть файл температур";
            this.buttonOpenFileTemp.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(53, 72);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(391, 229);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 674);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.OutputTemp);
            this.Controls.Add(this.TemperatureCalc);
            this.Controls.Add(this.buttonOpenFileTemp);
            this.Controls.Add(this.DistanceCalc);
            this.Controls.Add(this.listBoxRun);
            this.Controls.Add(this.OutputRun);
            this.Controls.Add(this.buttonOpenFileRun);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutputRun;
        private System.Windows.Forms.Button buttonOpenFileRun;
        private System.Windows.Forms.Label DistanceCalc;
        private System.Windows.Forms.ListBox listBoxRun;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Button OutputTemp;
        private System.Windows.Forms.Label TemperatureCalc;
        private System.Windows.Forms.Button buttonOpenFileTemp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}