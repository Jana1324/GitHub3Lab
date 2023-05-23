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
    }
}
