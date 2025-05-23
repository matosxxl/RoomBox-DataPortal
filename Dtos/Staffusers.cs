﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.Json;

// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using RoomBox___DataPortal.Dtos;
//
//    var getUsuarios = GetUsuarios.FromJson(jsonString);

namespace RoomBox___DataPortal.Dtos.GetUsuarios
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetUsuarios
    {
        [JsonProperty("count", Required = Required.Always)]
        public long count { get; set; }

        [JsonProperty("next", Required = Required.AllowNull)]
        public object next { get; set; }

        [JsonProperty("previous", Required = Required.AllowNull)]
        public object previous { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public Result[] results { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("staff_id", Required = Required.Always)]
        public long staff_id { get; set; }

        [JsonProperty("staff_employee_no", Required = Required.Always)]
        public string staff_employee_no { get; set; }

        [JsonProperty("staff_name", Required = Required.Always)]
        public string staff_name { get; set; }

        [JsonProperty("staff_last_name", Required = Required.Always)]
        public string staff_last_name { get; set; }

        [JsonProperty("staff_doctype", Required = Required.Always)]
        public string staff_doctype { get; set; }

        [JsonProperty("staff_identification", Required = Required.Always)]
        public string staff_identification { get; set; }

        [JsonProperty("staff_email", Required = Required.Always)]
        public string staff_email { get; set; }

        [JsonProperty("staff_phone", Required = Required.Always)]
        public string staff_phone { get; set; }

        [JsonProperty("staff_address", Required = Required.Always)]
        public string staff_address { get; set; }

        [JsonProperty("staff_status", Required = Required.Always)]
        public bool staff_status { get; set; }

        [JsonProperty("created_at", Required = Required.AllowNull)]
        public DateTimeOffset? created_at { get; set; }

        [JsonProperty("user", Required = Required.Always)]
        public long user { get; set; }
    }

    public partial class GetUsuarios
    {
        public static GetUsuarios FromJson(string json) => JsonConvert.DeserializeObject<GetUsuarios>(json, RoomBox___DataPortal.Dtos.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetUsuarios self) => JsonConvert.SerializeObject(self, RoomBox___DataPortal.Dtos.Converter.Settings);
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
