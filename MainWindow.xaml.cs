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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ///поле хранит имя файла для работы 
        public string filename = "";

        ///cсылка на объект класса base_jewerly
        public base_jewerly jew = new base_jewerly();

        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = jew.jewerlys;
        }


     

      
     


        //private void Button_Search_Click(object sender, RoutedEventArgs e)
        //{
        //    FormSearch FS = new FormSearch();
        //    FS.Owner = this;
        //    FS.Show();
        //}

     

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddNewJewelry addform = new AddNewJewelry();
            addform.Owner = this;
            addform.Show();
        }

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

        private void Button_Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.FileName;

                jew.OpenFile(filename);

            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            int ind = datagrid.SelectedIndex;
            jew.jewerlys.RemoveAt(ind);

        }

        private void Button_Delete_All_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(" Вы уверены, что желаете удалить базу данных? Удаление базы данных нельзя отменить.", "Удаление базы данных", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                jew.jewerlys.Clear();
            }


            //jew.jewerlys.Clear();
        }


        int countckick = 0;
        private void Button_Sort_Name_Click(object sender, RoutedEventArgs e)
        {
            countckick++; // увеличиваем счетчик на 1 при каждом нажатии на кнопку

            // проверяем значение счетчика и выполняем соответствующее действие
            if (countckick == 1)
            {
                //создаем обьект класса SortDescription . сортируем по столбцу "Author" по возрастанию
                var sortByName = new SortDescription("Name", ListSortDirection.Ascending);
                //применяем сортировку
                datagrid.Items.SortDescriptions.Add(sortByName);
                //обновляем данные в таблице
                datagrid.Items.Refresh();
            }
            else if (countckick == 2)
            {
                //создаем обьект класса SortDescription . сортируем по столбцу "Author" по возрастанию
                var sortByName = new SortDescription("Name", ListSortDirection.Descending);
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
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Button_Load_Click(sender, e);


        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Button_Save_Click(sender, e);
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Button_Add_Click(sender, e);
        }
        private void DeleteOne_Click(object sender, RoutedEventArgs e)
        {
            Button_Delete_Click(sender,e);
        }
        private void DeleteAllBase_Click(object sender, RoutedEventArgs e)
        {
            Button_Delete_All_Click(sender, e);
        }
    }
}
