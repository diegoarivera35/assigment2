using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assigment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// make a program for the problem J2 ChiliPeppers
        /// link to the excersice that is in the 3 page of the pdf chrome-extension://efaidnbmnnnibpcajpcglclefindmkaj/https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2023/ccc/juniorEF.pdf
        /// the URL will be /api/j2/4/Poblano/Cayenne/Thai/Poblano j2 is the name of the controller, 4 is the number of peppers and after thar every parameter is
        /// a name of a pepper that has a value in the code as integers, the code is not doing nothing with the first parameter (4) as its no clear that we have to request the user a error in case the number si wrong
        /// </summary>
        /// <param name="factor1"></param>
        /// <param name="factor2"></param>
        /// <param name="factor3"></param>
        /// <param name="factor4"></param>
        /// <param name="factor5"></param>
        /// <returns>suma</returns> --> it will add valor1, valor2, valor3, valor4 that have the value of the pepper introduce in the URL
        /// values:
        //Poblano 1500
        //Mirasol 6000
        //Serrano 15500
        //Cayenne 40000
        //Thai 75000
        //Habanero 125000
        // GET api/j2/factor1/factor2/factor3/factor4/factor5 --> /api/j2/4/Poblano/Cayenne/Thai/Poblano
        [Route("api/j2/{factor1}/{factor2}/{factor3}/{factor4}/{factor5}")]
        public int Get(int factor1, string factor2, string factor3, string factor4, string factor5)
        {

            // values of the pepper to make the calculation
            int Poblano = 1500;
            int Mirasol = 6000;
            int Serrano = 15500;
            int Cayenne = 40000;
            int Thai = 75000;
            int Habanero = 125000;
            int valor1 = 0;








            //if to compare the string enter in the request to a number store in a variable. All of this using if statements
            //to return the values of each string with the corresponding integer
            if (factor2 == "Poblano")
            {
                valor1 = Poblano;
                 
            } else if (factor2 == "Mirasol")
            {
                 valor1 = Mirasol;
                 
            } else if (factor2 == "Serrano")
            {
                 valor1 = Serrano;
                 
            } else if (factor2 == "Cayenne")
            {
                 valor1 = Cayenne;
                 
            } else if (factor2 == "Thai") 
            {
                 valor1 = Thai;
                 
            } else if ( factor2 == "Habanero")
            {
                 valor1 = Habanero;
                 
            }


            int valor2 = 0;

              if (factor3 == "Poblano")
            {
                valor2 = Poblano;
                 
            }
            else if (factor3 == "Mirasol")
            {
                valor2 = Mirasol;
                 
            }
            else if (factor3 == "Serrano")
            {
                valor2 = Serrano;
                 
            }
            else if (factor3 == "Cayenne")
            {
                valor2 = Cayenne;
                 
            }
            else if (factor3 == "Thai")
            {
                valor2 = Thai;
                 
            }
            else if (factor3 == "Habanero")
            {
                valor2 = Habanero;
                 
            }



            int valor3 = 0;

            if (factor4 == "Poblano")
            {
                valor3 = Poblano;
                 
            }
            else if (factor4 == "Mirasol")
            {
                valor3 = Mirasol;
                 
            }
            else if (factor4 == "Serrano")
            {
                valor3 = Serrano;
                 
            }
            else if (factor4 == "Cayenne")
            {
                valor3 = Cayenne;
                 
            }
            else if (factor4 == "Thai")
            {
                valor3 = Thai;
                 
            }
            else if (factor4 == "Habanero")
            {
                valor3 = Habanero;
                 
            }


            int valor4 = 0;

            if (factor5 == "Poblano")
            {
                valor4 = Poblano;
                 
            }
            else if (factor5 == "Mirasol")
            {
                valor4 = Mirasol;
                 
            }
            else if (factor5 == "Serrano")
            {
                valor4 = Serrano;
                 
            }
            else if (factor5 == "Cayenne")
            {
                valor4 = Cayenne;
                 
            }
            else if (factor5 == "Thai")
            {
                valor4 = Thai;
                 
            }
            else if (factor5 == "Habanero")
            {
                valor4 = Habanero;
                 
            }



            int suma = valor1 + valor2 + valor3 + valor4;
            // sume is a var to store the result of the math operation dscribed in the problem
            return suma;
        }


    }
}
