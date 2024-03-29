﻿using System.Transactions;
using System;

namespace Budget.Mvc.Models.ViewModels
{
    public class BudgetViewModel
    {
        public List<Transaction>? Transactions { get; set; }
        public InsertTransactionViewModel InsertTransaction { get; set; }

        public CategoriesViewModel Categories { get; set; }

        public InsertCategoryViewModel InsertCategory { get; set; }

        public FilterParametersViewModel FilterParameters { get; set; }
    }
}