using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adduo.elephant.console.repositories
{
    public class SheetRepository : Db
    {
        public bool ItWasCreated(int month, int year)
        {
            return Sheets.Any(a => a.Month == month && a.Year == year);
        }

        public Sheet Get(int month, int year)
        {
            return Sheets.FirstOrDefault(a => a.Month == month && a.Year == year);
        }
    }
}
