using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace advanced_environment
{
    static class обработчикСЯЗ
    {
        private static string строкаСоединения = "";
        private static string ИП = "192.168.96.194";
        private static string ПОРТ = "3306";
        private static string ИМЯПОЛЬЗОВАТЕЛЯ = "root";
        private static string ПАРОЛЬ = "root";
        private static string БАЗАДАННЫХ = "ae_db";

        public static void соеденить()
        {
            строкаСоединения = "Database=" + БАЗАДАННЫХ + ";Datasource=" + ИП + ";User=" + ИМЯПОЛЬЗОВАТЕЛЯ + 
                ";Password=" + ПАРОЛЬ;
            MySqlConnection соединение = new MySqlConnection(строкаСоединения);
            try
            {
                соединение.Open();
                соединение.Close();
                System.Console.WriteLine("превед медвед!");
            }
            catch (Exception ошибка)
            {
                System.Console.WriteLine("ошибка: " + ошибка.ToString());
            }
        }
    }
}
