// <copyright file="HippoTrust.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.Trust
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ProtoBuf;

    /// <summary>
    /// The Trust Score.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "HippoTrust")]
    public sealed class HippoTrust
    {
        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        /// <value>
        /// The score.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Score", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"score", Order = 1)]
        public double Score { get; set; }

        /// <summary>
        /// Gets or sets the type of the trust level.
        /// </summary>
        /// <value>
        /// The type of the trust level.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"Level", IsRequired = true, Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(PropertyName = @"level", Order = 2)]
        public TrustLevelType Level { get; set; }
    }
}