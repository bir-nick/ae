using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace advanced_environment
{
    class Тег
    {
        //поля
        private string имя;

        //методы
        public Тег(string имя)
        {
            this.имя = имя;
        }

        public string получитьИмя() 
        {
            return имя;
        }
    }
}
