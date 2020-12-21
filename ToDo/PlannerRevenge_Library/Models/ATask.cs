using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerRevengeLibrary.Models
{
    public class ATask : IEquatable<ATask>
    {
        public bool Equals(ATask other)
        {
            return this.date == other.Date
                && this.name == other.Name
                && this.description == other.Description
                ;
        }
        public ATask(string Date, string Name, string Description)
        {
            this.name = Name; this.date = Date; this.description = Description;
        }

        #region Данные

        public string Name { get { return this.name; } set { this.name = value; } }
        public string Date { get { return this.date; } set { this.date = value; } }
        public string Description { get => this.description; set => this.description = value; }

        private string name;
        private string date;
        private string description;

        #endregion
    }
}
