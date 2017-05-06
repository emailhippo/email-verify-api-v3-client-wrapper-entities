// <copyright file="MxRecord.cs" company="Email Hippo Ltd">
// (c) 2017, Email Hippo Ltd
// </copyright>

// Copyright 2017 Email Hippo Ltd
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.Net
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// MX record.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "MxRecord")]
    [Serializable]
    public sealed class MxRecord
    {
        /// <summary>
        /// Gets or sets the preference.
        /// </summary>
        /// <value>
        /// The preference.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Preference", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = @"preference", Order = 1)]
        public int Preference { get; set; }

        /// <summary>
        /// Gets or sets the exchange.
        /// </summary>
        /// <value>
        /// The exchange.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"Exchange", IsRequired = false, Order = 2)]
        [JsonProperty(PropertyName = @"exchange", Order = 2)]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or sets the ip addresses.
        /// </summary>
        /// <value>
        /// The ip addresses.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"IpAddresses", IsRequired = false, Order = 3)]
        [JsonProperty(PropertyName = @"ipAddresses", Order = 3)]
        [XmlArray("IpAddresses")]
        [XmlArrayItem("Address")]
        public List<string> IpAddresses { get; set; }
    }
}