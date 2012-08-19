using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace advanced_environment
{
    class Запись
    {
        //поля
        private string текст = "";
        private List<Тег> теги = new List<Тег>();

        //методы
        public Запись() { }

        public Запись(string текст)
        {
            if (текст == null) return;
            this.текст = текст;
        }

        public string получитьТекст()
        {
            return текст;
        }

        public void задатьТекст(string текст)
        {
            this.текст = текст;
        }

        public void добавитьТег(Тег тег)
        {
            if (тег == null) return;
            this.теги.Add(тег);
        }

        public void добавитьТег(string тег)
        {
            if (тег == null) return;
            добавитьТег(new Тег(тег));
        }

        public bool естьЛиТег(Тег тег)
        {
            if (тег == null) return false;
            foreach (Тег текущийТег in this.теги)
            {
                if (текущийТег.получитьИмя().Equals(тег.получитьИмя()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool естьЛиТег(string тег)
        {
            if (тег == null) return false;
            foreach (Тег текущийТег in this.теги)
            {
                if (текущийТег.получитьИмя().Equals(тег))
                {
                    return true;
                }
            }
            return false;
        }

        public void добавитьТеги(List<Тег> списокТегов)
        {
            if (списокТегов == null) return;
            foreach (Тег тег in списокТегов)
            {
                this.добавитьТег(тег);
            }
        }

        public void удалитьТег(string тег)
        {
            if (тег == null) return;
            foreach (Тег тегИзСписка in this.теги)
            {
                if (тегИзСписка.получитьИмя().CompareTo(тег) == 0)
                {
                    this.теги.Remove(тегИзСписка);
                    return;
                }
            }
        }

        public void удалитьТег(Тег тег)
        {
            if (тег == null) return;
            foreach (Тег тегИзСписка in this.теги)
            {
                if (тегИзСписка.получитьИмя().CompareTo(тег.получитьИмя()) == 0)
                {
                    this.теги.Remove(тегИзСписка);
                    return;
                }
            }
        }

        public void удалитьТеги(List<string> теги)
        {
            if (теги == null) return;
            foreach (string тег in теги)
            {
                this.удалитьТег(тег);
            }
        }

        public void удалитьТег(List<Тег> теги)
        {
            if (теги == null) return;
            foreach (Тег тег in теги)
            {
                this.удалитьТег(тег);
            }
        }
    }
}
