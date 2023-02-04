using System;
using System.Text.RegularExpressions;

namespace CruisingFlightStand
{
    // Команды
    public static class Commands
    {
        // Разделитель данных
        public const char SPLITTER = '|';

        // Команды от
        // АЦП с тензодатчика
        public struct HX711
        {
            public const string tenzo1 = "[HX 711 tenzo1]";  // Давление на тензодатчике 1
            public const string tenzo2 = "[HX 711 tenzo2]";  // Давление на тензодатчике 2
            public const string tenzo3 = "[HX 711 tenzo3]";  // Давление на тензодатчике 3
            public const string tenzo4 = "[HX 711 tenzo4]";  // Давление на тензодатчике 4
            public const string tenzo5 = "[HX 711 tenzo5]";  // Давление на тензодатчике 5
        }

        public struct Pito
        {
            public const string pito = "[Pito]";  // Давление в трубке Пито
            public const string pito_raw = "[Pito Raw]";  // Давление в трубке Пито
        }

        public struct Sensors
        {
            public const string volt    = "[Voltmeter]";  // Падение напряжения
            public const string current = "[Ampermeter]"; // Потребление тока
        }

        // Команды для Ардуино
        public struct Arduino
        {
            public const string shutdown = "[Reset]";             // Спящий режим
            public const string testConnection = "[Test connection]";   // Проверка соединения
        }

        // Полученные команды
        public struct Response
        {
            public const string goodConnection = "[Connection succeded]";   // Успешное подключение
        }

        // Метод для удаления специальных символов
        public static string DeleteSpecSymb(string str)
        {
            return Regex.Replace(str, @"[\u0000-\u001F]", string.Empty);
        }

        // Метод для переноса в новый диапазон значений
        public static int Map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        public static string ProcessValue(string val, double koef)
        {
            return Convert.ToString((double.Parse(val, System.Globalization.CultureInfo.InvariantCulture) * koef));
        }

        public static string ProcessTenzoValue(string val, double koef)
        {
            return Convert.ToString((int)(double.Parse(val, System.Globalization.CultureInfo.InvariantCulture) * koef));
        }
    }
}