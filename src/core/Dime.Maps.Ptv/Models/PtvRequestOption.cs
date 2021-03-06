﻿using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Dime.Maps
{
    /// <summary>
    /// Represents extra options that go in the request
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class PtvRequestOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtvRequestOption"/> class
        /// </summary>
        internal PtvRequestOption()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PtvRequestOption"/> class
        /// </summary>
        /// <param name="param"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        internal PtvRequestOption(string param, string value)
        {
            Param = param;
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PtvRequestOption"/> class
        /// </summary>
        /// <param name="param"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        internal PtvRequestOption(string param, string value, string type) : this(param, value)
        {
            Type = type;
        }

        [JsonProperty("$type")]
        internal string Type { get; set; } = "SearchOption";

        [JsonProperty("param")]
        internal string Param { get; set; }

        [JsonProperty("value")]
        internal string Value { get; set; }
    }
}