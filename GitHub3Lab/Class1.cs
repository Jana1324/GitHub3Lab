using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub3Lab
{
    // содержит данные о пробежке за каждый день
    public class RunDay
    {
        public int Duration { get; set; } // Длительность бега в минутах
        public double Distance { get; set; } // Пройденное расстояние в км
        public double MaxSpeed { get; set; } // Максимальная скорость
        public double MinSpeed { get; set; } // Минимальная скорость
        public double AvgSpeed { get; set; } // Средняя скорость
        public double AvgPulse { get; set; } // Средний пульс
        public int DayOfWeek { get; set; } // День недели     
    }

    // чтение данных из файла и их обработка
    public class RunProcessing
    {
        private List<RunDay> runDayList;
        private string filePath;

        public RunProcessing(string filePath)
        {
            this.filePath = filePath;
            runDayList = new List<RunDay>();
        }

        public RunProcessing()
        {
        }

        // Метод для чтения данных из файла
        public void ReadFromFile()
        {
            int dayOfWeek = 1;
            try
            {
                // чтения всех строк из текстового файла 
                string[] lines = File.ReadAllLines(filePath); // каждый элемент массива представляет отдельную строку из файла

                foreach (string line in lines)
                {
                    // каждый элемент массива будет содержать одно из значений
                    string[] values = line.Split(' ');


                    RunDay runDate = new RunDay
                    {
                        Duration = int.Parse(values[0]),
                        Distance = double.Parse(values[1]),
                        MaxSpeed = double.Parse(values[2]),
                        MinSpeed = double.Parse(values[3]),
                        AvgSpeed = double.Parse(values[4]),
                        AvgPulse = double.Parse(values[5]),
                        DayOfWeek = dayOfWeek
                    };

                    runDayList.Add(runDate);
                    ++dayOfWeek;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при чтении. Проверьте данные на корректность.");
            }
        }

    }
}
