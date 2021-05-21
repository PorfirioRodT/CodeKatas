using System;
using System.IO;
using System.Collections.Generic;

namespace TestAnagrams
{
    public class FileReader
    {

        public GetFile(string path){

            if (!File.Exists(path))
            {

                throw new FileNotFoundException();
                
            }else
            {
                
                StreamReader streamReader = new StreamReader(path);
                string line;
                List<string> fileList = new List<string>();

                while ((line = streamReader.ReadLine()) != null){

                    fileList.Add(line);
                    
                }

                this.ConvertingToArray = fileList.ToArray();

            }

        }

        private string[] ConvertingToArray = null;

        public GetFile(){

            ConvertingToArray = new string[]{ };

        }
        public string[] GetArray(){

            return this.ConvertingToArray;

        }

    }
}