using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;


namespace TestAnagrams
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AreAnagramas()
        {

            CheckAnagrams anagrams = new CheckAnagrams();          

            Assert.That(() => anagrams.AreAnagrams("Juan", "nuja"), Is.True);

        }

        [Test]
        public void AreNotAnagramas()
        {

            CheckAnagrams anagrams = new CheckAnagrams();

            Assert.That(() => anagrams.AreAnagrams("Juan", "pedro"), Is.False /* Throws.Nothing*/);

        }

        [Test]
        public void TheListOfWordsIsEmpy()
        {

            CheckAnagrams anagrams = new CheckAnagrams();

            Assert.That(() => anagrams.AreAnagrams(null), Throws.ArgumentNullException);

        }

    }
}