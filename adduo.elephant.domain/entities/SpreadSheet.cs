using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.entities
{
    public class SpreadSheet
    {
        public Guid Id { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public virtual List<SpreadSheetItem> Items { get; private set; } = new List<SpreadSheetItem>();
        public DateTime CreatedAt { get; private set; }
        
    }
}
