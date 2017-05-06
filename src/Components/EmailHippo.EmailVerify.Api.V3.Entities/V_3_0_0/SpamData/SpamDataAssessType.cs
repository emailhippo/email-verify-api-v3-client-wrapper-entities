﻿// <copyright file="SpamDataAssessType.cs" company="Email Hippo Ltd">
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
    /// <summary>
    /// Spam data assesment type.
    /// </summary>
    public enum SpamDataAssessType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The allow
        /// </summary>
        Allow,

        /// <summary>
        /// The block
        /// </summary>
        Block,

        /// <summary>
        /// The risky
        /// </summary>
        Risky
    }
}