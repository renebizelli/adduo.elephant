using adduo.elephant.utilities.hash;
using System.Text.Json.Serialization;

namespace adduo.elephant.utilities.entries
{
    public class PasswordEntry : StringEntry
    {
        [JsonIgnore()]
        public string Hash
        {
            get
            {
                return HashHelper.HashSHA512(this.Value);
            }
        }

        public PasswordEntry()  
        {

        }

        public void Clear()
        {
            this.Value = string.Empty;
        }
    }


}
