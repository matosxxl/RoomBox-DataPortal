using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoomBox___DataPortal.Dtos.ArticleFrequencyResponse
{

    public partial class ArticleFrequencyResponse
    {
        [JsonProperty("article_id")]
        public long ArticleId { get; set; }

        [JsonProperty("article_name")]
        public string ArticleName { get; set; }

        [JsonProperty("article_type")]
        public string ArticleType { get; set; }

        [JsonProperty("order_count")]
        public long OrderCount { get; set; }

        [JsonProperty("total_quantity_ordered")]
        public long TotalQuantityOrdered { get; set; }

        [JsonProperty("time_period")]
        public TimePeriod TimePeriod { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }
    }

    public enum TimePeriod { The30Days };

    public partial class ArticleFrequencyResponse
    {
        public static List<ArticleFrequencyResponse> FromJson(string json) => JsonConvert.DeserializeObject<List<ArticleFrequencyResponse>>(json, RoomBox___DataPortal.Dtos.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<ArticleFrequencyResponse> self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TimePeriodConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TimePeriodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TimePeriod) || t == typeof(TimePeriod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "30 days")
            {
                return TimePeriod.The30Days;
            }
            throw new Exception("Cannot unmarshal type TimePeriod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TimePeriod)untypedValue;
            if (value == TimePeriod.The30Days)
            {
                serializer.Serialize(writer, "30 days");
                return;
            }
            throw new Exception("Cannot marshal type TimePeriod");
        }

        public static readonly TimePeriodConverter Singleton = new TimePeriodConverter();
    }
}
