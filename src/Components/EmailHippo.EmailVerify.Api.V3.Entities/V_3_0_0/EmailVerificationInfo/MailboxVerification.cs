// <copyright file="MailboxVerification.cs" company="Email Hippo Ltd">
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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ProtoBuf;
    using Statuses;

    /// <summary>
    /// Mailbox verification.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "MailboxVerification")]
    [Serializable]
    public sealed class MailboxVerification
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Status", IsRequired = true, Order = 1)]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = @"result", Order = 1)]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the additional status.
        /// </summary>
        /// <value>
        /// The additional status.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"AdditionalStatus", IsRequired = true, Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = @"reason", Order = 2)]
        public AdditionalStatus AdditionalStatus { get; set; }
    }
}