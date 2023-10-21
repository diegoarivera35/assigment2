using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assigment2.Controllers
{
    public class J4Controller : ApiController
    {
        //I tried to do this excersice j4 ArrivalTime
        //link: chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2016/stage%201/juniorEn.pdf
        //but i was getting an error when entering 05:00, it says that : is a security issue so i coudnt finish it

        // GET api/j4/factor1/
        [Route("api/j4/{factor1}")]
        public string Get(string factor1)
        {
            string timeString = factor1;
            string[] timeParts = timeString.Split(':');



            //if is false return default value "sad"
            return "hola";
        }


    }
}
