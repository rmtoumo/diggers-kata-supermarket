using System;
using System.IO;
using Supermarket.Products;
using Xunit;

namespace Supermarket.Tests
{
    public class Step2
    {
        private Pasta _pasta;

        public Step2()
        {
            _pasta = new Pasta();
        }

        [Fact]
        public void Pasta_ShouldStartWith75Quantity()
        {
            Assert.Equal(75, _pasta.Quantity);
        }

        [Fact]
        public void Pasta_ShouldCost50()
        {
            Assert.Equal(50, _pasta.Price);
        }

        [Fact]
        public void Pasta_ShouldAlert_When_QuantityEquals0()
        {
            using (var sw = new StringWriter())
            {
                // Cet appel permet au StringWriter de lire ce qui a été écrit dans la Console
                Console.SetOut(sw);

                _pasta.Quantity = 0;

                Assert.Equal("No more pastas available!!!", sw.ToString());
            }
        }
    }
}
