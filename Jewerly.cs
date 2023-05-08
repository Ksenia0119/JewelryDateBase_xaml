///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.

namespace JewelryDateBase
{
    ///Класс Ювелирное изделие
    public class Jewerly
    {
        private
        string name;        ///Название
        string type;        ///Тип изделия
        string composition; ///Состав
        double weight;      ///Вес
        double price;       ///Цена


        //Конструктор класса
        public Jewerly(string name, string type, string composition, double weight, double price)

        {
            this.name = name;
            this.type = type;
            this.composition = composition;
            this.weight = weight;
            this.price = price;
        }

        //задать и получить Название
        public string Название
        {
            get { return name; }
            set { name = value; }
        }
        //задать и получить Тип
        public string Тип
        {
            get { return type; }
            set { type = value; }
        }
        //задать и получить Состав
        public string Состав
        {
            get { return composition; }
            set { composition = value; }
        }
        //задать и получить Вес
        public double Вес
        {
            get { return weight; }
            set { weight = value; }
        }
        //задать и получить Цена
        public double Цена
        {
            get { return price; }
            set { price = value; }
        }


        /////Вернуть название
        //public string GetName()
        //{
        //    return name;
        //}
        /////Задать имя
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        /////Вернуть тип
        //public string GetTypes()
        //{
        //    return type;
        //}

        /////Задать тип
        //public void SetType(string type)
        //{
        //    this.type = type;
        //}
        /////Вернуть состав
        //public string GetComposition()
        //{
        //    return composition;
        //}
        /////Задать состав
        //public void SetComposition(string composition)
        //{
        //    this.composition = composition;
        //}
        /////Вернуть вес
        //public double GetWeight()
        //{
        //    return weight;
        //}
        /////Задать вес
        //public void SetWeight(double weight)
        //{
        //    this.weight = weight;
        //}
        /////Вернуть цену
        //public double GetPrice()
        //{
        //    return price;
        //}
        /////Задать цену
        //public void SetPrice(double price)
        //{
        //    this.price = price;
        //}

        ///переопределение метода ToString
        public override string ToString()
        {
            return name + "|" + type + "|" + composition + "|" +
                weight + "|" + price;
        }
    }
}
