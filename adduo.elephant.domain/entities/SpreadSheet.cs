using System;

namespace adduo.elephant.domain.entities
{
    public class SpreadSheet
    {
        public Guid Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }

        public SpreadSheet(int month, int year)
        {
            Month = month;
            Year = year;
        }

    }
}
