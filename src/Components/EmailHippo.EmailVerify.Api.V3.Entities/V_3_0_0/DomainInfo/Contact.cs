// <copyright file="Contact.cs" company="Email Hippo Ltd">
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
    /// The contact class.
    /// </summary>
    [ProtoContract]
    [Serializable]
    [DataContract(Namespace = "http://emh.ev/2017/api/v3", Name = "Contact")]
    public sealed class Contact
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [ProtoMember(1)]
        public string UserId { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        [ProtoMember(2)]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the organization.
        /// </summary>
        /// <value>
        ///     The organization.
        /// </value>
        [ProtoMember(3)]
        public string Organization { get; set; }

        /// <summary>
        ///     Gets or sets the street 1.
        /// </summary>
        /// <value>
        ///     The street.
        /// </value>
        [ProtoMember(4)]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or sets the street2.
        /// </summary>
        /// <value>
        /// The street2.
        /// </value>
        [ProtoMember(5)]
        public string Street2 { get; set; }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        /// <value>
        ///     The city.
        /// </value>
        [ProtoMember(6)]
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>
        ///     The state.
        /// </value>
        [ProtoMember(7)]
        public string State { get; set; }

        /// <summary>
        ///     Gets or sets the postal code.
        /// </summary>
        /// <value>
        ///     The postal code.
        /// </value>
        [ProtoMember(8)]
        public string PostalCode { get; set; }

        /// <summary>
        ///     Gets or sets the country.
        /// </summary>
        /// <value>
        ///     The country.
        /// </value>
        [ProtoMember(9)]
        public string Country { get; set; }

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        /// <value>
        ///     The phone number.
        /// </value>
        [ProtoMember(10)]
        public string PhoneNumber { get; set; }

        /// <summary>
        ///     Gets or sets the phone number ext.
        /// </summary>
        /// <value>
        ///     The phone number ext.
        /// </value>
        [ProtoMember(11)]
        public string PhoneNumberExt { get; set; }

        /// <summary>
        ///     Gets or sets the fax number.
        /// </summary>
        /// <value>
        ///     The fax number.
        /// </value>
        [ProtoMember(12)]
        public string FaxNumber { get; set; }

        /// <summary>
        ///     Gets or sets the fax number ext.
        /// </summary>
        /// <value>
        ///     The fax number ext.
        /// </value>
        [ProtoMember(13)]
        public string FaxNumberExt { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        /// <value>
        ///     The email.
        /// </value>
        [ProtoMember(14)]
        public string Email { get; set; }
    }
}