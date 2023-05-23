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

    }
}
