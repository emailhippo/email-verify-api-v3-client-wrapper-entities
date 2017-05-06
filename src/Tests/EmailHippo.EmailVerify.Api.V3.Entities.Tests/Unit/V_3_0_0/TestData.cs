// <copyright file="TestData.cs" company="Email Hippo Ltd">
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
namespace EmailHippo.EmailVerify.Api.V3.Entities.Tests.Unit.V_3_0_0
{
    using System.Collections.Generic;
    using Entities.V_3_0_0;
    using Entities.V_3_0_0.DiagnosticInfo;
    using Entities.V_3_0_0.Dispositions;
    using Entities.V_3_0_0.DomainInfo;
    using Entities.V_3_0_0.EmailVerificationInfo;
    using Entities.V_3_0_0.InfrastructureInfo;
    using Entities.V_3_0_0.InfrastructureInfo.Mail;
    using Entities.V_3_0_0.InfrastructureInfo.Web;
    using Entities.V_3_0_0.MailSend;
    using Entities.V_3_0_0.MetaInfo;
    using Entities.V_3_0_0.Net;
    using Entities.V_3_0_0.PerformanceInfo;
    using Entities.V_3_0_0.SocialInfo;
    using Entities.V_3_0_0.SpamData;
    using Entities.V_3_0_0.SpamTrapData;
    using Entities.V_3_0_0.Statuses;
    using Entities.V_3_0_0.Trust;
    using Entities.V_3_0_0.VersionInfo;

    public static class TestData
    {
        public static Result FullResult
        {
            get
            {
                var result = new Result
                {
                    Version = new Version { Doc = @"https://docs.emh360.com/v1", V = @"1.0.0" },
                    Performance = new Performance(),
                    Disposition = new Disposition(),
                    Domain = new Domain(),
                    EmailVerification = new EmailVerification
                    {
                        DnsVerification = new DnsVerification
                        {
                            RecordRoot = new Record { IpAddresses = new List<string> { "158.152.1.65", "158.152.1.66" } },
                            RecordWww = new Record { IpAddresses = new List<string> { @"158.152.3.65", @"158.152.3.66" } },
                            MxRecords = new List<MxRecord> { new MxRecord { Exchange = @"me@here.com", IpAddresses = new List<string> { @"158.152.2.65", "158.152.2.65" } } },
                            TxtRecords = new List<string> { @"google-site-verification=fO3cFvVBzySeQPOWc_QEwg6mzZFS5muntoHN4jvH5fQ", @"v=spf1 include:_spf.google.com include:authsmtp.com include:email.freshdesk.com include:aweber.com ~all" },
                            IsDomainHasDnsRecord = true,
                            IsDomainHasMxRecords = true
                        },
                        MailboxVerification = new MailboxVerification(),
                        SyntaxVerification = new SyntaxVerification()
                    },
                    Infrastructure = new Infrastructure
                    {
                        Mail = new MailInfrastructure(),
                        Web = new WebInfrastructure
                        {
                            HasAliveWebServer = true
                        }
                    },
                    Meta = new Meta(),
                    SpamAssess = new SpamAssess { BlockLists = new List<BlockList>() },
                    SpamTrapAssess = new SpamTrapAssess(),
                    SendAssess = new SendAssess(),
                    Social = new Social { Gravatar = new Gravatar { ImageUrl = @"//www.gravatar.com/avatar/6dd6117aab13c8e89993baf198c504ea", ProfileUrl = @"//www.gravatar.com/6dd6117aab13c8e89993baf198c504ea" } },
                    HippoTrust = new HippoTrust(),
                    Diagnostic = new Diagnostic { Key = @"81C30915-E521-4AE1-9D4F-5DE2C7B07314" }
                };

                result.Meta.Domain = "hotmail.com";
                result.Meta.Email = "user@hotmail.com";
                result.Meta.User = @"user";
                result.Meta.Tld = @"com";
                result.Meta.LastModified = @"Sat, 26 Nov 2016 09:53:48 GMT";
                result.Meta.Expires = @"Sat, 26 Nov 2016 10:53:48 GMT";

                result.Disposition.IsRole = false;
                result.Disposition.IsFreeMail = true;

                result.EmailVerification.DnsVerification.IsDomainHasDnsRecord = true;
                result.EmailVerification.DnsVerification.IsDomainHasMxRecords = true;

                result.EmailVerification.SyntaxVerification.IsSyntaxValid = true;
                result.EmailVerification.SyntaxVerification.Reason = SyntaxVerificationReason.Success;

                result.EmailVerification.MailboxVerification.AdditionalStatus = AdditionalStatus.Success;
                result.EmailVerification.MailboxVerification.Status = Status.Ok;

                result.SendAssess.InboxQualityScore = 8.2;
                result.SendAssess.SendRecommendation = SendAssessType.SafeToSend;

                result.Infrastructure.Mail.MailInfrastructureServiceType = MailInfrastructureServiceType.Hotmail;
                result.Infrastructure.Mail.MailServerLocation = @"US";

                result.SpamAssess.BlockLists.Add(new BlockList { Name = @"spamhaus", IsListed = false, ListedReason = string.Empty, ListedMoreInfo = @"https://www.spamhaus.org/query/domain/jswfdb48z.com" });
                result.SpamAssess.DomainRiskScore = 2.5;
                result.SpamAssess.FormatRiskScore = 0;
                result.SpamAssess.IsDarkWebEmailAddress = false;
                result.SpamAssess.IsDisposableEmailAddress = false;
                result.SpamAssess.ProfanityRiskScore = 0.0;
                result.SpamAssess.OverallRiskScore = 2.5;
                result.SpamAssess.ActionRecomendation = SpamDataAssessType.Allow;

                result.SpamTrapAssess.IsSpamTrap = true;
                result.SpamTrapAssess.SpamTrapDescriptor = @"blackhole.mx";

                result.HippoTrust.Score = 6.5;
                result.HippoTrust.Level = TrustLevelType.Medium;

                result.Performance.DnsLookup = 110;
                result.Performance.MailboxVerification = 2200;
                result.Performance.Other = 50;
                result.Performance.SpamAssessment = 20;
                result.Performance.SyntaxCheck = 5;
                result.Performance.OverallExecutionTime = 2385;

                result.Disposition.IsFreeMail = false;

                return result;
            }
        }
    }
}