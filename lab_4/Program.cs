using System;

namespace lab_3_3
{
    class Time
    {
        public int hours;
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int minutes;
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public int seconds;
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void MinInHour(int hours, int minutes, int seconds)
        {
            Console.WriteLine($"Введений час – {hours}:{minutes}:{seconds}"); double rez = (hours * 60) + minutes + (seconds / 60); Console.WriteLine($"Всього хвилин в зазначеному часу - {rez}");
        }
        public void MinutesInHour(int hours, int minutes, int seconds)
        {
            double r = (hours * 60) + minutes + (seconds / 60);
            Console.WriteLine("Хвилин: " + r);
            Console.WriteLine("Після збільшення: " + (r + 30));
        }
    }
    class Timetable : Time
    {
        public string subject { get; set; }
        public int audience { get; set; }

        public Timetable(int hours, int minutes, int seconds) : base(hours, minutes, seconds) { }
        public void Lesson(string time)
        {
            switch (time)
            {
                case "8:30":
                    subject = "ООП";
                    audience = 22;
                    Console.WriteLine($"1 пара - {subject} в {audience} ауд.");
                    break;
                case "10:15":
                    subject = "ООП";
                    audience = 22;
                    Console.WriteLine($"2 пара - {subject} в {audience} ауд.");
                    break;
                default:
                    Console.WriteLine("Пар немає в зазаначений час!");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть годину заняття: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть хвилини: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть секунди: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Timetable t = new Timetable(hours, minutes, seconds);
            string time = hours + ":" + minutes;
            t.Lesson(time);
        }
    }
}


