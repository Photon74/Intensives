using PlannerRevengeLibrary.Infrastructure;
using System;
using System.Diagnostics;
using System.IO;

namespace PlannerRevengeLibrary.Models
{
    public class Model
    {
        public Model(string Way = "data.db")
        {
            currenNotebook = new ANotebook();
            currentIndex = 0;
            this.WAY = Way;
        }

        public ATask CurrentTask
        {
            get
            {
                if (CurrenIndex >= 0) { return currenNotebook[currentIndex]; }
                else { return null; }
            }
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(WAY))
                {
                    while (!sr.EndOfStream)
                    {
                        string date = sr.ReadLine();
                        string name = sr.ReadLine();
                        string description = sr.ReadLine();
                        sr.ReadLine();
                        this.currenNotebook.AddRevenge(new ATask(date, name, description));
                    }
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Нет БД");
            }
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter(WAY))
            {
                foreach (ATask e in currenNotebook)
                {
                    sw.WriteLine(e.Date);
                    sw.WriteLine(e.Name);
                    sw.WriteLine(e.Description);
                    sw.WriteLine();
                }
            }
        }

        #region Данные

        public ANotebook CurrenNotebook => this.currenNotebook;

        public int CurrenIndex
        {
            get =>this.currentIndex;
            set => this.currentIndex = value;
        }

        ANotebook currenNotebook;
        private int currentIndex;
        private readonly string WAY;
        #endregion
    }
}
