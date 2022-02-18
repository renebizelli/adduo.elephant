using System;

namespace adduo.elephant.utilities.entries
{
    public class GuidEntry : Entry<string>
    {
        public GuidEntry(bool newGuid)
        {
            Value = string.Empty;

            if (newGuid)
            {
                Value = Guid.NewGuid().ToString();
            }
        }

        public GuidEntry()
        {
            Value = string.Empty;
        }

        public Guid GetValue()
        {
            var guid = Guid.Empty;

            Guid.TryParse(Value, out guid);

            return guid;
        }
    }


}
