using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub3Lab
{
    public class TempDate
    {
        public DateTime Date { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double AvgTemperature { get; set; }
    }
    // чтение данных из файла и их обработка
    public class TempProcessing
    {
        private List<TempDate> tempDayList;
        private string filePath;

        public TempProcessing(string filePath)
        {
            this.filePath = filePath;
            tempDayList = new List<TempDate>();
        }

        // метод для чтения данных из файла
        public void ReadFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var item in lines)
                {
                    string[] values = item.Split(' ');

                    TempDate tempData = new TempDate
                    {
                        Date = DateTime.Parse(values[0]),
                        MaxTemperature = double.Parse(values[1]),
                        MinTemperature = double.Parse(values[2]),
                        AvgTemperature = double.Parse(values[3])
                    };

                    tempDayList.Add(tempData);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при чтении. Проверьте данные на корректность.");

            }
        }
        public string FindLargestTemperatureChange()
        {
            double largestChange = 0;
            TempDate largestChangeData = null;

            for (int i = 0; i < tempDayList.Count - 1; i++)
            {
                double temperatureChange = Math.Abs(tempDayList[i].MaxTemperature - tempDayList[i].MinTemperature);

                if (temperatureChange > largestChange)
                {
                    largestChange = temperatureChange;
                    largestChangeData = tempDayList[i];
                }
            }

            string str = string.Format("Самый сильный перепад температуры был : {0} - {1} градусов", largestChangeData.Date.ToString("d"), largestChange);
            return str;
        }

        // метод для получения списка всех дней 
        public List<TempDate> GetTempDayList()
        {
            return tempDayList;
        }
    }
}
