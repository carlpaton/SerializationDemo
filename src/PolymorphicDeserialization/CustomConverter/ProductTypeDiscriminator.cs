using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PolymorphicDeserialization.CustomConverter
{
    public class ProductTypeDiscriminator : JsonConverter<BaseSmsProduct>
    {
        public override BaseSmsProduct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, BaseSmsProduct value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
