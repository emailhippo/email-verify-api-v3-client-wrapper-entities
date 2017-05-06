// <copyright file="Performance.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.PerformanceInfo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// Performance metrics
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Performance")]
    [Serializable]
    public sealed class Performance
    {
        /// <summary>
        /// Gets or sets the syntax check.
        /// </summary>
        /// <value>
        /// The syntax check.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"SyntaxCheck", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"syntaxCheck", Order = 1)]
        public int SyntaxCheck { get; set; }

        /// <summary>
        /// Gets or sets the DNS lookup.
        /// </summary>
        /// <value>
        /// The DNS lookup.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"DnsLookup", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"dnsLookup", Order = 2)]
        public int DnsLookup { get; set; }

        /// <summary>
        /// Gets or sets the spam assessment.
        /// </summary>
        /// <value>
        /// The spam assessment.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"SpamAssessment", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"spamAssessment", Order = 3)]
        public int SpamAssessment { get; set; }

        /// <summary>
        /// Gets or sets the mailbox verification.
        /// </summary>
        /// <value>
        /// The mailbox verification.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"MailboxVerification", IsRequired = true, Order = 4)]
        [JsonProperty(PropertyName = @"mailboxVerification", Order = 4)]
        public int MailboxVerification { get; set; }

        /// <summary>
        /// Gets or sets the web infrastructure ping.
        /// </summary>
        /// <value>
        /// The web infrastructure ping.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"WebInfrastructurePing", IsRequired = true, Order = 5)]
        [JsonProperty(PropertyName = @"webInfrastructurePing", Order = 5)]
        public int WebInfrastructurePing { get; set; }

        /// <summary>
        /// Gets or sets the other.
        /// </summary>
        /// <value>
        /// The other.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"Other", IsRequired = true, Order = 6)]
        [JsonProperty(PropertyName = @"other", Order = 6)]
        public int Other { get; set; }

        /// <summary>
        /// Gets or sets the overall execution time.
        /// </summary>
        /// <value>
        /// The overall execution time.
        /// </value>
        [ProtoMember(7)]
        [DataMember(Name = @"OverallExecutionTime", IsRequired = true, Order = 7)]
        [JsonProperty(PropertyName = @"overallExecutionTime", Order = 7)]
        public int OverallExecutionTime { get; set; }
    }
}