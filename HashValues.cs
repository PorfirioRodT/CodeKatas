using System;
using System.Linq;
using System.Collections.Generic;

namespace TestAnagrams
{
    public class HashValues
    {

        //Usamos directorios para que funcionen mas rapido la lectura de los datos obtenidos del archivo
        public Dictionary<string, List<string>> hashWords = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> hashAnagrams = new Dictionary<string, List<string>>();

        public HashValues(){}

        //Creamos un metodo para ordenar los datos de los diccionarios
        public void SortDataFromDictionary(string[] data){

            //Hacemos un loop que itere los datos de los diccionarios
            for (int i = 0; i < data.Length; i++)
            {

                //llevamos a minusculas las letras de los dics para evitar cualquier problema al revisar el dic
                string word = data[i].ToLower();
                
                //Hacemos lo tipico como si buscariamos cualquier anagrama, hacer un sort del la list o del array
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                
                string lettersSorted = new string(letters);

                //Realizamos un condicional para probar de que las letras del dic estan siendo organizadas
                if (hashWords.ContainsKey(lettersSorted))
                {

                    //Creamos una condicional que nos dice que si el dic no tiene las letras organizadas nos agregue la palabra
                    if (!hashWords[lettersSorted].Contains(word))
                    {

                        hashWords[lettersSorted].Add(word);
                        
                    }

                    //Creamos una segunda condicional la cual trabajara con los anagramas en si
                    if (hashWords[lettersSorted].Count > 1)
                    {
                        //Aca si el condicional pasa nos esta diciendo que las palabras en el diccionario son anagramas
                        hashAnagrams[lettersSorted] = hashWords[lettersSorted];
                        
                    }
                    
                }
                else
                {

                    hashWords.Add(lettersSorted, new List<string>());
                    hashWords[lettersSorted].Add(word);

                }


            }

        }

        public HashValues(string[] dataFromDicctionary){

            //En este metodo vamos a utilizar el creaado para organizar los valores de los diccionarios
            SortDataFromDictionary(dataFromDicctionary);

        }

        

    }
}