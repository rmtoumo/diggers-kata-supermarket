using System;
using System.IO;
using Supermarket.Products;
using Xunit;

namespace Supermarket.Tests
{
    public class Step3
    {
        private Truffle _Truffle;

        public Step3()
        {
            _Truffle = new Truffle();
        }

        [Fact]
        public void Truffle_ShouldStartWith30Quantity()
        {
            Assert.Equal(30, _Truffle.Quantity);
        }

        [Fact]
        public void Truffle_ShouldCost30()
        {
            Assert.Equal(30, _Truffle.Price);
        }

        [Fact]
        public void Truffle_ShouldAlert_When_QuantityEquals0()
        {
            using (var sw = new StringWriter())
            {
                // Cet appel permet au StringWriter de lire ce qui a été écrit dans la Console
                Console.SetOut(sw);

                _Truffle.Quantity = 0;

                Assert.Equal("No more truffles available!!!", sw.ToString());
            }
        }
    }
}
