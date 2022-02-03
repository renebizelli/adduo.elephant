using System;
using System.Net;

namespace adduo.elephant.utilities.entries.entry_exceptions
{
    public class EntriesException<T> : Exception
    {
        public T Entry { get; }

        public EntriesException(T entry)
        {
            Entry = entry;
        }
    }
}
