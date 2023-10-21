using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assigment2.Controllers
{
    public class J3Controller : ApiController
    {


        /// <summary>
        /// link to J3 ExactlyElectrical : chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2017/stage%201/juniorEF.pdf
        /// a program to calculate if you can get from point a to point b in a Cartesian plane where there are intersections every 1 unit in x and in Y, the amount of moves
        /// you can make trough the intersections depends on the number of batteries you have, you will spend them by passing intersections, each intersection is one less
        /// battery points you have
        /// </summary>
        /// <param name="a"></param> first  X coordinate
        /// <param name="b"></param> first y coordinate
        /// <param name="c"></param> second x coordinate
        /// <param name="d"></param> second y coordinate
        /// <param name="t"></param> number of batteries cells
        /// <returns>answer</returns> --> the answer is either y (yes) or n (no)
        // GET api/j3/a/b/c/d/t
        [Route("api/j3/{a}/{b}/{c}/{d}/{t}")]
        public string Get(int a, int b, int c, int d, int t)
        {
            //add the coordinates to get the amount of intersections
            int avenue = a + b;
            int street = c + d;
            int battery = t;

            // Use this method to always get a positive number (intersections to destination) so we can know if the battery will be enought to get to the destination
            int numberOfItersections = Math.Abs(avenue - street);

            string answer;

            // validate the conditions to know if the battery is enought, if its bigger than number of intersections but also
            // the intersection must be even and the number of battery must be even the result is yes. 
            //the other possibility is that the battery is bigger than the number of intersections and thenumber of battery and the number of intersections is odd
            // sny other possibilities the answer is NO ("n")
            if (battery % 2 == 1 && numberOfItersections % 2 == 1 && battery > numberOfItersections)
            {
                answer = "y";
            }
            else if (battery % 2 == 0 && numberOfItersections % 2 == 0 && battery > numberOfItersections)
            {
                answer = "y";
            }
            else
            {
                answer = "n";
            }

            return answer;
        }



    }
}
