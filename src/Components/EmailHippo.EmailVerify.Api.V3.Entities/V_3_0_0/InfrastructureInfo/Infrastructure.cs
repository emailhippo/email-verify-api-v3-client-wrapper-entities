﻿// <copyright file="Infrastructure.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.InfrastructureInfo
{
    using System;
    using System.Runtime.Serialization;
    using Mail;
    using Newtonsoft.Json;
    using ProtoBuf;
    using Web;

    /// <summary>
    /// The infrastructure.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Infrastructure")]
    public sealed class Infrastructure
    {
        /// <summary>
        /// Gets or sets the mail infrastructure.
        /// </summary>
        /// <value>
        /// The mail infrastructure.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"Mail", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = @"mail", Order = 1)]
        public MailInfrastructure Mail { get; set; }

        /// <summary>
        /// Gets or sets the web infrastructure.
        /// </summary>
        /// <value>
        /// The web infrastructure.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"Web", IsRequired = true, Order = 2)]
        [JsonProperty(PropertyName = @"web", Order = 2)]
        public WebInfrastructure Web { get; set; }
    }
}