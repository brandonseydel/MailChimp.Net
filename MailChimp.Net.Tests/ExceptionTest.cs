using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using Xunit;

namespace MailChimp.Net.Tests;

public class ExceptionTest : MailChimpTest
{
    [Fact]
    public void Should_Return_Same_Data_On_Multiple_Calls()
    {
        var exception = new MailChimpException(new MailChimpApiError(), new HttpResponseMessage());

        var data1 = exception.Data;
        var data2 = exception.Data;

        Assert.Equal(data1, data2);
    }
}