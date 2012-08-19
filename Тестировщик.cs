using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advanced_environment
{
    public static class Тестировщик
    {
        public delegate void ТФункция();
        static List<ТФункция> функции = new List<ТФункция>();

        private static int сч = -1;

        public static string получитьИмяФункции(ТФункция функция)
        {
            string имя = функция.Method.ToString();
            имя = имя.Substring(имя.IndexOf(" ") + 1);
            имя = имя.Substring(0, имя.IndexOf("("));
            return имя;
        }

        public static void проверитьИдентичность(dynamic ИКС, dynamic ИГРЕК)
        {
            System.Console.WriteLine(
                Equals(ИКС, ИГРЕК) ? ("ТЕСТ " + ((сч == -1) ? "" : получитьИмяФункции(функции[сч])) + " ПРОЙДЕН") : "ОШИБКА: " + ИКС + ", " + ИГРЕК
                );
        }

        public static bool идентичныЛи(dynamic ИКС, dynamic ИГРЕК)
        {
            if (!Equals(ИКС, ИГРЕК))
            {
                System.Console.WriteLine("ОШИБКА: " + ИКС + ", " + ИГРЕК);
                return false;
            }            
            return true;
        }

        public static void добавитьФункцию(ТФункция ф)
        {
            функции.Add(ф);
        }

        public static void проверить()
        {
            сч = 0;            
            foreach (ТФункция функция in функции)
            {
                функция();
                ++сч;
            }
            сч = -1;
        }
    }
}
