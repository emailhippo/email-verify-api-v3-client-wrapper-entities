// <copyright file="BlockList.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.SpamData
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// The block list.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "BlockList")]
    [Serializable]
    public sealed class BlockList
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Name", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = @"blockListName", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is listed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is listed; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"IsListed", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"isListed", Order = 2)]
        public bool IsListed { get; set; }

        /// <summary>
        /// Gets or sets the listed reason.
        /// </summary>
        /// <value>
        /// The listed reason.
        /// </value>
        [ProtoMember(3)]
        [DataMember(Name = @"ListedReason", IsRequired = false, Order = 3)]
        [JsonProperty(PropertyName = @"listedReason", Order = 3)]
        public string ListedReason { get; set; }

        /// <summary>
        /// Gets or sets the listed more information.
        /// </summary>
        /// <value>
        /// The listed more information.
        /// </value>
        [ProtoMember(4)]
        [DataMember(Name = @"ListedMoreInfo", IsRequired = false, Order = 4)]
        [JsonProperty(PropertyName = @"listedMoreInfo", Order = 4)]
        public string ListedMoreInfo { get; set; }
    }
}