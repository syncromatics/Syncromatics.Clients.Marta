using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Syncromatics.Client.Marta.Api.Tests
{
    public class MartaApiClientTests
    {
        private readonly MartaApiClient _subject;

        public MartaApiClientTests()
        {
            var url = Environment.GetEnvironmentVariable("TEST_URL") ?? "http://developer.itsmarta.com";
            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            apiKey.Should().NotBeNull("you must specify an api key as environment variable 'API_KEY' to run these tests");

            var settings = new ClientSettings(url, apiKey);
            _subject = new MartaApiClient(settings);
        }

        [Fact]
        public async Task Can_request_train_arrivals()
        {
            var arrivals = await _subject.GetRealTimeTrainArrivalsAsync();

            arrivals.Should().NotBeNull();
            arrivals.Should().OnlyContain(arrival => arrival.EventTime != default(DateTime));
        }
    }
}
