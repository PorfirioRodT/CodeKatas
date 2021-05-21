using System.Collections;
using System;
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

        /*[Test]
        public void AreAnagramas()
        {

            CheckAnagrams anagrams = new CheckAnagrams();     

            //ArrayList anagramsTest = new ArrayList(); 

            //anagramsTest.Add("hola");
            //anagramsTest.Add("loha");  
            //anagramsTest.Add("loah");  
            //anagramsTest.Add("hoal");     

            Assert.That(() => anagrams.AreAnagrams("Juan", "nuja"), Is.True);

        }

        [Test]
        public void AreNotAnagramas()
        {

            CheckAnagrams anagrams = new CheckAnagrams();

            Assert.That(() => anagrams.AreAnagrams("Juan", "pedro"), Is.False /* Throws.Nothing);

        }

        [Test]
        public void TheListOfWordsIsEmpy()
        {

            CheckAnagrams anagrams = new CheckAnagrams();

            Assert.That(() => anagrams.AreAnagrams(null), Throws.ArgumentNullException);

        }*/

        [Test]
        public void TheListOfWordsIsEmpty()
        {

            string[] expectedWords = new string[] { };
            FileReader fileReader = new FileReader();
            string[] arrayFromFile = fileReader.GettingArray();
            Assert.AreEqual(arrayFromFile, expectedWords);     

        }

    }
}