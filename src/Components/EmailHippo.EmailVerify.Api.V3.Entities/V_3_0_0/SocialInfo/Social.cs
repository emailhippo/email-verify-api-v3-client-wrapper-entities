// <copyright file="Social.cs" company="Email Hippo Ltd">
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
    /// The social class.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Social")]
    public sealed class Social
    {
        /// <summary>
        /// Gets or sets the gravatar.
        /// </summary>
        /// <value>
        /// The gravatar.
        /// </value>
        [DataMember(Name = @"Gravatar", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = @"gravatar", Order = 1)]
        [ProtoMember(1)]
        public Gravatar Gravatar { get; set; }
    }
}