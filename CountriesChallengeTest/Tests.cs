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
        public void ApiIsWorkingByName()
        {
            CountriesService service = new CountriesService();
            var result = service.GetCountryDataByName("Brazil");

            if (result != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        public void ApiIsWorkingByCurrency()
        {
            CountriesService service = new CountriesService();
            var result = service.GetCountryDataByCurrency("BRL");

            if (result != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        public void ApiIsWorkingByCode()
        {
            CountriesService service = new CountriesService();
            var result = service.GetCountryDataByCode("BR");

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