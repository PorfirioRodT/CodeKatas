using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TestAnagrams
{
    public class CheckAnagrams
    {

        public IEnumerable<string> GetFilePath(string path)
        {

            return File.ReadAllLines(path).GroupBy(x => string.Concat(x.OrderBy(i => i))).Where(x => x.Count() > 1)
                       .Select(x => {return x.Key + " " + x.FirstOrDefault();});

        }

    }
}
