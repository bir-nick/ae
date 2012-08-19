﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advanced_environment
{
    class Тестер
    {
        public Тестер()
        {
            Тестировщик.добавитьФункцию(Тест1);
            Тестировщик.добавитьФункцию(Тест2);
            Тестировщик.добавитьФункцию(Тест3);
            Тестировщик.добавитьФункцию(Тест4);
            Тестировщик.добавитьФункцию(Тест5);
            Тестировщик.добавитьФункцию(Тест6);
            Тестировщик.добавитьФункцию(Тест7);
            Тестировщик.добавитьФункцию(Тест8);
            Тестировщик.добавитьФункцию(Тест9);
            Тестировщик.добавитьФункцию(Тест10);
            Тестировщик.добавитьФункцию(Тест11);
            Тестировщик.добавитьФункцию(Тест12);
            Тестировщик.добавитьФункцию(Тест13);
            Тестировщик.добавитьФункцию(Тест14);
            Тестировщик.добавитьФункцию(Тест15);
            обработчикСЯЗ.соеденить();
            Тестировщик.проверить();
        }

        void Тест1()
        {
            Запись запись = new Запись();
            Тестировщик.проверитьИдентичность(запись.получитьТекст(),"");
        }

        void Тест2()
        {
            Запись запись = new Запись("Вася");
            Тестировщик.проверитьИдентичность(запись.получитьТекст(), "Вася");
        }

        void Тест3()
        {
            Запись запись = new Запись();
            запись.задатьТекст("Степан");
            Тестировщик.проверитьИдентичность(запись.получитьТекст(), "Степан");
        }

        void Тест4()
        {
            Тег тег = new Тег("Коровы");
            Тестировщик.проверитьИдентичность(тег.получитьИмя(), "Коровы");
        }

        void Тест5()
        {
            Тег тег = new Тег("Коровы");
            Запись запись = new Запись("коровы являются животными.");
            запись.добавитьТег(тег);
            Тестировщик.проверитьИдентичность(запись.естьЛиТег(тег), true);
        }

        void Тест6()
        {
            Тег тег = new Тег("Коровы");
            Запись запись = new Запись("коровы являются животными.");
            запись.добавитьТег(тег);
            Тестировщик.проверитьИдентичность(запись.естьЛиТег("Коровы"), true);
        }

        void Тест7()
        {
            Тег тег = new Тег("Коровы");
            Запись запись = new Запись("коровы являются животными.");
            Тег нултег = null;
            запись.добавитьТег(нултег);
            запись.добавитьТег(тег);
            Тестировщик.проверитьИдентичность(запись.естьЛиТег("Коровы"), true);
        }    

        void Тест8()
        {
            Тег тег = new Тег("Коровы");
            Запись запись = new Запись("коровы являются животными.");
            запись.добавитьТег("Василёк");
            запись.добавитьТег(тег);
            Тестировщик.проверитьИдентичность(запись.естьЛиТег("Василёк"), true);
        }

        void Тест9()
        {
            Тег тег = new Тег("Коровы");
            Запись запись = new Запись("коровы являются животными.");
            string нултег = null;
            запись.добавитьТег(нултег);
            запись.добавитьТег(тег);
            Тестировщик.проверитьИдентичность(запись.естьЛиТег("Коровы"), true);
        }

        void Тест10()
        {
            Запись запись1 = new Запись("коровы являются животными.");
            Запись запись2 = new Запись("неаааааааа.");
            Записи записи = new Записи();
            записи.добавитьЗапись(запись1);
            записи.добавитьЗапись(запись2);
            Тестировщик.проверитьИдентичность(записи.получитьЗаписи()[1].получитьТекст(), "неаааааааа.");
        }

        void Тест11()
        {
            List<Запись> списокЗаписей = new List<Запись>{
                new Запись("коровы"),
                new Запись("быки")
            };
            Тег тег = new Тег("грибы");
            списокЗаписей[0].добавитьТег(тег);
            Записи записи = new Записи(списокЗаписей);
            записи = записи.записиСТегом(тег);
            if (Тестировщик.идентичныЛи(записи.получитьЗаписи().Count, 1))
                Тестировщик.проверитьИдентичность(записи.получитьЗаписи()[0].получитьТекст(), списокЗаписей[0].получитьТекст());
        }

        void Тест12()
        {
            List<Запись> списокЗаписей = new List<Запись>{
                new Запись("коровы"),
                new Запись("быки")
            };
            списокЗаписей[0].добавитьТеги(new List<Тег>{
                        new Тег("Животное"),
                        new Тег("Молоко")
                    }
                );
            списокЗаписей[1].добавитьТеги(new List<Тег>{
                        new Тег("Животное"),
                        new Тег("Хвостяра")
                    }
                );
            Записи записи = new Записи(списокЗаписей);
            записи = записи.записиСТегом("Животное").записиСТегом("Молоко");
            if (Тестировщик.идентичныЛи(записи.получитьЗаписи().Count, 1))
                Тестировщик.проверитьИдентичность(записи.получитьЗаписи()[0].получитьТекст(), списокЗаписей[0].получитьТекст());
        }

        void Тест13()
        {
            List<Запись> списокЗаписей = new List<Запись>{
                new Запись("коровы"),
                new Запись("быки")
            };
            List<Тег> теги = new List<Тег>{
                        new Тег("Животное"),
                        new Тег("Молоко")            
            };
            списокЗаписей[0].добавитьТеги(теги);
            списокЗаписей[1].добавитьТеги(new List<Тег>{
                        new Тег("Животное"),
                        new Тег("Хвостяра")
                    }
                );
            Записи записи = new Записи(списокЗаписей).записиСТегами(теги);
            if (Тестировщик.идентичныЛи(записи.получитьЗаписи().Count, 1))
                Тестировщик.проверитьИдентичность(записи.получитьЗаписи()[0].получитьТекст(), списокЗаписей[0].получитьТекст());
        }

        void Тест14()
        {
            Запись чучело = new Запись("Фрыва");
            чучело.добавитьТег("Какая-то хрень");
            Записи записи = new Записи(new List<Запись>(){
                    new Запись ("Клисаны"),
                    new Запись ("Люди"),
                    чучело
            });
            записи.добавитьТег("Расы");
            чучело.удалитьТег("Расы");
            if (Тестировщик.идентичныЛи(записи.записиСТегом("Расы").получитьЗаписи().Count, 2))
            {
                Тестировщик.проверитьИдентичность(записи.записиСТегами(new List<string> { "Расы", "Какая-то хрень" }).получитьЗаписи().Count, 0);
            }
        }

        void Тест15()
        {
            Запись чучело = new Запись("Томат");
            чучело.добавитьТег("Помидоры");
            Записи записи = new Записи(new List<Запись>(){
                    new Запись ("Клисаны"),
                    new Запись ("Люди"),
                    чучело
            });
            записи.добавитьТеги(new List<Тег>{
                new Тег("Расы"),
                new Тег("Какая-то хрень")
            });
            чучело.удалитьТеги(new List<string>{
                "Расы",
                "Какая-то хрень"
            });
            if (Тестировщик.идентичныЛи(записи.записиСТегом("Расы").получитьЗаписи().Count, 2))
            {
                if (Тестировщик.идентичныЛи(записи.записиСТегом("Какая-то хрень").получитьЗаписи().Count, 2))
                {
                    if (Тестировщик.идентичныЛи(записи.записиСТегом("Помидоры").получитьЗаписи().Count, 1))
                    {
                        Тестировщик.проверитьИдентичность(записи.записиСТегом("Помидоры").получитьЗаписи()[0].получитьТекст(), "Томат");
                    }
                }
            }
        }
    }
}
