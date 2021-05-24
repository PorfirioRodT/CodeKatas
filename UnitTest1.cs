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

        }*/

        [Test]
        public void TheListOfWordsIsEmpty()
        {

            FileReader fileReader = new FileReader();
            
            string[] expectedWords = new string[] { };        
            string[] arrayFromFile = fileReader.GettingArray();

            Assert.AreEqual(arrayFromFile, expectedWords);     

        }

        [Test]
        public void TheFileReturnsTheArrays()
        {

            FileReader fileReader = new FileReader("C:/Users/el-co/OneDrive/Escritorio/Tendencia/pruebas.txt");
            
            string[] expectedWords = new string[] { "maria", "cret", "pasame", "jugo", "pedro", "juan", "pedro", 
                                                    "michael", "nuaj", "corazon", "drope", "arima" };        
            string[] arrayFromFile = fileReader.GettingArray();

            Assert.AreEqual(arrayFromFile, expectedWords);  

        }

        [Test]
        public void HashIsWOrking(){

            HashValues hash = new HashValues();

            Dictionary<string, List<string>> isDictionary = new Dictionary<string, List<string>>();

            //Assert.That(()=> hash.hashAnagrams, Is.True);
            Assert.AreEqual(hash.hashAnagrams, isDictionary);

        } 

    }
}