// <copyright file="DefaultClientTests.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.Tests.Integration.Logic.Clients.EmailHippo.V3
{
    using System.Diagnostics.Contracts;
    using JetBrains.Annotations;
    using Xunit.Abstractions;

    /// <summary>
    /// Default Client Tests
    /// </summary>
    public sealed class DefaultClientTests : TestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultClientTests"/> class.
        /// </summary>
        /// <param name="outHelper">The out helper.</param>
        public DefaultClientTests([NotNull] ITestOutputHelper outHelper)
            : base(outHelper)
        {
            Contract.Requires(outHelper != null);
        }
    }
}