﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace BudgetPlanner_V3.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public System.DateTimeOffset Created { get; set; }
        public Nullable<System.DateTimeOffset> Updated { get; set; }
        public bool IsDebit { get; set; }
        public bool IsArchived { get; set; }
        public bool IsReconciled { get; set; }

        public int HouseholdAccountId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        [JsonIgnore]
        public virtual HouseholdAccount HouseholdAccount { get; set; }
    }
}