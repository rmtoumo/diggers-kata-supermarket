using System;
using System.IO;
using Supermarket.Products;
using Xunit;

namespace Supermarket.Tests
{
    public class Step1
    {
        private Apple _apple;

        public Step1()
        {
            _apple = new Apple();
        }

        [Fact]
        public void Apple_ShouldStartWith50Quantity()
        {
            Assert.Equal(50, _apple.Quantity);
        }

        [Fact]
        public void Apple_ShouldCost25()
        {
            Assert.Equal(25, _apple.Price);
        }

        [Fact]
        public void Apple_ShouldAlert_When_QuantityEquals0()
        {
            using (var sw = new StringWriter())
            {
                // Cet appel permet au StringWriter de lire ce qui a été écrit dans la Console
                Console.SetOut(sw);

                _apple.Quantity = 0;

                Assert.Equal("No more apples available!!!", sw.ToString());
            }
        }
    }
}
