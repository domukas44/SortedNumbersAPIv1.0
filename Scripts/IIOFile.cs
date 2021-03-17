using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortedNumbersAPI.Scripts
{
    public interface IIOFile
    {
        public string ReadFromFile();

        public void SaveResult(string value);

        public string CorrectInput(string val);
        
    }
}
