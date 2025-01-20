using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RoomBox___DataPortal.Dtos.Staff
{

    public partial class StaffResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public object Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Staff> Results { get; set; }
    }

    public partial class Staff
    {
        [JsonProperty("staff_id")]
        public long StaffId { get; set; }

        [JsonProperty("staff_employee_no")]
        public string StaffEmployeeNo { get; set; }

        [JsonProperty("staff_name")]
        public string StaffName { get; set; }

        [JsonProperty("staff_last_name")]
        public string StaffLastName { get; set; }

        [JsonProperty("staff_doctype")]
        public string StaffDoctype { get; set; }

        [JsonProperty("staff_identification")]
        public string StaffIdentification { get; set; }

        [JsonProperty("staff_email")]
        public string StaffEmail { get; set; }

        [JsonProperty("staff_phone")]
        public string StaffPhone { get; set; }

        [JsonProperty("staff_address")]
        public string StaffAddress { get; set; }

        [JsonProperty("staff_status")]
        public bool StaffStatus { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("user")]
        public long User { get; set; }
    }

    public partial class StaffResponse
    {
        public static StaffResponse FromJson(string json) => JsonConvert.DeserializeObject<StaffResponse>(json, RoomBox___DataPortal.Dtos.Staff.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this StaffResponse self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.Staff.Converter.Settings);
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
