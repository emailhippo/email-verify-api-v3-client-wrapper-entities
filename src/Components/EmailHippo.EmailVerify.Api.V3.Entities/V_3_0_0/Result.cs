// <copyright file="Result.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using DiagnosticInfo;
    using Dispositions;
    using DomainInfo;
    using InfrastructureInfo;
    using MailSend;
    using MetaInfo;
    using Newtonsoft.Json;
    using PerformanceInfo;
    using ProtoBuf;
    using SocialInfo;
    using SpamData;
    using SpamTrapData;
    using Trust;

    /// <summary>
    /// The result.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Result")]
    [XmlType("Result", AnonymousType = true, IncludeInSchema = false)]
    [XmlRoot("Result")]
    public sealed class Result
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Version", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"version", Order = 1)]
        public VersionInfo.Version Version { get; set; }

        /// <summary>
        /// Gets or sets the meta.
        /// </summary>
        /// <value>
        /// The meta.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name= @"Meta", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"meta", Order = 2)]
        public Meta Meta { get; set; }

        /// <summary>
        /// Gets or sets the disposition.
        /// </summary>
        /// <value>
        /// The disposition.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"Disposition", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"disposition", Order = 3)]
        public Disposition Disposition { get; set; }

        /// <summary>
        /// Gets or sets the email verification.
        /// </summary>
        /// <value>
        /// The email verification.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"EmailVerification", IsRequired = true, Order = 4)]
        [JsonProperty(PropertyName = @"emailVerification", Order = 4)]
        public EmailVerificationInfo.EmailVerification EmailVerification { get; set; }

        /// <summary>
        /// Gets or sets the infrastructure.
        /// </summary>
        /// <value>
        /// The infrastructure.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"Infrastructure", IsRequired = true, Order = 5)]
        [JsonProperty(PropertyName = @"infrastructure", Order = 5)]
        public Infrastructure Infrastructure { get; set; }

        /// <summary>
        /// Gets or sets the send assess.
        /// </summary>
        /// <value>
        /// The send assess.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"SendAssess", IsRequired = true, Order = 6)]
        [JsonProperty(PropertyName = @"sendAssess", Order = 6)]
        public SendAssess SendAssess { get; set; }

        /// <summary>
        /// Gets or sets the spam information.
        /// </summary>
        /// <value>
        /// The spam information.
        /// </value>
        [ProtoMember(7)]
        [DataMember(Name = @"SpamAssess", IsRequired = true, Order = 7)]
        [JsonProperty(PropertyName = @"spamAssess", Order = 7)]
        public SpamAssess SpamAssess { get; set; }

        /// <summary>
        /// Gets or sets the spam trap information.
        /// </summary>
        /// <value>
        /// The spam trap information.
        /// </value>
        [ProtoMember(8)]
        [DataMember(Name = @"SpamTrapAssess", IsRequired = true, Order = 8)]
        [JsonProperty(PropertyName = @"spamTrapAssess", Order = 8)]
        public SpamTrapAssess SpamTrapAssess { get; set; }

        /// <summary>
        /// Gets or sets the trust score.
        /// </summary>
        /// <value>
        /// The trust score.
        /// </value>
        [ProtoMember(9)]
        [DataMember(Name = @"HippoTrust", IsRequired = true, Order = 9)]
        [JsonProperty(PropertyName = @"hippoTrust", Order = 9)]
        public HippoTrust HippoTrust { get; set; }

        /// <summary>
        /// Gets or sets the social data.
        /// </summary>
        /// <value>
        /// The social data.
        /// </value>
        [ProtoMember(10)]
        [DataMember(Name = @"Social", IsRequired = true, Order = 10)]
        [JsonProperty(PropertyName = @"social", Order = 10)]
        public Social Social { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        [ProtoMember(11)]
        [DataMember(Name = @"Domain", IsRequired = true, Order = 11)]
        [JsonProperty(PropertyName = @"domain", Order = 11)]
        public Domain Domain { get; set; }

        /// <summary>
        /// Gets or sets the performance.
        /// </summary>
        /// <value>
        /// The performance.
        /// </value>
        [ProtoMember(12)]
        [DataMember(Name = @"Performance", IsRequired = true, Order = 12)]
        [JsonProperty(PropertyName = @"performance", Order = 12)]
        public Performance Performance { get; set; }

        /// <summary>
        /// Gets or sets the diagnostic.
        /// </summary>
        /// <value>
        /// The diagnostic.
        /// </value>
        [ProtoMember(13)]
        [DataMember(Name = @"Diagnostic", IsRequired = true, Order = 13)]
        [JsonProperty(PropertyName = @"diagnostic", Order = 13)]
        public Diagnostic Diagnostic { get; set; }
    }
}