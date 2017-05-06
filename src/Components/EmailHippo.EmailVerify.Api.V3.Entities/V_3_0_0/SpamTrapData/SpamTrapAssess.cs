// <copyright file="SpamTrapAssess.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.SpamTrapData
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// The spam trap assesment.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "SpamTrapAssess")]
    [Serializable]
    public sealed class SpamTrapAssess
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is spam trap.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is spam trap; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"IsSpamTrap", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"isSpamTrap", Order = 1)]
        public bool IsSpamTrap { get; set; }

        /// <summary>
        /// Gets or sets the spam trap descriptor.
        /// </summary>
        /// <value>
        /// The spam trap descriptor.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"SpamTrapDescriptor", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"spamTrapDescriptor", Order = 2)]
        public string SpamTrapDescriptor { get; set; }
    }
}