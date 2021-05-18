using PolymorphicDeserialization.GodObject;
using System;
using System.IO;
using System.Text.Json;

namespace PolymorphicDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("db.json");

            #region God Object
            var service = new JsonConvertService();
            var result = service.ToList(json);
            #endregion




            #region Custom Converter
            var serializeOptions = new JsonSerializerOptions();
            serializeOptions.Converters.Add(new ProductTypeDiscriminator());


            #endregion

        }
    }
}
