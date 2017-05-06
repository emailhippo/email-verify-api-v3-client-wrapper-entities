// <copyright file="Disposition.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.Dispositions
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// The disposition
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Disposition")]
    [Serializable]
    public sealed class Disposition
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is role.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is role; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"IsRole", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"isRole", Order = 1)]
        public bool IsRole { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is free mail.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is free mail; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"IsFreeMail", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"isFreeMail", Order = 2)]
        public bool IsFreeMail { get; set; }
    }
}