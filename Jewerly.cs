
using System;
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


        //Конструкторы класса
        public Jewerly(string name, string type, string composition, double weight, double price)

        {
            this.name = name;
            this.type = type;
            this.composition = composition;
            this.weight = weight;
            this.price = price;
        }

        public Jewerly()
        {
            name = "";
            type = "";
            composition = "";
            weight = 0;
            price = 0;
        }

        //задать и получить Название
        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название не может быть пустым");
                }
                name = value;
            }
        }

        
        //задать и получить Тип
        public string Type
        {
            get { return type; }
            set {
                
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Тип не может быть пустым");
                    }
                 type = value;
                }
            
        }

        //задать и получить Состав
        public string Composition
        {
            get { return composition; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Состав не может быть пустым");
                }
                composition = value;
            }
        }
        //задать и получить Вес
        public double Weight
        {
            get { return weight; }
            set
            {
               
               if (value <= 0)
                 {
                   throw new ArgumentException("Вес не может быть нулевым или отрицательным");
                 }
               weight = value;
             }
         }
        //задать и получить Цена
        public double Price
        {
            get { return price; }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Цена не может быть нулевой или отрицательной");
                }
                price = value;
            }
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
