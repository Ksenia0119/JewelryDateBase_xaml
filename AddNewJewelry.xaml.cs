
﻿///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.

using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace JewelryDateBase
{
    /// <summary>
    /// Логика взаимодействия для AddNewJewelry.xaml
    /// </summary>
    public partial class AddNewJewelry : Window
    {

        public AddNewJewelry()
        {
            InitializeComponent();
            // Установка  фокуса  в true для кнопки Button_AddNew 
            Button_AddNew.Focusable = true;
            // Добавление обработчика нажатия
            PreviewKeyDown += AddNewJewelry_PreviewKeyDown;
        }

        private void AddNewJewelry_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Вызов обработчика  при нажатии клавиши Enter.
                Button_AddNew_Click(null, null);
            }
        }

        private void Button_AddNew_Click(object sender, RoutedEventArgs e)
        {

            //SolidColorBrush error_color = new SolidColorBrush();
            //SolidColorBrush usual_color = new SolidColorBrush();

            /////цвет ошибочных полей 
            //error_color.Color = Color.FromRgb(252, 187, 187);
            ///////цвет полей обычный
            //usual_color.Color = Colors.White;



            ////Объект mainForm  ссылается на главную форму
            //MainWindow mainForm = this.Owner as MainWindow;
            //base_jewerly Jw = new base_jewerly();

            //string name = TextBox_name.Text;
            //string type = TextBox_type.Text;
            //string composition = TextBox_composition.Text;
            //double weight; //= double.Parse(TextBox_weight.Text);
            //double price;//= double.Parse(TextBox_price.Text);
            ////для определения налиячия ошибки
            //bool hasError = false;

            //if (string.IsNullOrWhiteSpace(name))
            //{
            //    TextBox_name.Background = error_color;
            //    hasError = true;
            //}
            //else
            //{
            //    TextBox_name.Background = usual_color;
            //}

            //if (string.IsNullOrWhiteSpace(type))
            //{
            //    TextBox_type.Background = error_color;
            //    hasError = true;
            //}
            //else
            //{
            //    TextBox_type.Background = usual_color;
            //}

            //if (string.IsNullOrWhiteSpace(composition))
            //{
            //    TextBox_composition.Background = error_color;
            //    hasError = true;
            //}
            //else
            //{
            //    TextBox_composition.Background = usual_color;
            //}

            //if (!double.TryParse(TextBox_weight.Text, out weight))
            //{
            //    TextBox_weight.Background = error_color;
            //    hasError = true;
            //}
            //else
            //{
            //    TextBox_weight.Background = usual_color;
            //}

            //if (!double.TryParse(TextBox_price.Text, out price))
            //{
            //    TextBox_price.Background = error_color;
            //    hasError = true;
            //}
            //else
            //{
            //    TextBox_price.Background = usual_color;
            //}

            //if (hasError)
            //{
            //   TextBlock_erorr.Text = "Заполните все поля";
            //}
            //else
            //{
            //    //Если ошибок не найдено, все введенные поля очищаются
            //    TextBox_name.Clear();
            //    TextBox_type.Clear();
            //    TextBox_composition.Clear();
            //    TextBox_weight.Text = "";
            //    TextBox_price.Text = "";

            //    ///изделие добавляется в список и на главную форму
            //    mainForm.jew.AddNewJewerlys(name, type, composition, weight, price);
            //    var n = mainForm.jew.jewerlys.Count;
            //}
            //Объект mainForm  ссылается на главную форму
            MainWindow mainForm = this.Owner as MainWindow;
            base_jewerly Jw = new base_jewerly();

            if (check_input())
            {
                string name = TextBox_name.Text;
                string type = TextBox_type.Text;
                string composition = TextBox_composition.Text;
                double weight = double.Parse(TextBox_weight.Text);
                double price = double.Parse(TextBox_price.Text);

                //Если ошибок не найдено, все введенные поля очищаются
                TextBox_name.Clear();
                TextBox_type.Clear();
                TextBox_composition.Clear();
                TextBox_weight.Text = "";
                TextBox_price.Text = "";

                ///изделие добавляется в список и на главную форму
                mainForm.jew.AddNewJewerlys(name, type, composition, weight, price);
                var n = mainForm.jew.jewerlys.Count;
            }

        }

        private bool check_input()
        {
            SolidColorBrush error_color = new SolidColorBrush();
            SolidColorBrush usual_color = new SolidColorBrush();

            ///цвет ошибочных полей 
            error_color.Color = Color.FromRgb(252, 187, 187);
            /////цвет полей обычный
            usual_color.Color = Colors.White;

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(TextBox_name.Text))
            {
                TextBox_name.Background = error_color;
                hasError = true;
            }
            else
            {
                TextBox_name.Background = usual_color;
            }

            if (string.IsNullOrWhiteSpace(TextBox_type.Text))
            {
                TextBox_type.Background = error_color;
                hasError = true;
            }
            else
            {
                TextBox_type.Background = usual_color;
            }

            if (string.IsNullOrWhiteSpace(TextBox_composition.Text))
            {
                TextBox_composition.Background = error_color;
                hasError = true;
            }
            else
            {
                TextBox_composition.Background = usual_color;
            }

            double weight;
            if (!double.TryParse(TextBox_weight.Text, out weight))
            {
                TextBox_weight.Background = error_color;
                hasError = true;
            }
            else
            {
                TextBox_weight.Background = usual_color;
            }

            double price;
            if (!double.TryParse(TextBox_price.Text, out price))
            {
                TextBox_price.Background = error_color;
                hasError = true;
            }
            else
            {
                TextBox_price.Background = usual_color;
            }

            if (hasError)
            {
                TextBlock_erorr.Text = "Заполните все поля";
            }

            return !hasError;
     

    }

    private void Button_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

      


    }
}
