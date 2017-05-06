// <copyright file="Domain.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.DomainInfo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// Domain Info.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Domain")]
    public sealed class Domain
    {
        /// <summary>
        /// Gets or sets a value indicating whether [record found].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [record found]; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"RecordFound", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"recordFound", Order = 1)]
        public bool RecordFound { get; set; }

        /// <summary>
        /// Gets or sets the name of the domain.
        /// </summary>
        /// <value>
        /// The name of the domain.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"DomainName", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"domainName", Order = 2)]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the TLD.
        /// </summary>
        /// <value>
        /// The TLD.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"Tld", IsRequired = true, Order = 3)]
        [JsonProperty(PropertyName = @"tld", Order = 3)]
        public string Tld { get; set; }

        /// <summary>
        /// Gets or sets the domain owner contact.
        /// </summary>
        /// <value>
        /// The domain owner contact.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"DomainOwnerContact", IsRequired = true, Order = 4)]
        [JsonProperty(PropertyName = @"domainOwnerContact", Order = 4)]
        public Contact DomainOwnerContact { get; set; }

        /// <summary>
        /// Gets or sets the admin contact.
        /// </summary>
        /// <value>
        /// The admin contact.
        /// </value>
        [ProtoMember(5)]
        [DataMember(Name = @"AdminContact", IsRequired = true, Order = 5)]
        [JsonProperty(PropertyName = @"adminContact", Order = 5)]
        public Contact AdminContact { get; set; }

        /// <summary>
        /// Gets or sets the billing contact.
        /// </summary>
        /// <value>
        /// The billing contact.
        /// </value>
        [ProtoMember(6)]
        [DataMember(Name = @"BillingContact", IsRequired = true, Order = 6)]
        [JsonProperty(PropertyName = @"billingContact", Order = 6)]
        public Contact BillingContact { get; set; }

        /// <summary>
        /// Gets or sets the tech contact.
        /// </summary>
        /// <value>
        /// The tech contact.
        /// </value>
        [ProtoMember(7)]
        [DataMember(Name = @"TechContact", IsRequired = true, Order = 7)]
        [JsonProperty(PropertyName = @"techContact", Order = 7)]
        public Contact TechContact { get; set; }

        /// <summary>
        /// Gets or sets the registrar contact.
        /// </summary>
        /// <value>
        /// The registrar contact.
        /// </value>
        [ProtoMember(8)]
        [DataMember(Name = @"RegistrarContact", IsRequired = true, Order = 8)]
        [JsonProperty(PropertyName = @"registrarContact", Order = 8)]
        public Contact RegistrarContact { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        [ProtoMember(9)]
        [DataMember(Name = @"Created", IsRequired = true, Order = 9)]
        [JsonProperty(PropertyName = @"created", Order = 9)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the change date.
        /// </summary>
        /// <value>
        /// The modified.
        /// </value>
        [ProtoMember(10)]
        [DataMember(Name = @"Changed", IsRequired = true, Order = 10)]
        [JsonProperty(PropertyName = @"changed", Order = 10)]
        public DateTime? Changed { get; set; }

        /// <summary>
        /// Gets or sets the expiry.
        /// </summary>
        /// <value>
        /// The expiry.
        /// </value>
        [ProtoMember(11)]
        [DataMember(Name = @"Expiry", IsRequired = true, Order = 11)]
        [JsonProperty(PropertyName = @"expiry", Order = 11)]
        public DateTime? Expiry { get; set; }

        /// <summary>
        /// Gets or sets the domain age in days (if known).
        /// </summary>
        /// <value>
        /// The domain age in days (if known).
        /// </value>
        [ProtoMember(12)]
        [DataMember(Name = @"DomainAgeDays", IsRequired = true, Order = 12)]
        [JsonProperty(PropertyName = @"domainAgeDays", Order = 12)]
        public int? DomainAgeDays { get; set; }
    }
}