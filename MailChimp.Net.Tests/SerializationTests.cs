using MailChimp.Net.Core;
using Newtonsoft.Json;
using Xunit;

namespace MailChimp.Net.Tests
{
    public class SerializationTests
    {
        /// <summary>
        /// Enum serialzation uses Json attributes.
        /// </summary>
        [Fact]
        public void EnumsShouldSerializeWithDescriptionAttributes()
        {
            var enumTest = new EnumTest { CampaignType = CampaignType.Plaintext };

            var json = JsonConvert.SerializeObject(enumTest);

            Assert.Contains("plaintext", json);
        }

        /// <summary>
        /// Enum deserialzation uses Json attributes.
        /// </summary>
        [Fact]
        public void EnumsShouldDeserializeWithDescriptionAttributes()
        {
            var json = "{ \"CampaignType\": \"plaintext\" }";

            var enumTest = JsonConvert.DeserializeObject<EnumTest>(json);

            Assert.Equal(CampaignType.Plaintext, enumTest.CampaignType);
        }

        /// <summary>
        /// Enum deserialzation uses Json attributes with "-" in description.
        /// </summary>
        [Fact]
        public void EnumsShouldDeserializeWithDescriptionAttributesWithHyphen()
        {
            var json = "{ \"CampaignType\": \"automation-email\" }";

            var enumTest = JsonConvert.DeserializeObject<EnumTest>(json);

            Assert.Equal(CampaignType.AutomationEmail, enumTest.CampaignType);
        }

        public class EnumTest
        {
            [JsonConverter(typeof(StringEnumDescriptionConverter))]
            public CampaignType CampaignType { get; set; }
        }
    }
}
