
///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace JewelryDateBase
{ //классс для работы с бд
    public class base_jewerly
    {
        // коллекция jewerlys объектов типа Jewerly
        public ObservableCollection<Jewerly> jewerlys;

       // конструктор
        public base_jewerly()
        {
            jewerlys = new ObservableCollection<Jewerly>();
        }
        //добавления нового объекта  в коллекцию jewerlys
        public void AddNewJewerlys(string name, string type, string composition, double weight, double price)
        {
            Jewerly new_jew = new Jewerly(name, type, composition, weight, price);
            jewerlys.Add(new_jew);
        }
        //сохранить бд
        public void SaveDB(string name)
        {
            
            using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Unicode))
            {
                foreach (Jewerly s in jewerlys)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// Открыть БД из файла
        public void OpenFile(string name_file)
        {
            if (!System.IO.File.Exists(name_file))
                throw new Exception("Файл не существует");

            if (jewerlys.Count != 0)
                DeleteDB();

            using (StreamReader sw = new StreamReader(name_file))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);

                    string name = dataFromFile[0];
                    string type = dataFromFile[1];
                    string composition = dataFromFile[2];
                    double weight = double.Parse(dataFromFile[3]);
                    double price = double.Parse(dataFromFile[4]);
                    AddNewJewerlys (name, type, composition, weight, price);
                }
            }
        }
        //удалить бд
        public void DeleteDB()
        {
          jewerlys.Clear();
        }

    }
}
