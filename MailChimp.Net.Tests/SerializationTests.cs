using System.Linq;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
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

    /// <summary>
    /// Member tags come back from the API as full objects and must deserialize.
    /// </summary>
    [Fact]
    public void MemberTagsShouldDeserializeFromTagObjects()
    {
        var json = """
                   {
                     "id": "abc123",
                     "email_address": "test@example.com",
                     "tags_count": 2,
                     "tags": [
                       { "id": 1, "name": "First", "date_added": "2024-01-02T03:04:05+00:00" },
                       { "id": 2, "name": "Second" }
                     ]
                   }
                   """;
        var member = MailChimpSerializer.Deserialize<Member>(json);

        Assert.Equal(["First", "Second"], member.Tags.Select(x => x.Name));
        Assert.Equal([1, 2], member.Tags.Select(x => x.Id));
    }

    /// <summary>
    /// Member tags also deserialize from the simple string array form used on PUT/POST.
    /// </summary>
    [Fact]
    public void MemberTagsShouldDeserializeFromStringArray()
    {
        var json = """{ "tags": [ "First", "Second" ] }""";
        var member = MailChimpSerializer.Deserialize<Member>(json);

        Assert.Equal(["First", "Second"], member.Tags.Select(x => x.Name));
    }

    /// <summary>
    /// A null tag list stays null rather than throwing.
    /// </summary>
    [Fact]
    public void MemberTagsShouldDeserializeNull()
    {
        var json = """{ "tags": null }""";
        var member = MailChimpSerializer.Deserialize<Member>(json);

        Assert.Null(member.Tags);
    }

    /// <summary>
    /// Member tags are still serialized as a simple array of names for PUT/POST requests.
    /// </summary>
    [Fact]
    public void MemberTagsShouldSerializeAsStringArray()
    {
        var member = new Member
        {
            Tags = [new MemberTag { Id = 1, Name = "First" }, new MemberTag { Id = 2, Name = "Second" }]
        };
        var json = MailChimpSerializer.Serialize(member);

        Assert.Contains("\"tags\":[\"First\",\"Second\"]", json);
    }

    public class EnumTest
    {
        [MailChimpJsonConverter(MailChimpJsonConverterKind.StringEnumDescription)]
        public CampaignType CampaignType { get; set; }
    }
}
