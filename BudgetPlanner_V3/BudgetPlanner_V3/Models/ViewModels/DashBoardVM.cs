using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPlanner_V3.Models
{
    public class DashBoardVM
    {
        public string Name { get; set; }
        public List<HouseholdAccount> Accounts { get; set; }
        public List<BudgetItem> BudgetItems { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}