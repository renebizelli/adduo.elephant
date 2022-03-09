using System;
using System.Collections.Generic;

namespace adduo.elephant.domain.dtos
{
    public class SpreadSheet
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<SpreadSheetItem> Items { get; set; } = new List<SpreadSheetItem>();
    }
}
