using System;

namespace adduo.elephant.domain.dtos.debts.bundler_items
{
    public class RecurrentValueBundler
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
