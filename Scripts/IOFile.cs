using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SortedNumbersAPI.Scripts
{
    public class IOFile : IIOFile
    {

        private readonly string Path = Environment.CurrentDirectory + "\\Data\\results.txt";
        public string ReadFromFile()
        {
            string line = "";
            try
            {
                using StreamReader sr = new StreamReader(Path);
                line = sr.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return line;
        }
        public void SaveResult(string value)
        {
            using StreamWriter writer = new StreamWriter(Path);
            writer.WriteLine(value);
        }
        public string CorrectInput(string val)
        {
            try
            {
                string[] temp = val.Split(' ');
                int[] intArray = Array.ConvertAll(temp, int.Parse);
                foreach( int num in intArray)
                {
                    if (num<1 || num >10)
                    {
                        throw new OutOFBoundsException(num);
                    }
                }
            }
            catch (OutOFBoundsException e)
            {
                return e.Message;
            }

            catch (Exception e)
            {
                return e.Message;
            }
       
            
            return ""; 
        }
    }
}
