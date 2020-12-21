using PlannerRevengeLibrary.Models;
using System.Collections;
using System.Collections.Generic;


namespace PlannerRevengeLibrary.Infrastructure
{
    public class ANotebook : IEnumerable
    {
        public ANotebook()
        {
            notebook = new List<ATask>();
        }

        #region Логика

        public bool AddRevenge(ATask NewTask)
        {
            bool flag = false;
            if (!notebook.Contains(NewTask))
            {
                notebook.Add(NewTask);
                flag = true;
            }
            return flag;
        }

        public bool RemoveRevenge(ATask RemoveTask)
        {

            bool flag = false;
            if (notebook.IndexOf(RemoveTask) != -1)
            {
                notebook.Remove(RemoveTask);
                flag = true;
            }
            return flag;
        }

        public int CountTask => notebook.Count;

        public ATask this[int index]
        {
            get => !IsNullOrEmpty() ? notebook[index] : null;
        }

        private bool IsNullOrEmpty()
        {
            bool flag = true;

            if (notebook != null)
            {
                if (notebook.Count > 0)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (ATask e in notebook)
            {
                yield return (ATask)e;
            }
        }

        #endregion


        #region Данные

        public List<ATask> Notebook
        {
            get => this.notebook;
            set => this.notebook = value;
        }

        private List<ATask> notebook;

        #endregion
    }
}
