using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

    }
}
