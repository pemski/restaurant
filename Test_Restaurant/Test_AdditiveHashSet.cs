using System;
using NUnit.Framework;
using Restaurant;

namespace Test_Restaurant
{
    [TestFixture]
    public class Test_AdditiveHashSet
    {
        private AdditiveCollection collection;

        [SetUp]
        public void CreateCollection()
        {
            collection = new AdditiveHashSet();
        }


        [Test]
        public void Test_Add()
        {
            collection.Add(new Salami());
            Assert.True(collection.GetLength() == 1);
        }

        [Test]
        public void Test_AddSameObjectMultiply()
        {
            var product = new Salami();
            collection.Add(product);
            collection.Add(product);
            Assert.True(collection.GetLength() == 1);
        }


        [Test]
        public void Test_AddSameProductMultiply()
        {
            var prod1 = new Salami();
            var prod2 = new Salami();
            collection.Add(prod1);
            collection.Add(prod2);
            Assert.True(collection.GetLength() == 1, String.Format("Collection length: {0}.", collection.GetLength()));
        }


        [Test]
        public void Test_RemoveSameObject()
        {
            var prod = new Salami();
            collection.Add(prod);
            collection.Remove(prod);
            Assert.AreEqual(0, collection.GetLength());
        }


        [Test]
        public void Test_RemoveSameProduct()
        {
            collection.Add(new Salami());
            collection.Remove(new Salami());
            Assert.AreEqual(0, collection.GetLength());
        }
    }
}
