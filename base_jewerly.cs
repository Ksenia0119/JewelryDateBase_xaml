
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
{
    public class base_jewerly
    {
        public ObservableCollection<Jewerly> jewerlys;


        public base_jewerly()
        {
            jewerlys = new ObservableCollection<Jewerly>();
        }

        public void AddNewJewerlys(string name, string type, string composition, double weight, double price)
        {
            Jewerly new_jew = new Jewerly(name, type, composition, weight, price);
            jewerlys.Add(new_jew);
        }

        public void SaveDB(string name)
        {
            ///Почитать
            using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Unicode))
            {
                foreach (Jewerly s in jewerlys)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// Открыть БД из файла
        public void OpenFile(string name1)
        {
            if (!System.IO.File.Exists(name1))
                throw new Exception("Файл не существует");

            if (jewerlys.Count != 0)
                DeleteDB();

            using (StreamReader sw = new StreamReader(name1))
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

        public void DeleteDB()
        {
          jewerlys.Clear();
        }

    }
}
