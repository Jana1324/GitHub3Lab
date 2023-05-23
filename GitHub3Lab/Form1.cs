using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace GitHub3Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RunProcessing runPocessing;
        List<string> OutputRunList = new List<string>(); // список всех дней

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DisplayRunDay()
        {
            List<RunDay> runDataList = runPocessing.GetRunDayList();

            if (runDataList.Count > 0)
            {
                string output = "";

                foreach (var item in runDataList)
                {
                    output = string.Format(" День {0}: Длительность: {1} мин, Расстояние: {2} км, Максимальная скорость: {3} км/ч, " +
                        "Минимальная скорость: {4} км/ч, Средняя скорость: {5} км/ч, Средний пульс: {6} уд/мин\n", item.DayOfWeek,
                        item.Duration, item.Distance, item.MaxSpeed, item.MinSpeed, item.AvgSpeed,
                        item.AvgPulse);
                    listBoxRun.Items.Add(output);
                    OutputRunList.Add(output);
                }
                DistanceCalc.Text += runPocessing.CalculateWeekendDistanceSum().ToString() + " км";
            }
            else
            {
                MessageBox.Show("Файл не содержит данных!");
            }
        }

        private void GenerateCharts()
        {
            List<RunDay> runDataList = runPocessing.GetRunDayList();  // получение объектов 

            // очищение существующих серий о области графика
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Добавляем область для графика
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Добавляем серию для графика длительностей
            Series durationSeries = new Series();
            durationSeries.ChartType = SeriesChartType.Column;  // тип кривой
            durationSeries.Color = Color.Orange;
            //durationSeries.BorderWidth = 3;
            durationSeries.Name = "Длительность";
            chart1.Series.Add(durationSeries);

            // Добавляем серию для графика расстояний
            Series distanceSeries = new Series();
            distanceSeries.ChartType = SeriesChartType.Column; // тип кривой
            distanceSeries.Color = Color.Blue;
            distanceSeries.Name = "Дистанция";
            //distanceSeries.BorderWidth = 3; // ширина
            chart1.Series.Add(distanceSeries);

            // Заполняем данные для графиков
            for (int i = 0; i < runDataList.Count; i++)
            {
                // первый аргумент - позиция точки по оси Х, начинается с 1
                // второй аргумент - значение точки по оси Y - Duration и Distance
                durationSeries.Points.AddXY(i + 1, runDataList[i].Duration);
                distanceSeries.Points.AddXY(i + 1, runDataList[i].Distance);
            }
        }

        private void buttonOpenFileRun_Click(object sender, EventArgs e)  // открытие файла
        {
            listBoxRun.Items.Clear();
            DistanceCalc.Text = "Пройдено за выходные: ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                runPocessing = new RunProcessing(openFileDialog1.FileName);
                runPocessing.ReadFromFile();
                DisplayRunDay();
                GenerateCharts();
            }
        }

        private void OutputRun_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                StringBuilder builder = new StringBuilder();

                foreach (var item in OutputRunList)
                {
                    builder.Append(item + "\n");
                }
                File.WriteAllText(filename, builder.ToString());
                MessageBox.Show("Файл записан");
            }
        }
    }
}
