﻿using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Newtonsoft.Json;

namespace Dime.Maps
{
    /// <summary>
    /// Represents a response to the XLocate web api
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class AddressReponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressReponse"/> class
        /// </summary>
        internal AddressReponse()
        {
        }

        /// <summary>
        /// Gets or sets the error code
        /// </summary>
        [JsonProperty("errorCode")]
        internal long ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error description
        /// </summary>
        [JsonProperty("errorDescription")]
        internal string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets the result list
        /// </summary>
        [JsonProperty("resultList")]
        internal ResultList[] ResultList { get; set; }

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        };

        /// <summary>
        /// Gets the coordinates from the instance
        /// </summary>
        /// <returns>The instance of the coordinate is not null</returns>
        internal Point GetCoordinates()
        {
            if (!ResultList.Any())
                return null;

            Point coordinates = ResultList.OrderByDescending(r => r.TotalScore).ElementAt(0).Coordinates.Point;
            double? x = coordinates?.X;
            double? y = coordinates?.Y;

            return x != null && y != null ? coordinates : null;
        }

        /// <summary>
        /// Deserializes the json into a populated address response
        /// </summary>
        /// <param name="json">The json string to deserialize</param>
        /// <returns>A populated address response</returns>
        internal static AddressReponse FromJson(string json) => JsonConvert.DeserializeObject<AddressReponse>(json, Settings);

        /// <summary>
        /// Serializes the address response
        /// </summary>
        /// <returns>A serialized string</returns>
        internal string ToJson() => JsonConvert.SerializeObject(this, Settings);
    }
}