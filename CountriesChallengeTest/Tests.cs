using RestCountriesChallenge.Services;

namespace CountriesChallengeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ApiIsWorking()
        {
            CountriesService service = new CountriesService();
            var result = service.GetCountryData("Brazil");

            if (result != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}