// <copyright file="AdditionalStatus.cs" company="Email Hippo Ltd">
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
    ///     The additional status.
    /// </summary>
    public enum AdditionalStatus
    {
        /// <summary>
        ///     <para>No additional information is available.</para>
        /// </summary>
        None = 0,

        /// <summary>
        ///     <para>The required '@' sign is not found in email address.</para>
        /// </summary>
        AtSignNotFound,

        /// <summary>
        ///     <para>The domain (i.e. the bit after the '@' character) defined in the email address does not exist, according to DNS records.</para>
        /// </summary>
        /// <remarks>
        ///     <para>A domain that does not exist cannot have email boxes.</para>
        /// </remarks>
        DomainIsInexistent,

        /// <summary>
        ///     <para>The domain is a well known Disposable Email Address (DEA).</para>
        /// </summary>
        /// <remarks>
        /// <para>There are many services available that permit users to use a one-time only email address. Typically, these email addresses are used by individuals wishing to gain access to content or services requiring registration of email addresses but same individuals not wishing to divulge their true identities (e.g. permanent email addresses).</para>
        /// <para>DEA addresses should not be regarded as valid for email send purposes as it is unlikely that messages sent to DEA addresses will ever be read.</para>
        /// </remarks>
        DomainIsWellKnownDea,

        /// <summary>
        /// <para>Greylisting is in operation. It is not possible to validate email boxes in real-time where greylisting is in operation.</para>
        /// <para>For more information see <seealso cref="https://en.wikipedia.org/wiki/Greylisting"/>.</para>
        /// </summary>
        GreyListing,

        /// <summary>
        ///     <para>The mailbox is full.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Mailboxes that are full are unable to receive any further email messages until such time as the user empties the mail box or the system administrator grants extra storage quota.</para>
        ///     <para>Most full mailboxes usually indicate accounts that have been abandoned by users and will therefore never be looked at again.</para>
        ///     <para>We do not recommend sending emails to email addresses identified as 'full'.</para>
        /// </remarks>
        MailboxFull,

        /// <summary>
        ///     <para>The mailbox does not exist.</para>
        /// </summary>
        /// <remarks>
        ///     <para>100% confidence that the mail box does not exist.</para>
        /// </remarks>
        MailboxDoesNotExist,

        /// <summary>
        /// <para>
        /// Unspecified mail server fault detected
        /// </para>
        /// <remarks>
        /// <para>An unspecified mail server fault was detected.</para>
        /// </remarks>
        /// </summary>
        MailServerFaultDetected,

        /// <summary>
        ///     <para>There are no mail servers defined for this domain, according to DNS.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Email addresses cannot be valid if there are no email servers defined in DNS for the domain.</para>
        /// </remarks>
        NoMxServersFound,

        /// <summary>
        ///     <para>The server does not support international mailboxes.</para>
        /// </summary>
        /// <remarks>
        ///     <para>International email boxes are those that use intentalional character sets such as Chinese / Kanji etc.</para>
        ///     <para>International email boxes require systems in place for Punycode translation.</para>
        ///     <para>Where these systems are not in place, email verification or delivery is not possible.</para>
        /// </remarks>
        /// <seealso cref="https://en.wikipedia.org/wiki/Punycode"/>
        ServerDoesNotSupportInternationalMailboxes,

        /// <summary>
        ///     <para>The server is configured for catch all and responds to all email verifications with a status of Ok.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Mail servers can be configured with a policy known as Catch All. Catch all redirects any email address sent to a particular domain to a central email box for manual inspection. Catch all configured servers cannot respond to requests for email address verification.</para>
        /// </remarks>
        ServerIsCatchAll,

        /// <summary>
        ///     <para>Successful verification.</para>
        /// </summary>
        /// <remarks>
        ///     <para>100% confidence that the mail box exists.</para>
        /// </remarks>
        Success,

        /// <summary>
        ///     <para>Too many '@' signs found in email address.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Only one '@' character is allowed in email addresses.</para>
        /// </remarks>
        TooManyAtSignsFound,

        /// <summary>
        ///     <para>The reason for the verification result is unknown.</para>
        /// </summary>
        Unknown,

        /// <summary>
        /// <para>Upredictable system infrastructure detected.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Various email services deliver unpredictable results to email address verification.</para>
        ///     <para>The reason for this unpredictability is that some email systems elect not to implement email standards (i.e. RFC 2821).</para>
        ///     <para>For systems that are known to be unpredictable, we return a secondary status of <see cref="UpredictableSystem"/>.</para>
        ///     <seealso cref="https://www.ietf.org/rfc/rfc2821.txt">RFC 2821</seealso>
        /// </remarks>
        UpredictableSystem,

        /// <summary>
        ///     <para>A temporary network fault occurred during verification. Please try again later.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Verification operations on remote mail servers can sometimes fail for a number of reasons such as loss of network connection, remote servers timing out etc.</para>
        ///     <para>These conditions are usually temporary. Retrying verification at a later time will usually result in a positive response from mail servers.</para>
        /// </remarks>
        TransientNetworkFault,

        /// <summary>
        ///     <para>A possible spam trap email address or domain has been detected.</para>
        /// </summary>
        /// <remarks>
        ///     <para>Spam traps are email addresses or domains deliberately placed online in order to capture and flag potential spam based operations.</para>
        ///     <para>Our advanced detection heuristics are capable of detecting likely spam trap addresses or domains known to be associated with spam trap techniques.</para>
        ///     <para>We do not recommend sending emails to addresses identified as associated with known spam trap behavior.</para>
        ///     <para>Sending emails to known spam traps or domains will result in your Email Service Provider (ESP) being subjected to email blocks from Reverse DNS Block Lists (RDNSBL)s.</para>
        ///     <para>ESPs cannot tolerate entries in RDNSBLs (as it adversely affects email deliverability for all customers) and will actively refuse to send emails on behalf of customers with a history of generating entries in RDSNBLs.</para>
        /// </remarks>
        PossibleSpamTrapDetected
    }
}