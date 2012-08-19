using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advanced_environment
{
    class Записи
    {
        private List<Запись> записи = new List<Запись>();

        public Записи()
        {

        }

        public Записи(List<Запись> записи)
        {
            if (записи == null) return;
            foreach (Запись запись in записи)
            {
                this.добавитьЗапись(запись);
            }
        }

        public void добавитьЗапись(Запись запись)
        {
            if (запись == null) return;
            записи.Add(запись);
        }

        public List<Запись> получитьЗаписи()
        {
            return записи;
        }

        public Записи записиСТегом(Тег тег)
        {
            Записи результат = new Записи();
            foreach (Запись запись in this.получитьЗаписи())
            {
                if (запись.естьЛиТег(тег))
                    результат.добавитьЗапись(запись);
            }
            return результат;
        }

        public Записи записиСТегом(string тег)
        {
            Записи результат = new Записи();
            foreach (Запись запись in this.получитьЗаписи())
            {
                if (запись.естьЛиТег(тег))
                    результат.добавитьЗапись(запись);
            }
            return результат;
        }

        public Записи записиСТегами(List<Тег> теги)
        {
            Записи результат = this;
            foreach (Тег тег in теги)
            {
                результат = результат.записиСТегом(тег);
            }
            return результат;
        }

        public Записи записиСТегами(List<string> теги)
        {
            Записи результат = this;
            foreach (string тег in теги)
            {
                результат = результат.записиСТегом(тег);
            }
            return результат;
        }

        public void добавитьТег(string тег)
        {
            foreach (Запись запись in this.получитьЗаписи())
            {
                запись.добавитьТег(тег);
            }
        }

        public void добавитьТег(Тег тег)
        {
            foreach (Запись запись in this.получитьЗаписи())
            {
                запись.добавитьТег(тег);
            }
        }

        public void добавитьТеги(List<string> теги)
        {
            if (теги == null) return;
            foreach (string тег in теги)
            {
                this.добавитьТег(тег);
            }
        }

        public void добавитьТеги(List<Тег> теги)
        {
            if (теги == null) return;
            foreach (Тег тег in теги)
            {
                this.добавитьТег(тег);
            }
        }
    }
}
