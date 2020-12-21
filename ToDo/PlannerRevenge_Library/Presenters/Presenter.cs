using PlannerRevengeLibrary.Models;
using PlannerRevengeLibrary.ViewInterfaces;

namespace PlannerRevengeLibrary.Presenters
{
    public class Presenter
    {
        private Model model;
        private IView view;

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

        public void LoadANotebook()
        {
            model.LoadData();

            if (model.CurrenNotebook.CountTask > 0)
            {
                model.CurrenIndex = 0;
                var tempTask = model.CurrentTask;

                view.Date = tempTask.Date;
                view.FirstName = tempTask.Name;
                view.Description = tempTask.Description;
            }
        }

        public void Add()
        {
            model.CurrenNotebook.AddRevenge(
                new ATask(view.Date, view.FirstName, view.Description)
                );
        }

        public void Remove()
        {
            ATask t = new ATask(view.Date, view.FirstName, view.Description);
            model.CurrenNotebook.RemoveRevenge(t);

            if (model.CurrenNotebook.CountTask < 1)
            {
                model.CurrenIndex = -1;

                view.Date = string.Empty;
                view.FirstName = string.Empty;
                view.Description = string.Empty;
            }
            else
            {
                model.CurrenIndex--;
                if (model.CurrenIndex < 0) model.CurrenIndex = 0;

                view.Date = model.CurrentTask.Date;
                view.FirstName = model.CurrentTask.Name;
                view.Description = model.CurrentTask.Description;
            }
        }

        public void SaveANotebook()
        {
            model.SaveData();
        }

        public void Next()
        {
            if(model.CurrenNotebook.CountTask > 0)
            {
                if(model.CurrenIndex + 1 < model.CurrenNotebook.CountTask)
                {
                    model.CurrenIndex++;
                    view.Date = model.CurrentTask.Date;
                    view.FirstName = model.CurrentTask.Name;
                    view.Description = model.CurrentTask.Description;
                }
            }
        }

        public void Prev()
        {
            if (model.CurrenNotebook.CountTask > 0)
            {
                if (model.CurrenIndex - 1 > -1)
                {
                    model.CurrenIndex--;
                    view.Date = model.CurrentTask.Date;
                    view.FirstName = model.CurrentTask.Name;
                    view.Description = model.CurrentTask.Description;
                }
            }
        }
    }
}