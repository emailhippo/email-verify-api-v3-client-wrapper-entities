﻿// <copyright file="MailInfrastructureServiceType.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.InfrastructureInfo.Mail
{
    /// <summary>
    /// The mail infrastructure service type.
    /// </summary>
    public enum MailInfrastructureServiceType
    {
        /// <summary>
        /// The other.
        /// </summary>
        Other,

        /// <summary>
        /// The AOL.
        /// </summary>
        Aol,

        /// <summary>
        /// The hotmail.
        /// </summary>
        Hotmail,

        /// <summary>
        /// The gmail.
        /// </summary>
        Gmail,

        /// <summary>
        /// The google for biz
        /// </summary>
        GoogleForBiz,

        /// <summary>
        /// The message labs.
        /// </summary>
        MessageLabs,

        /// <summary>
        /// The net4 sec
        /// </summary>
        Net4Sec,

        /// <summary>
        /// The office 365.
        /// </summary>
        Office365,

        /// <summary>
        /// The yahoo.
        /// </summary>
        Yahoo,

        /// <summary>
        /// The UCE protect
        /// </summary>
        UceProtect
    }
}