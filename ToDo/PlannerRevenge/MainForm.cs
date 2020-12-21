using PlannerRevengeLibrary.Presenters;
using PlannerRevengeLibrary.ViewInterfaces;
using System.Windows.Forms;

namespace PlannerRevenge
{
    public partial class MainForm : Form, IView
    {
        #region IView

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

        #endregion

        Presenter p;

        public MainForm()
        {
            InitializeComponent();

            p = new Presenter(this);

            #region _

            btnNext.Click   += (s, e) => p.Next();
            btnPrev.Click += (s, e) => p.Prev();

            btnAdd.Click += (s, e) => p.Add();
            btnRemove.Click += (s, e) => p.Remove();

            this.FormClosing += (s, e) => p.SaveANotebook();
            this.Load += (s, e) => p.LoadANotebook();
            
            #endregion
        }

       
    }
}