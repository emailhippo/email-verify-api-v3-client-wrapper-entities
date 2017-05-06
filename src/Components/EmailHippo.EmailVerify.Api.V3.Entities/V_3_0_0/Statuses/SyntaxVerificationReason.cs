// <copyright file="SyntaxVerificationReason.cs" company="Email Hippo Ltd">
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
    /// Syntax Verification Reason
    /// </summary>
    public enum SyntaxVerificationReason
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The '@' sign not found.
        /// </summary>
        AtSignNotFound,

        /// <summary>
        /// The domain part compliancy failure.
        /// </summary>
        DomainPartCompliancyFailure,

        /// <summary>
        /// The double dot sequence.
        /// </summary>
        DoubleDotSequence,

        /// <summary>
        /// The invalid address length.
        /// </summary>
        InvalidAddressLength,

        /// <summary>
        /// The invalid character in sequence.
        /// </summary>
        InvalidCharacterInSequence,

        /// <summary>
        /// The invalid empty quoted word.
        /// </summary>
        InvalidEmptyQuotedWord,

        /// <summary>
        /// The invalid folding white space sequence.
        /// </summary>
        InvalidFoldingWhiteSpaceSequence,

        /// <summary>
        /// The invalid local part length.
        /// </summary>
        InvalidLocalPartLength,

        /// <summary>
        /// The invalid word boundary start.
        /// </summary>
        InvalidWordBoundaryStart,

        /// <summary>
        /// The success
        /// </summary>
        Success,

        /// <summary>
        /// The too many '@' signs found.
        /// </summary>
        TooManyAtSignsFound,

        /// <summary>
        /// The unbalanced comment parenthesis.
        /// </summary>
        UnbalancedCommentParenthesis,

        /// <summary>
        /// The unexpected quoted pair sequence.
        /// </summary>
        UnexpectedQuotedPairSequence,

        /// <summary>
        /// The unknown.
        /// </summary>
        Unknown,

        /// <summary>
        /// The unmatched quoted pair.
        /// </summary>
        UnmatchedQuotedPair
    }
}