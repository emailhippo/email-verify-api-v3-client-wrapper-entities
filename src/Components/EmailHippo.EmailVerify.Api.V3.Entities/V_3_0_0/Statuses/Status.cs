// <copyright file="Status.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.V_3_0_0.Statuses
{
    /// <summary>
    ///     The status.
    /// </summary>
    public enum Status
    {
        /// <summary>
        ///   <para>No status available.</para>
        /// </summary>
        None = 0,

        /// <summary>
        ///     <para>Verification passes all checks including Syntax, DNS, MX, Mailbox, Deep Server Configuration, Grey listing.</para>.
        /// </summary>
        Ok,

        /// <summary>
        ///     <para>Verification fails checks for definitive reasons (e.g. mail box does not exist).</para>.
        /// </summary>
        Bad,

        /// <summary>
        ///     <para>Conclusive verification result cannot be achieved at this time. Please try again later.</para>
        /// </summary>
        RetryLater,

        /// <summary>
        /// <para>Conclusive verification result cannot be achieved due to mail server configuration or anti-spam measures.</para>
        /// </summary>
        Unverifiable
    }
}