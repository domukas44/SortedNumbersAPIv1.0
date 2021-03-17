using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortedNumbersAPI.Scripts
{
    public interface IAlgorithms
    {
        public string SimpleSort(string val);

        public string BubbleSort(string val);
        
        public string InsertionSort(string val);
        
    }
}
