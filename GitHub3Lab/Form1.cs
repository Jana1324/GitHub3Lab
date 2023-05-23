using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GitHub3Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private TempProcessing tempProcessing;

        List<string> OutputTempList = new List<string>(); // список всех дней

        public void DisplayTempDay()
        {
            List<TempDate> tempDataList = tempProcessing.GetTempDayList();

            if (tempDataList.Count > 0)
            {
                foreach (var item in tempDataList)
                {
                    string output = string.Format("{0}: Максимальная температура: {1} градусов; Минимальная температура: {2} градусов; " +
                        "Средняя температура: {3} градусов",
                        item.Date.ToString("d"), item.MaxTemperature, item.MaxTemperature, item.AvgTemperature);

                    OutputTempList.Add(output);
                    listBoxTemp.Items.Add(output);
                }
                TemperatureCalc.Text = tempProcessing.FindLargestTemperatureChange();
            }
            else
            {
                MessageBox.Show("Файл не содержит данных!");
            }
        }
        private void buttonOpenFileTemp_Click_1(object sender, EventArgs e)
        {
            listBoxTemp.Items.Clear();
            TemperatureCalc.Text = "Самый сильный перепад:";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                tempProcessing = new TempProcessing(openFileDialog2.FileName);
                tempProcessing.ReadFromFile();
                DisplayTempDay();
                CreateChart2();
            }
        }

        private void OutputTemp_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog2.FileName;
                StringBuilder builder = new StringBuilder();

                foreach (var item in OutputTempList)
                {
                    builder.Append(item + "\n");
                }
                File.WriteAllText(filename, builder.ToString());
                MessageBox.Show("Файл записан");
            }
        }

        public void CreateChart2()
        {
            List<TempDate> tempDateList = tempProcessing.GetTempDayList();

            // очищение существующих серий о области графика
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            // Добавляем область для графика
            ChartArea chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);

            // Добавляем серию для графика максимальной температуры
            Series maxTemperatureSeries = new Series();
            maxTemperatureSeries.ChartType = SeriesChartType.Spline;
            maxTemperatureSeries.Color = Color.Red;
            maxTemperatureSeries.BorderWidth = 3;
            maxTemperatureSeries.Name = "Макс. темп.";
            chart2.Series.Add(maxTemperatureSeries);

            // Добавляем серию для графика минимальной температуры
            Series minTemperatureSeries = new Series();
            minTemperatureSeries.ChartType = SeriesChartType.Spline;
            minTemperatureSeries.Color = Color.Blue;
            minTemperatureSeries.BorderWidth = 3;
            minTemperatureSeries.Name = "Мин. темп.";
            chart2.Series.Add(minTemperatureSeries);


            foreach (var item in tempDateList)
            {
                chart2.Series["Макс. темп."].Points.AddXY(item.Date.ToShortDateString(), item.MaxTemperature);
                chart2.Series["Мин. темп."].Points.AddXY(item.Date.ToShortDateString(), item.MinTemperature);
            }
        }
    }
}
