using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_Inputis1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void IsPrime_Inputis0_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(0);
            Assert.False(result, "0 should not be prime");
        }

        [Fact]
        public void IsPrime_InputisNegative1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(-1);
            Assert.False(result, "-1 should not be prime");
        }
    }
}
