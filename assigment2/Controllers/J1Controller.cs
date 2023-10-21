using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assigment2.Controllers
{
    public class J1Controller : ApiController
    {


        /// <summary>
        /// API request of a problem j1 DogTreats
        /// link to the problem: chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2020/ccc/juniorEF.pdf
        /// the problem is about entering 3 numbers (factor1, factor2 and factor3) and multiply the by 1, 2 and 3 respectively, then add the results and if
        /// you get 10 or more than 10 the result is "happy", if is less than 10 the result is "sad".
        /// </summary>
        /// <param name="factor1"></param>
        /// <param name="factor2"></param>
        /// <param name="factor3"></param>
        /// <returns>happy</returns> --if the result of the if validation is 10 or more
        /// <returns>sad</returns> --if the result of the if validation is less than 10
        // GET api/j1/factor1/factor2
        [Route("api/j1/{factor1}/{factor2}/{factor3}")]
        public string Get(int factor1, int factor2, int factor3)
        {
            
            // sume is a var to store the result of the math operation dscribed in the problem
            int suma = 1*factor1 + 2*factor2 + 3*factor3;

            //if to compare the result the sum to 10, if is true so return "happy"
            if (suma >= 10) {
                return "happy";
            } 

            //if is false return default value "sad"
            return "sad";
        }
    }
}
