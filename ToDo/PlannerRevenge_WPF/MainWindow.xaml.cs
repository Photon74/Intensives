
using PlannerRevengeLibrary.Presenters;
using PlannerRevengeLibrary.ViewInterfaces;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlannerRevengeWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        Presenter p;

        public MainWindow()
        {
            InitializeComponent();
            p = new Presenter(this);

            btnNext.Click += delegate { p.Next(); };
            btnRemove.Click += delegate { p.Remove(); };
            btnAdd.Click += delegate { p.Add(); };
            btnPrev.Click += delegate { p.Prev(); };

            this.Closing += delegate { p.SaveANotebook(); };
            this.Loaded += delegate { p.LoadANotebook(); };
        }

        public string Date
        {
            get => txtDate.Text;
            set => txtDate.Text = value;
        }
        public string FirstName
        {
            get => txtTarget.Text;
            set => txtTarget.Text = value;
        }
        public string Description
        {
            get => txtDescription.Text;
            set => txtDescription.Text = value;
        }
    }
}
