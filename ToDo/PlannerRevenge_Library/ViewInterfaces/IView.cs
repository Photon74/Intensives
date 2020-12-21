using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerRevengeLibrary.ViewInterfaces
{
    public interface IView
    {
        string Date { get; set; }
        string FirstName { get; set; }
        string Description { get; set; }
    }
}
