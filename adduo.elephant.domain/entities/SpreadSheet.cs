using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class SpreadSheet
    {
        public Guid Id { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public virtual ICollection<SpreadSheetItem> Items { get; private set; } = new List<SpreadSheetItem>();
        public DateTime CreatedAt { get; private set; }

        public SpreadSheet(int year, int month)
        {
            Id = Guid.NewGuid();
            Month = month;
            Year = year;
            CreatedAt = DateTime.Now;
        }

        
    }
}
