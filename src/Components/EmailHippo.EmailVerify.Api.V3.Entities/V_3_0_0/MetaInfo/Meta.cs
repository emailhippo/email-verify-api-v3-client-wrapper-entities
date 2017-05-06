// <copyright file="Meta.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.MetaInfo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// The meta information for verification.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Meta")]
    public sealed class Meta
    {
        /// <summary>
        /// Gets or sets the last modified.
        /// </summary>
        /// <value>
        /// The last modified.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"LastModified", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = "lastModified", Order = 1)]
        public string LastModified { get; set; }

        /// <summary>
        /// Gets or sets the expires.
        /// </summary>
        /// <value>
        /// The expires.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"Expires", IsRequired = false, Order = 2)]
        [JsonProperty(PropertyName = "expires", Order = 2)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"Email", IsRequired = false, Order = 3)]
        [JsonProperty(PropertyName = "email", Order = 3)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the TLD.
        /// </summary>
        /// <value>
        /// The TLD.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"Tld", IsRequired = false, Order = 4)]
        [JsonProperty(PropertyName = "tld", Order = 4)]
        public string Tld { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"Domain", IsRequired = false, Order = 5)]
        [JsonProperty(PropertyName = "domain", Order = 5)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"SubDomain", IsRequired = false, Order = 6)]
        [JsonProperty(PropertyName = "subDomain", Order = 6)]
        public string SubDomain { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        [ProtoMember(7)]
        [DataMember(Name = @"User", IsRequired = false, Order = 7)]
        [JsonProperty(PropertyName = "user", Order = 7)]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the email addess hash MD5.
        /// </summary>
        /// <value>
        /// The email addess hash MD5.
        /// </value>
        [ProtoMember(8)]
        [DataMember(Name = @"EmailAddessHashMd5", IsRequired = false, Order = 8)]
        [JsonProperty(PropertyName = "emailHashMd5", Order = 7)]
        public string EmailAddessHashMd5 { get; set; }

        /// <summary>
        /// Gets or sets the email address hash sha1.
        /// </summary>
        /// <value>
        /// The email address hash sha1.
        /// </value>
        [ProtoMember(9)]
        [DataMember(Name = @"EmailAddressHashSha1", IsRequired = false, Order = 9)]
        [JsonProperty(PropertyName = "emailHashSha1", Order = 7)]
        public string EmailAddressHashSha1 { get; set; }

        /// <summary>
        /// Gets or sets the email address hash sha265.
        /// </summary>
        /// <value>
        /// The email address hash sha265.
        /// </value>
        [ProtoMember(10)]
        [DataMember(Name = @"EmailAddressHashSha256", IsRequired = false, Order = 10)]
        [JsonProperty(PropertyName = "emailHashSha256", Order = 10)]
        public string EmailAddressHashSha256 { get; set; }
    }
}