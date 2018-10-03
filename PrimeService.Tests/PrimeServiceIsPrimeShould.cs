using Xunit;

namespace PrimeService.Tests
{
    public class PrimeServiceIsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeServiceIsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }

}
