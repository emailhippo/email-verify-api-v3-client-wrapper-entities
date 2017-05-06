// <copyright file="TestBase.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.Tests
{
    using System;
    using System.Diagnostics.Contracts;
    using JetBrains.Annotations;
    using Xunit.Abstractions;

    /// <summary>
    /// The Test Base.
    /// </summary>
    public abstract class TestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        /// <param name="outHelper">The out helper.</param>
        protected TestBase([NotNull] ITestOutputHelper outHelper)
        {
            Contract.Requires(outHelper != null);

            this.OutHelper = outHelper;
        }

        /// <summary>
        /// Gets the out helper.
        /// </summary>
        /// <value>
        /// The out helper.
        /// </value>
        protected ITestOutputHelper OutHelper { get; }

        /// <summary>
        /// The write time elapsed.
        /// </summary>
        /// <param name="timerElapsed">
        /// The timer elapsed.
        /// </param>
        protected void WriteTimeElapsed(long timerElapsed)
        {
            this.OutHelper.WriteLine($"Elapsed timer: {timerElapsed}ms");
        }

        /// <summary>
        /// The write time elapsed.
        /// </summary>
        /// <param name="timerElapsed">
        /// The timer elapsed.
        /// </param>
        protected void WriteTimeElapsed(TimeSpan timerElapsed)
        {
            this.OutHelper.WriteLine($"Elapsed timer: {timerElapsed}");
        }
    }
}