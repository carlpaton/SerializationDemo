using System.Collections.Generic;
using System.Text.Json;

namespace PolymorphicDeserialization.GodObject
{
    internal class JsonConvertService
    {
        public List<SmsProduct> ToList(string json) 
        {
            return JsonSerializer.Deserialize<List<SmsProduct>>(json);
        }
    }
}
