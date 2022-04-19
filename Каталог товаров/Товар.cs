using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Каталог_товаров
{
  public class Товар
    {
        string name;
        string made_in;
        double price;

        // свойства
        public string Name
        {
            //возвращаем нэйм
            get { return name; }
            //для нашего свойства устанавливаем значение
            set { name = value; }
        }
        public string Made_in
        {
            get { return made_in; }
            set { made_in = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0) throw new Exception("Цена товара должна быть>0");
                else price = value;
            } 
        }
        //переопределяем конструктор
        // конструктор по умолчанию
        //поля зададим базовые, передаем пустой null
        public Товар()
        {
            Name = "unknown";
            Made_in = "unknown";
            Price = 0;
        }

        public Товар(string _name, string _made_in, double _price)
            {//передаем
            Name=_name;
            Made_in = _made_in;
            Price = _price;

             }
        public override string ToString()
        {
            //возвращает строку
            //передадим name
            return Name + "Изготовитель"+ Made_in+"Цена:"+Price;
        }
    }
}
