using System.Net.Mime;
using System.Diagnostics;
using System;
using System.IO;
using System.Collections.Generic;

namespace TestAnagrams
{
    public class Program
    {

        static void Main(string[] args){

            Stopwatch timeToGetAllAnagrams = new Stopwatch();
            timeToGetAllAnagrams.Start();

            FileReader fileReader = new FileReader(@"C:\Users\el-co\source\repos\TestAnagrams\TestAnagrams\wordlist.txt");
            HashValues hashValues = new HashValues(fileReader.GettingArray());
            CheckAnagrams checkAnagrams = new CheckAnagrams(hashValues);
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());

            Console.SetOut(textWriter);
            checkAnagrams.PrintingAnagramsValues(textWriter);
            timeToGetAllAnagrams.Stop();

            Console.WriteLine();
            Console.WriteLine("Tiempo total de ejecución: " + timeToGetAllAnagrams.Elapsed);
            Console.WriteLine("Palabras en el archivo: " + fileReader.GettingArray().Length);
            Console.WriteLine("Sets de anagramas en el archivo: " + checkAnagrams.quantityOfSets);
            Console.WriteLine("Set de anagramas que contiene mas palabras: " + string.Join(", ", checkAnagrams.setWithMoreAnagrams));
            Console.WriteLine("Set de anagramas que contiene las palabras mas largas: " + string.Join(", ", checkAnagrams.longestWords));
            textWriter.Flush();
            Console.ReadKey();

        }

    }
}