using System.Collections.Generic;

namespace adduo.elephant.utilities.entries
{
    public class ListEntry<T> : Entry<List<T>>
    {
        public ListEntry()
        {
            Value = new List<T>();
            DefaultValue = new List<T>();
        }
    }
}
