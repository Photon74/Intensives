using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StartWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public struct My_size  
    {
        public int wind;

        public int heig;

          
    }

    public partial class MainWindow : Window
    {
        ObservableCollection<int> arr = new ObservableCollection<int>();
       

        void Reload()
        {
            listView.ItemsSource = null;
            listView.ItemsSource = arr;
            //listView.Items.Clear();

            //foreach (var item in arr)
            //{
            //    listView.Items.Add(item);
            //}
        }

        public MainWindow()
        {
            InitializeComponent();

            listView.ItemsSource = arr;

            for (int i = 0; i < 6; i++)
            {
                arr.Add(0);
            }

            Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Window window = new Window();
            //window.Show();
            //Button btn = new Button();
        }


        Random r = new Random();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arr[r.Next(6)]+=10;
        }

        ObservableCollection<int> arrSort = new ObservableCollection<int>();

        void Start()
        {
            sortView.ItemsSource = arrSort;

            for (int i = 0; i < 20; i++)
            {
                arrSort.Add(r.Next(100,300));
            }
        }
        
        async void Sort()
        {
            for (int i = 0; i < arrSort.Count; i++)
            {
                for (int j = 0; j < arrSort.Count; j++)
                {
                    if (arrSort[i] > arrSort[j])
                    {
                        int t = arrSort[i];
                        arrSort[i] = arrSort[j];
                        arrSort[j] = t;
                        await Task.Delay(150);
                    }
                }
            }
        }

      

        private void btnSort(object sender, RoutedEventArgs e)
        {
            Sort();
        }
    }
}
