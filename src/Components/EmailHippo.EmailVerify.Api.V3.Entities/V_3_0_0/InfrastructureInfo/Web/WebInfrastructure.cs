// <copyright file="WebInfrastructure.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.InfrastructureInfo.Web
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using ProtoBuf;

    /// <summary>
    /// Web Infrastructure
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "WebInfrastructure")]
    public sealed class WebInfrastructure
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance has alive web server.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has alive web server; otherwise, <c>false</c>.
        /// </value>
        [ProtoMember(1)]
        [DataMember(Name = @"HasAliveWebServer", IsRequired = true, Order = 1)]
        [JsonProperty(PropertyName = "hasAliveWebServer", Order = 1)]
        public bool HasAliveWebServer { get; set; }
    }
}