using System.Text.Json.Serialization;

namespace adduo.elephant.utilities.entries
{
    public abstract class Format : StringEntry
    {
        public Format()
        {

        }

        [JsonPropertyName("formatter")]
        public string Formatted { get { return ToFormat(); } }

        public virtual string ToFormat()
        {
            return Value;
        }
    }


}
