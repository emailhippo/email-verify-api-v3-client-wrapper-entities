// <copyright file="SpamAssess.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.SpamData
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ProtoBuf;

    /// <summary>
    /// the spam info.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "SpamAssess")]
    [Serializable]
    public sealed class SpamAssess
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposable email address.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is disposable email address; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"IsDisposableEmailAddress", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"isDisposableEmailAddress", Order = 1)]
        public bool IsDisposableEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is dark web email address.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is dark web email address; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"IsDarkWebEmailAddress", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"isDarkWebEmailAddress", Order = 2)]
        public bool IsDarkWebEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is gibberish domain.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is gibberish domain; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"IsGibberishDomain", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"isGibberishDomain", Order = 3)]
        public bool IsGibberishDomain { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is gibberish user.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is gibberish user; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"IsGibberishUser", IsRequired = true, Order = 4)]
        [JsonProperty(PropertyName = @"isGibberishUser", Order = 4)]
        public bool IsGibberishUser { get; set; }

        /// <summary>
        /// Gets or sets the domain risk score.
        /// </summary>
        /// <value>
        /// The domain risk score.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"DomainRiskScore", IsRequired = true, Order = 5)]
        [JsonProperty(PropertyName = @"domainRiskScore", Order = 5)]
        public double DomainRiskScore { get; set; }

        /// <summary>
        /// Gets or sets the format risk score.
        /// </summary>
        /// <value>
        /// The format risk score.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"FormatRiskScore", IsRequired = true, Order = 6)]
        [JsonProperty(PropertyName = @"formatRiskScore", Order = 6)]
        public double FormatRiskScore { get; set; }

        /// <summary>
        /// Gets or sets the profanity risk score.
        /// </summary>
        /// <value>
        /// The profanity risk score.
        /// </value>
        [ProtoMember(7)]
        [DataMember(Name = @"ProfanityRiskScore", IsRequired = true, Order = 7)]
        [JsonProperty(PropertyName = @"profanityRiskScore", Order = 7)]
        public double ProfanityRiskScore { get; set; }

        /// <summary>
        /// Gets or sets the overall risk score.
        /// </summary>
        /// <value>
        /// The overall risk score.
        /// </value>
        [ProtoMember(8)]
        [DataMember(Name = @"OverallRiskScore", IsRequired = true, Order = 8)]
        [JsonProperty(PropertyName = @"overallRiskScore", Order = 8)]
        public double OverallRiskScore { get; set; }

        /// <summary>
        /// Gets or sets the action recomendation.
        /// </summary>
        /// <value>
        /// The action recomendation.
        /// </value>
        [ProtoMember(9)]
        [JsonProperty(PropertyName = @"actionRecomendation", Order = 9)]
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = @"ActionRecomendation", Order = 9)]
        public SpamDataAssessType ActionRecomendation { get; set; }

        /// <summary>
        /// Gets or sets the block lists.
        /// </summary>
        /// <value>
        /// The block lists.
        /// </value>
        [ProtoMember(10)]
        [DataMember(Name = @"BlockLists", IsRequired = false, Order = 10)]
        [JsonProperty(PropertyName = @"blockLists", Order = 10)]
        public List<BlockList> BlockLists { get; set; }
    }
}