// <copyright file="DnsVerification.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.EmailVerificationInfo
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using Net;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// DNS verification
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "DnsVerification")]
    [Serializable]
    public sealed class DnsVerification
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is domain has DNS record.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is domain has DNS record; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"IsDomainHasDnsRecord", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"isDomainHasDnsRecord", Order = 1)]
        public bool IsDomainHasDnsRecord { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is domain has mx records.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is domain has mx records; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"IsDomainHasMxRecords", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"isDomainHasMxRecords", Order = 2)]
        public bool IsDomainHasMxRecords { get; set; }

        /// <summary>
        /// Gets or sets A records.
        /// </summary>
        /// <value>
        /// A records.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"RecordRoot", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"recordRoot", Order = 3)]
        public Record RecordRoot { get; set; }

        /// <summary>
        /// Gets or sets the record WWW.
        /// </summary>
        /// <value>
        /// The record WWW.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"RecordWww", IsRequired = true, Order = 4)]
        [JsonProperty(PropertyName = @"recordWww", Order = 4)]
        public Record RecordWww { get; set; }

        /// <summary>
        /// Gets or sets the MX records.
        /// </summary>
        /// <value>
        /// The MX records.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"MxRecords", IsRequired = true, Order = 5)]
        [JsonProperty(PropertyName = @"mxRecords", Order = 5)]
        public List<MxRecord> MxRecords { get; set; }

        /// <summary>
        /// Gets or sets the text records.
        /// </summary>
        /// <value>
        /// The text records.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"TxtRecords", IsRequired = true, Order = 6)]
        [JsonProperty(PropertyName = @"txtRecords", Order = 6)]
        [XmlArray("TxtRecords")]
        [XmlArrayItem("Value")]
        public List<string> TxtRecords { get; set; }
    }
}