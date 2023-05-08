using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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



        public Jewerly(string name, string type, string composition, double weight, double price)

        {
            this.name = name;
            this.type = type;
            this.composition = composition;
            this.weight = weight;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Composition
        {
            get { return composition; }
            set { composition = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Price
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
