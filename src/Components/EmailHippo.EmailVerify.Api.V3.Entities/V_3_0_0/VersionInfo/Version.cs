﻿// <copyright file="Version.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.VersionInfo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// Version information.
    /// </summary>
    [ProtoContract]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Version")]
    [Serializable]
    public sealed class Version
    {
        /// <summary>
        /// Gets or sets the v.
        /// </summary>
        /// <value>
        /// The v.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"V", IsRequired = false, Order = 1)]
        [JsonProperty(PropertyName = @"v", Order = 1)]
        public string V { get; set; }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        [ProtoMember(2)]
        [DataMember(Name = @"Doc", IsRequired = false, Order = 2)]
        [JsonProperty(PropertyName = @"doc", Order = 2)]
        public string Doc { get; set; }
    }
}