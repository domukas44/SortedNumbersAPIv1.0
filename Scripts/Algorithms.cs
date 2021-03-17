using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortedNumbersAPI.Scripts
{
    public class Algorithms : IAlgorithms
    {
        public string SimpleSort(string val)
        {
            
            string[] temp = val.Split(' ');
            int[] intArray = Array.ConvertAll(temp, int.Parse);

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if(intArray[i] > intArray[j])
                    {
                        int swap = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = swap;
                    }
                }
            }

            return string.Join(" ", intArray);
        }

        public string BubbleSort(string val)
        {
            string[] temp = val.Split(' ');
            int[] intArray = Array.ConvertAll(temp, int.Parse);

            for (int i = 0; i < intArray.Length-1; i++)
            {
                for (int j = 0; j < intArray.Length-i-1; j++)
                {
                    if (intArray[j]> intArray[j+1])
                    {
                        int swap = intArray[j];
                        intArray[j] = intArray[j+1];
                        intArray[j+1] = swap;
                    }
                }
            }

            return string.Join(" ", intArray);
        }

        public string InsertionSort(string val)
        {
            string[] temp = val.Split(' ');
            int[] intArray = Array.ConvertAll(temp, int.Parse);

            for (int i = 1; i <= intArray.Length - 1; i++)
            {
                int j = i;
                while (j>0 && intArray[j-1]>=intArray[j])
                {
                    int swap = intArray[j];
                    intArray[j] = intArray[j -1];
                    intArray[j -1] = swap;
                    j-= 1;
                }
            }

            return string.Join(" ", intArray);
        }

    }
}
