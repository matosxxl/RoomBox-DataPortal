using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoomBox___DataPortal.Dtos.MonthlySales
{
    public partial class MonthlySales
    {
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }
    }

    public partial class MonthlySales
    {
        public static List<MonthlySales> FromJson(string json) => JsonConvert.DeserializeObject<List<MonthlySales>>(json, RoomBox___DataPortal.Dtos.MonthlySales.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<MonthlySales> self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.MonthlySales.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
