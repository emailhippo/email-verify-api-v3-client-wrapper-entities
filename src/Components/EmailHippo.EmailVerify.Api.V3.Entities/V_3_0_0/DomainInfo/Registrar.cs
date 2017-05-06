// <copyright file="Registrar.cs" company="Email Hippo Ltd">
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
    using ProtoBuf;

    /// <summary>
    /// The registrar data.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Registrar")]
    public sealed class Registrar
    {
        /// <summary>
        /// Gets or sets the registrar identifier.
        /// </summary>
        /// <value>
        /// The registrar identifier.
        /// </value>
        [ProtoMember(1)]
        public string RegistrarId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [ProtoMember(2)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the whois.
        /// </summary>
        /// <value>
        /// The whois.
        /// </value>
        [ProtoMember(3)]
        public string Whois { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [ProtoMember(4)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the abuse email.
        /// </summary>
        /// <value>
        /// The abuse email.
        /// </value>
        [ProtoMember(5)]
        public string AbuseEmail { get; set; }

        /// <summary>
        /// Gets or sets the abuse phone.
        /// </summary>
        /// <value>
        /// The abuse phone.
        /// </value>
        [ProtoMember(6)]
        public string AbusePhone { get; set; }
    }
}