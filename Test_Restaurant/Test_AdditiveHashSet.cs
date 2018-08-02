using System;
using NUnit.Framework;
using Restaurant;

namespace Test_Restaurant
{
    [TestFixture]
    public class Test_AdditiveHashSet
    {
        private IAdditiveCollection collection;

        [SetUp]
        public void CreateCollection()
        {
            collection = new AdditiveHashSet();
        }


        [Test]
        public void Test_Add()
        {
            collection.Add(new Additive());
            Assert.True(collection.GetLength() == 1);
        }

        [Test]
        public void Test_AddSameObjectMultiply()
        {
            var product = new Additive();
            collection.Add(product);
            collection.Add(product);
            Assert.True(collection.GetLength() == 1);
        }


        [Test]
        public void Test_AddSameProductMultiply()
        {
            var prod1 = new Additive();
            var prod2 = new Additive();
            collection.Add(prod1);
            collection.Add(prod2);
            Assert.True(collection.GetLength() == 1, String.Format("Collection length: {0}.", collection.GetLength()));
        }


        [Test]
        public void Test_RemoveSameObject()
        {
            var prod = new Additive();
            collection.Add(prod);
            collection.Remove(prod);
            Assert.AreEqual(0, collection.GetLength());
        }


        [Test]
        public void Test_RemoveSameProduct()
        {
            collection.Add(new Additive());
            collection.Remove(new Additive());
            Assert.AreEqual(0, collection.GetLength());
        }
    }
}
