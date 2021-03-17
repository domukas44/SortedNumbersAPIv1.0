using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SortedNumbersAPI.Scripts;

namespace SortedNumbersAPI.Controllers
{
    
    [ApiController]
    [Route("/api/[controller]")]
    public class NumbersController : ControllerBase
    {
        private readonly IIOFile stream;

        private readonly IAlgorithms algorithms;


        //public List<int> numbers = new List<int>();
        private readonly string numbers = "";

        public NumbersController(IIOFile _stream, IAlgorithms _algorithms)
        {
            stream = _stream;
            algorithms = _algorithms;
            numbers = stream.ReadFromFile();
        }

        // GET: api/<NumbersController>
        [HttpGet]
        public string Get()
        {
            return numbers;
        }

        // POST api/<NumbersController>
        [HttpPost]
        public string Post([FromBody] string val)
        {
            string msg = stream.CorrectInput(val);
            if (msg.Equals(""))
            {
                val = algorithms.SimpleSort(val);

                stream.SaveResult(val);

                return "data successfully sorted and saved";
            }
            else return msg;
        }

        [HttpPost("/api/numbers/bonus")]
        public string Post2([FromBody] string val)
        {
            string msg = stream.CorrectInput(val);
            if (msg.Equals(""))
            {
                string results = "Insertion sort: ";
                string temp = val;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                algorithms.InsertionSort(val);
                watch.Stop();
                results += watch.ElapsedMilliseconds;
                val = temp;
                watch = System.Diagnostics.Stopwatch.StartNew();
                algorithms.SimpleSort(val);

                watch.Stop();
                results = results + "ms,\nSimple sort: " + watch.ElapsedMilliseconds;
                val = temp;
                watch = System.Diagnostics.Stopwatch.StartNew();
                val = algorithms.BubbleSort(val);

                watch.Stop();
                results = results + "ms,\nBubble sort: " + watch.ElapsedMilliseconds + "ms.";

                stream.SaveResult(val);

                return results;
            }
            return msg;
        }

    }
}
