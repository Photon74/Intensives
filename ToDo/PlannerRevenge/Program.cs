using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerRevenge
{
    static class Program
    {
        // https://habr.com/post/215605/
        // MVP - https://habrastorage.org/getpro/habr/post_images/f1b/cbf/d44/f1bcbfd44fc367c0e07e00d957ac188a.png
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
