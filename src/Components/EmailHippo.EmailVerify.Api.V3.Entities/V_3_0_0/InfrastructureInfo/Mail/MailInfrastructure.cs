// <copyright file="MailInfrastructure.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.InfrastructureInfo.Mail
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ProtoBuf;

    /// <summary>
    /// Infrastructure.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "MailInfrastructure")]
    public sealed class MailInfrastructure
    {
        /// <summary>
        /// Gets or sets the type of the mail infrastructure service.
        /// </summary>
        /// <value>
        /// The type of the mail infrastructure service.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"MailInfrastructureServiceType", IsRequired = true, Order = 1)]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = @"serviceTypeId", Order = 1)]
        public MailInfrastructureServiceType MailInfrastructureServiceType { get; set; }

        /// <summary>
        /// Gets or sets the mail server location.
        /// </summary>
        /// <value>
        /// The mail server location.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"MailServerLocation", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = "mailServerLocation", Order = 2)]
        public string MailServerLocation { get; set; }

        /// <summary>
        /// Gets or sets the SMTP banner.
        /// </summary>
        /// <value>
        /// The SMTP banner.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"SmtpBanner", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = "smtpBanner", Order = 3)]
        public string SmtpBanner { get; set; }
    }
}