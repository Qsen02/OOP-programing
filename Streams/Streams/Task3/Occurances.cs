using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams.Task3
{
    public class Occurances
    {
        public string Word { get; set; }
        public int Occurance { get; set; }
        public Occurances(string word) 
        {
            Word = word;
            Occurance = 0;
        }
    }
}
