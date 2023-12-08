// Expense.cs
namespace Coinpanion.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; } 
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
