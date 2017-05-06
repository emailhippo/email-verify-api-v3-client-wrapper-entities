// <copyright file="EmailVerification.cs" company="Email Hippo Ltd">
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
    using ProtoBuf;

    /// <summary>
    /// Email verification.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "EmailVerification")]
    [Serializable]
    public sealed class EmailVerification
    {
        /// <summary>
        /// Gets or sets the syntax verification.
        /// </summary>
        /// <value>
        /// The syntax verification.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"SyntaxVerification", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"syntaxVerification", Order = 1)]
        public SyntaxVerification SyntaxVerification { get; set; }

        /// <summary>
        /// Gets or sets the DNS verification.
        /// </summary>
        /// <value>
        /// The DNS verification.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"DnsVerification", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"dnsVerification", Order = 2)]
        public DnsVerification DnsVerification { get; set; }

        /// <summary>
        /// Gets or sets the mailbox verification.
        /// </summary>
        /// <value>
        /// The mailbox verification.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"MailboxVerification", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"mailboxVerification", Order = 3)]
        public MailboxVerification MailboxVerification { get; set; }
    }
}