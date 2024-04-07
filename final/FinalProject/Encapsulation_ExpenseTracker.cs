using System;
using System.Collections.Generic;

namespace Encapsulation_ExpenseTracker
{
    public class Expenses
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    public class ExpensesTracker
    {
        private List<Expense> expenses;

        public ExpensesTracker()
        {
            expenses = new List<Expense>();
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public void DisplayExpenses()
        {
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Date: {expense.Date}, Description: {expense.Description}, Amount: {expense.Amount}");
            }
        }
    }
}
