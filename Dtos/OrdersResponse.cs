using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoomBox___DataPortal.Dtos.Orders
{

    public partial class OrdersResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Order> Orders { get; set; }
    }

    public partial class Order
    {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("order_amount")]
        public string OrderAmount { get; set; }

        [JsonProperty("order_date_placed")]
        public DateTimeOffset OrderDatePlaced { get; set; }

        [JsonProperty("order_date_payment")]
        public DateTimeOffset OrderDatePayment { get; set; }

        [JsonProperty("order_date_delivered")]
        public string OrderDateDelivered { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("client")]
        public long Client { get; set; }

        [JsonProperty("customer")]
        public long Customer { get; set; }

        [JsonProperty("order_staff")]
        public long OrderStaff { get; set; }
    }

    public partial class OrdersResponse
    {
        public static OrdersResponse FromJson(string json) => JsonConvert.DeserializeObject<OrdersResponse>(json, RoomBox___DataPortal.Dtos.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OrdersResponse self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.Converter.Settings);
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
