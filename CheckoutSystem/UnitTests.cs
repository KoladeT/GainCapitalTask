using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckoutSystem
{
    [TestFixture]
    public class UnitTests : Program
    {
        [Test]
        public void ValidTotalCostTest()
        {
            Assert.AreEqual(0.85,TotalCost(1,1),"Expected total cost 0.85 is not equal to actual total cost "+ TotalCost(1,1));
        }
        
        [Test]
        public void InvalidTotalCostTest()
        {
            Assert.AreNotEqual(2.85, TotalCost(1, 1), "Expected total cost 2.85 is not equal to actual total cost " + TotalCost(1, 1));
        }

        [Test]
        public void NegativeEntryCostTest()
        {
            Assert.AreEqual(0.0, TotalCost(-1, -1));
        }
    }
}
