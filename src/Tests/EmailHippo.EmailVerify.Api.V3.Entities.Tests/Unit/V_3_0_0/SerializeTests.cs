// <copyright file="SerializeTests.cs" company="Email Hippo Ltd">
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
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Runtime.Serialization;
    using Entities.V_3_0_0;
    using JetBrains.Annotations;
    using Newtonsoft.Json;
    using ProtoBuf;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// The serializer tests.
    /// </summary>
    /// <seealso cref="TestBase" />
    public class SerializeTests : TestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializeTests"/> class.
        /// </summary>
        /// <param name="outHelper">The out helper.</param>
        public SerializeTests([NotNull] ITestOutputHelper outHelper)
            : base(outHelper)
        {
            Contract.Requires(outHelper != null);
        }

        /// <summary>
        /// Serializes to json when hotmail full result expect serialize.
        /// </summary>
        [Fact]
        public void SerializeToJson_WhenHotmailFullResult_ExpectSerialize()
        {
            // arrange
            var fullResult = TestData.FullResult;

            // act
            var stopwatch = Stopwatch.StartNew();
            var serializeObject = JsonConvert.SerializeObject(fullResult);
            stopwatch.Stop();

            // assert
            const string expectedResult = @"{""version"":{""v"":""1.0.0"",""doc"":""https://docs.emh360.com/v1""},""meta"":{""lastModified"":""Sat, 26 Nov 2016 09:53:48 GMT"",""expires"":""Sat, 26 Nov 2016 10:53:48 GMT"",""email"":""user@hotmail.com"",""tld"":""com"",""domain"":""hotmail.com"",""subDomain"":null,""user"":""user"",""emailHashMd5"":null,""emailHashSha1"":null,""emailHashSha256"":null},""disposition"":{""isRole"":false,""isFreeMail"":false},""emailVerification"":{""syntaxVerification"":{""isSyntaxValid"":true,""reason"":""Success""},""dnsVerification"":{""isDomainHasDnsRecord"":true,""isDomainHasMxRecords"":true,""recordRoot"":{""ipAddresses"":[""158.152.1.65"",""158.152.1.66""]},""recordWww"":{""ipAddresses"":[""158.152.3.65"",""158.152.3.66""]},""mxRecords"":[{""preference"":0,""exchange"":""me@here.com"",""ipAddresses"":[""158.152.2.65"",""158.152.2.65""]}],""txtRecords"":[""google-site-verification=fO3cFvVBzySeQPOWc_QEwg6mzZFS5muntoHN4jvH5fQ"",""v=spf1 include:_spf.google.com include:authsmtp.com include:email.freshdesk.com include:aweber.com ~all""]},""mailboxVerification"":{""result"":""Ok"",""reason"":""Success""}},""infrastructure"":{""mail"":{""serviceTypeId"":""Hotmail"",""mailServerLocation"":""US"",""smtpBanner"":null},""web"":{""hasAliveWebServer"":true}},""sendAssess"":{""inboxQualityScore"":8.2,""sendRecommendation"":""SafeToSend""},""spamAssess"":{""isDisposableEmailAddress"":false,""isDarkWebEmailAddress"":false,""isGibberishDomain"":false,""isGibberishUser"":false,""domainRiskScore"":2.5,""formatRiskScore"":0.0,""profanityRiskScore"":0.0,""overallRiskScore"":2.5,""actionRecomendation"":""Allow"",""blockLists"":[{""blockListName"":""spamhaus"",""isListed"":false,""listedReason"":"""",""listedMoreInfo"":""https://www.spamhaus.org/query/domain/jswfdb48z.com""}]},""spamTrapAssess"":{""isSpamTrap"":true,""spamTrapDescriptor"":""blackhole.mx""},""hippoTrust"":{""score"":6.5,""level"":""Medium""},""social"":{""gravatar"":{""imageUrl"":""//www.gravatar.com/avatar/6dd6117aab13c8e89993baf198c504ea"",""profileUrl"":""//www.gravatar.com/6dd6117aab13c8e89993baf198c504ea""}},""domain"":{""recordFound"":false,""domainName"":null,""tld"":null,""domainOwnerContact"":null,""adminContact"":null,""billingContact"":null,""techContact"":null,""registrarContact"":null,""created"":null,""changed"":null,""expiry"":null,""domainAgeDays"":null},""performance"":{""syntaxCheck"":5,""dnsLookup"":110,""spamAssessment"":20,""mailboxVerification"":2200,""webInfrastructurePing"":0,""other"":50,""overallExecutionTime"":2385},""diagnostic"":{""key"":""81C30915-E521-4AE1-9D4F-5DE2C7B07314""}}";

            this.OutHelper.WriteLine(serializeObject);
            this.OutHelper.WriteLine("Length:{0}", serializeObject.Length);
            Assert.Equal(expectedResult, serializeObject);
            this.WriteTimeElapsed(stopwatch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Serializes to XML when hotmail full result expect serialize.
        /// </summary>
        [Fact]
        public void SerializeToXml_WhenHotmailFullResult_ExpectSerialize()
        {
            // arrange
            var fullResult = TestData.FullResult;

            var dataContractSerializer = new DataContractSerializer(typeof(Result));

            string s;

            // act
            var stopwatch = Stopwatch.StartNew();
            using (var ms = new MemoryStream())
            {
                dataContractSerializer.WriteObject(ms, fullResult);

                ms.Position = 0;

                s = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            }

            stopwatch.Stop();

            // assert
            const string expectedResult = @"<Result xmlns=""http://emh.ev/2017/api/v3"" xmlns:i=""http://www.w3.org/2001/XMLSchema-instance""><Version><V>1.0.0</V><Doc>https://docs.emh360.com/v1</Doc></Version><Meta><LastModified>Sat, 26 Nov 2016 09:53:48 GMT</LastModified><Expires>Sat, 26 Nov 2016 10:53:48 GMT</Expires><Email>user@hotmail.com</Email><Tld>com</Tld><Domain>hotmail.com</Domain><SubDomain i:nil=""true""/><User>user</User><EmailAddessHashMd5 i:nil=""true""/><EmailAddressHashSha1 i:nil=""true""/><EmailAddressHashSha256 i:nil=""true""/></Meta><Disposition><IsRole>false</IsRole><IsFreeMail>false</IsFreeMail></Disposition><EmailVerification><SyntaxVerification><IsSyntaxValid>true</IsSyntaxValid><Reason>Success</Reason></SyntaxVerification><DnsVerification><IsDomainHasDnsRecord>true</IsDomainHasDnsRecord><IsDomainHasMxRecords>true</IsDomainHasMxRecords><RecordRoot><IpAddresses xmlns:a=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><a:string>158.152.1.65</a:string><a:string>158.152.1.66</a:string></IpAddresses></RecordRoot><RecordWww><IpAddresses xmlns:a=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><a:string>158.152.3.65</a:string><a:string>158.152.3.66</a:string></IpAddresses></RecordWww><MxRecords><MxRecord><Preference>0</Preference><Exchange>me@here.com</Exchange><IpAddresses xmlns:a=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><a:string>158.152.2.65</a:string><a:string>158.152.2.65</a:string></IpAddresses></MxRecord></MxRecords><TxtRecords xmlns:a=""http://schemas.microsoft.com/2003/10/Serialization/Arrays""><a:string>google-site-verification=fO3cFvVBzySeQPOWc_QEwg6mzZFS5muntoHN4jvH5fQ</a:string><a:string>v=spf1 include:_spf.google.com include:authsmtp.com include:email.freshdesk.com include:aweber.com ~all</a:string></TxtRecords></DnsVerification><MailboxVerification><Status>Ok</Status><AdditionalStatus>Success</AdditionalStatus></MailboxVerification></EmailVerification><Infrastructure><Mail><MailInfrastructureServiceType>Hotmail</MailInfrastructureServiceType><MailServerLocation>US</MailServerLocation><SmtpBanner i:nil=""true""/></Mail><Web><HasAliveWebServer>true</HasAliveWebServer></Web></Infrastructure><SendAssess><InboxQualityScore>8.2</InboxQualityScore><SendRecommendation>SafeToSend</SendRecommendation></SendAssess><SpamAssess><IsDisposableEmailAddress>false</IsDisposableEmailAddress><IsDarkWebEmailAddress>false</IsDarkWebEmailAddress><IsGibberishDomain>false</IsGibberishDomain><IsGibberishUser>false</IsGibberishUser><DomainRiskScore>2.5</DomainRiskScore><FormatRiskScore>0</FormatRiskScore><ProfanityRiskScore>0</ProfanityRiskScore><OverallRiskScore>2.5</OverallRiskScore><ActionRecomendation>Allow</ActionRecomendation><BlockLists><BlockList><Name>spamhaus</Name><IsListed>false</IsListed><ListedReason/><ListedMoreInfo>https://www.spamhaus.org/query/domain/jswfdb48z.com</ListedMoreInfo></BlockList></BlockLists></SpamAssess><SpamTrapAssess><IsSpamTrap>true</IsSpamTrap><SpamTrapDescriptor>blackhole.mx</SpamTrapDescriptor></SpamTrapAssess><HippoTrust><Score>6.5</Score><Level>Medium</Level></HippoTrust><Social><Gravatar><ImageUrl>//www.gravatar.com/avatar/6dd6117aab13c8e89993baf198c504ea</ImageUrl><ProfileUrl>//www.gravatar.com/6dd6117aab13c8e89993baf198c504ea</ProfileUrl></Gravatar></Social><Domain><RecordFound>false</RecordFound><DomainName i:nil=""true""/><Tld i:nil=""true""/><DomainOwnerContact i:nil=""true""/><AdminContact i:nil=""true""/><BillingContact i:nil=""true""/><TechContact i:nil=""true""/><RegistrarContact i:nil=""true""/><Created i:nil=""true""/><Changed i:nil=""true""/><Expiry i:nil=""true""/><DomainAgeDays i:nil=""true""/></Domain><Performance><SyntaxCheck>5</SyntaxCheck><DnsLookup>110</DnsLookup><SpamAssessment>20</SpamAssessment><MailboxVerification>2200</MailboxVerification><WebInfrastructurePing>0</WebInfrastructurePing><Other>50</Other><OverallExecutionTime>2385</OverallExecutionTime></Performance><Diagnostic><Key>81C30915-E521-4AE1-9D4F-5DE2C7B07314</Key></Diagnostic></Result>";

            this.OutHelper.WriteLine(s);
            this.OutHelper.WriteLine("Length:{0}", s.Length);
            Assert.Equal(expectedResult, s);
            this.WriteTimeElapsed(stopwatch.ElapsedMilliseconds);
        }

        /// <summary>
        /// Serializes to protobuf when hotmail full result expect serialize and deserialize.
        /// </summary>
        [Fact]
        public void SerializeToProtobuf_WhenHotmailFullResult_ExpectSerializeAndDeserialize()
        {
            // arrange
            var fullResult = TestData.FullResult;

            string s;

            // act
            var stopwatch = Stopwatch.StartNew();
            using (var ms = new MemoryStream())
            {
                Serializer.Serialize(ms, fullResult);
                ms.Position = 0;

                ms.TryGetBuffer(out ArraySegment<byte> buffer);

                s = Convert.ToBase64String(buffer.Array, 0, (int)ms.Length);
            }

            Result deserialized;

            var bytes = Convert.FromBase64String(s);

            /*using (var ms = new MemoryStream(ser))*/
            using (var ms = new MemoryStream(bytes))
            {
                ms.Position = 0;

                deserialized = Serializer.Deserialize<Result>(ms);
            }

            stopwatch.Stop();

            // assert
            const string expectedResult = @"CiMKBTEuMC4wEhpodHRwczovL2RvY3MuZW1oMzYwLmNvbS92MRJoCh1TYXQsIDI2IE5vdiAyMDE2IDA5OjUzOjQ4IEdNVBIdU2F0LCAyNiBOb3YgMjAxNiAxMDo1Mzo0OCBHTVQaEHVzZXJAaG90bWFpbC5jb20iA2NvbSoLaG90bWFpbC5jb206BHVzZXIaACKpAgoECAEQChKaAggBEAEaHAoMMTU4LjE1Mi4xLjY1CgwxNTguMTUyLjEuNjYiHAoMMTU4LjE1Mi4zLjY1CgwxNTguMTUyLjMuNjYqKRILbWVAaGVyZS5jb20aDDE1OC4xNTIuMi42NRoMMTU4LjE1Mi4yLjY1MkRnb29nbGUtc2l0ZS12ZXJpZmljYXRpb249Zk8zY0Z2VkJ6eVNlUVBPV2NfUUV3ZzZtelpGUzVtdW50b0hONGp2SDVmUTJndj1zcGYxIGluY2x1ZGU6X3NwZi5nb29nbGUuY29tIGluY2x1ZGU6YXV0aHNtdHAuY29tIGluY2x1ZGU6ZW1haWwuZnJlc2hkZXNrLmNvbSBpbmNsdWRlOmF3ZWJlci5jb20gfmFsbBoECAEQCyoMCgYIAhICVVMSAggBMgsJZmZmZmZmIEAQATpXKQAAAAAAAARAQQAAAAAAAARASAFSQQoIc3BhbWhhdXMaACIzaHR0cHM6Ly93d3cuc3BhbWhhdXMub3JnL3F1ZXJ5L2RvbWFpbi9qc3dmZGI0OHouY29tQhAIARIMYmxhY2tob2xlLm14SgsJAAAAAAAAGkAQAlJzCnEKOi8vd3d3LmdyYXZhdGFyLmNvbS9hdmF0YXIvNmRkNjExN2FhYjEzYzhlODk5OTNiYWYxOThjNTA0ZWESMy8vd3d3LmdyYXZhdGFyLmNvbS82ZGQ2MTE3YWFiMTNjOGU4OTk5M2JhZjE5OGM1MDRlYVoAYg4IBRBuGBQgmBEwMjjREmomCiQ4MUMzMDkxNS1FNTIxLTRBRTEtOUQ0Ri01REUyQzdCMDczMTQ=";

            this.OutHelper.WriteLine(s);
            this.OutHelper.WriteLine("Length:{0}", s.Length);
            Assert.Equal(expectedResult, s);
            Assert.True(deserialized.Meta.Domain == @"hotmail.com");
            this.WriteTimeElapsed(stopwatch.ElapsedMilliseconds);
        }
    }
}
