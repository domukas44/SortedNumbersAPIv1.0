using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortedNumbersAPI.Scripts
{
    [Serializable]
    public class OutOFBoundsException : Exception
    {

        public OutOFBoundsException()
        {

        }

        public OutOFBoundsException(int num)
            : base(String.Format("Number is not in range of 1-10: {0}", num))
        {

        }

    }
}
