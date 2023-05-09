///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JewelryDateBase
{
   
    /// Логика взаимодействия для MainWindow.xaml

    public partial class MainWindow : Window
    {
        ///поле хранит имя файла для работы 
        public string filename = "";

        ///cсылка на объект класса base_jewerly
        public base_jewerly jew = new base_jewerly();

       // Конструктор класса MainWindow
        public MainWindow()
        {   // инициализация компонентов окна
            InitializeComponent();
            // источник данных для таблицы
            datagrid.ItemsSource = jew.jewerlys;
        }

        //обработчик кнопки добавить-создание второго окна,передача управления
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddNewJewelry addform = new AddNewJewelry();
            addform.Owner = this;
            addform.Show();
        }
          //сохранение бд в фаил
        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (filename == "")
            {
                if (saveFileDialog.ShowDialog() == DialogResult) return;
                filename = saveFileDialog.FileName;

            }
            jew.SaveDB(filename);
        }
        //загрузка бд из файла
        private void Button_Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.FileName;

                jew.OpenFile(filename);

            }
        }
        //удаление одного экземпляра из бд
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(" Вы уверены, что желаете удалить изделие?", "Удаление изделия из базы данных", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                int ind = datagrid.SelectedIndex;
                jew.jewerlys.RemoveAt(ind);
            }
        }
         //удаление всей бд
        private void Button_Delete_All_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(" Вы уверены, что желаете удалить базу данных? Удаление базы данных нельзя отменить.", "Удаление базы данных", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                jew.jewerlys.Clear();
            }
        }

        //  счетчик кликов на кнопку
        int countckick = 0;
         //сортировка по названию изделия
        private void Button_Sort_Name_Click(object sender, RoutedEventArgs e)
        {
            countckick++; 

            if (countckick == 1)
            {
                //создаем обьект класса SortDescription . сортируем по столбцу  по возрастанию
                var sortByName = new SortDescription("Название", ListSortDirection.Ascending);
                //применяем сортировку
                datagrid.Items.SortDescriptions.Add(sortByName);
                //обновляем данные в таблице
                datagrid.Items.Refresh();
            }
            else if (countckick == 2)
            {
                //создаем обьект класса SortDescription . сортируем по столбцу по убыванию
                var sortByName = new SortDescription("Название", ListSortDirection.Descending);
                //удаление сущ.фильтрации
                datagrid.Items.SortDescriptions.Clear();
                //применяем сортировку
                datagrid.Items.SortDescriptions.Add(sortByName);
                //обновляем данные в таблице
                datagrid.Items.Refresh();
            }
            else
            {

                countckick = 0;
                datagrid.Items.SortDescriptions.Clear();
            }
        }
        //меню-открыть бд
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Button_Load_Click(sender, e);


        }
       // меню-сохранить бд
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Button_Save_Click(sender, e);
        }
       // меню-добавить изделие
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Button_Add_Click(sender, e);
        }
        //меню-удалить экземляр в бд
        private void DeleteOne_Click(object sender, RoutedEventArgs e)
        {
            Button_Delete_Click(sender,e);
        }
        //меню-удалить бд
        private void DeleteAllBase_Click(object sender, RoutedEventArgs e)
        {
            Button_Delete_All_Click(sender, e);
        }
       // меню-автор
        private void Author_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("@author Maltseva K.V.");
        }
    }
}
