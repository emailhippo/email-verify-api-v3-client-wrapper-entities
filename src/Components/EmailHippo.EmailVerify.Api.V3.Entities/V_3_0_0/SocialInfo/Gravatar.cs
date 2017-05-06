// <copyright file="Gravatar.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.SocialInfo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// The Gravatar resourece details
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Gravatar")]
    public sealed class Gravatar
    {
        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        [DataMember(Name = @"ImageUrl", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = @"imageUrl", Order = 1)]
        [ProtoMember(1)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the profile URL.
        /// </summary>
        /// <value>
        /// The profile URL.
        /// </value>
        [DataMember(Name = @"ProfileUrl", IsRequired = false, Order = 2)]
        [JsonProperty(PropertyName = @"profileUrl", Order = 2)]
        [ProtoMember(2)]
        public string ProfileUrl { get; set; }
    }
}