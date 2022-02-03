using System.Text.Json;

namespace adduo.elephant.utilities
{
    public class SerializerUtilities
    {
        public static string Serialize(object data)
        {
            return JsonSerializer.Serialize(data);
        }
    }
}
