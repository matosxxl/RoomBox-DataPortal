using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoomBox___DataPortal.Dtos.ArticleFrequency
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
        public string TimePeriod { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }
    }

    public partial class ArticleFrequencyResponse
    {
        public static List<ArticleFrequencyResponse> FromJson(string json) => JsonConvert.DeserializeObject<List<ArticleFrequencyResponse>>(json, RoomBox___DataPortal.Dtos.ArticleFrequency.Converter.Settings);
    }

    public partial class ArticleFrequencyResponse
    {
        public static ArticleFrequencyResponse FromJsonUnique(string json) => JsonConvert.DeserializeObject<ArticleFrequencyResponse>(json, RoomBox___DataPortal.Dtos.ArticleFrequency.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<ArticleFrequencyResponse> self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.ArticleFrequency.Converter.Settings);
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
