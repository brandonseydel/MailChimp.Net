using MailChimp.Net.Core;
using Xunit;

namespace MailChimp.Net.Tests;

public class SerializationTests
{
    /// <summary>
    /// Enum serialization uses description attributes.
    /// </summary>
    [Fact]
    public void EnumsShouldSerializeWithDescriptionAttributes()
    {
        var enumTest = new EnumTest { CampaignType = CampaignType.Plaintext };

        var json = MailChimpSerializer.Serialize(enumTest);

        Assert.Contains("plaintext", json);
    }

    /// <summary>
    /// Enum deserialization uses description attributes.
    /// </summary>
    [Fact]
    public void EnumsShouldDeserializeWithDescriptionAttributes()
    {
        var json = "{ \"CampaignType\": \"plaintext\" }";

        var enumTest = MailChimpSerializer.Deserialize<EnumTest>(json);

        Assert.Equal(CampaignType.Plaintext, enumTest.CampaignType);
    }

    /// <summary>
    /// Enum deserialization uses description attributes with "-" in description.
    /// </summary>
    [Fact]
    public void EnumsShouldDeserializeWithDescriptionAttributesWithHyphen()
    {
        var json = "{ \"CampaignType\": \"automation-email\" }";

        var enumTest = MailChimpSerializer.Deserialize<EnumTest>(json);

        Assert.Equal(CampaignType.AutomationEmail, enumTest.CampaignType);
    }

    public class EnumTest
    {
        [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
        public CampaignType CampaignType { get; set; }
    }
}
