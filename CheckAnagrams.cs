using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TestAnagrams
{
    public class CheckAnagrams
    {

      public Dictionary<string, List<string>> anagrams;

      public string checkingWords = "";
      public int quantityOfSets = 0;
      public List<string> longestWords = new List<string>();
      public List<string> setWithMoreAnagrams = new List<string>();

      public CheckAnagrams(HashValues dictionary){

          anagrams = dictionary.hashAnagrams;

      }

      //Metodo para imprimir El set de anagramas con mas palabras, las cantidad palabras mas largas que son anagramas
      //la cantidad de sets de anagramas detectados, etc.
      public void PrintingAnagramsValues(TextWriter textWriter){

        foreach (var item in anagrams)
        {
            
            quantityOfSets++;

            textWriter.WriteLine(string.Join(", ", item.Value));

            if (item.Value.Count > setWithMoreAnagrams.Count)
            {

                setWithMoreAnagrams = item.Value;

            }

            //Creamos un condicional para verificar letra por letra cuales son las palabras mas largas
            if (item.Key.Length > checkingWords.Length)
            {

                checkingWords = item.Key;
                
            }        

        }

        longestWords = anagrams[checkingWords];

      }

    }
}
