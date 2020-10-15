using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01429970.Controllers
{
    
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Calculates the number of ways 10 may be rolled on these two dice.
        /// </summary>
        /// <param name="m">Positive integer representing the number of sides on the first die</param>
        /// <param name="n">Positive integer representing the number of sides on the second die</param>
        /// <example>eg. GET ../api/J2/DiceGame/6/8   ->   "There are 5 ways to get the sum 10."</example>
        /// <example>eg. GET ../api/J2/DiceGame/12/4   ->   "There are 4 ways to get the sum 10."</example>
        /// <example>eg. GET ../api/J2/Dicegame/5/-5   ->   "Please retype the dice value!"</example>
        /// <returns>The string shows the number of ways 10 may be rolled on these two dice.</returns>
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDiceGame(int m, int n)
        {
            if (m >= 1 && n >= 1)
            {
                int count = 0;
                for (int i = 0; i <= m; i++)
                {
                    if (10 - i <= n && 10 - i > 0)
                    {
                        count += 1;
                    }
                }
                if (count == 1)
                {
                    return "There is 1 way to get the sum 10.";
                }
                else
                {
                    return $"There are {count} ways to get the sum 10.";
                }
            }
            else
            {
                return "Please retype the dice value!";
            }
        }
    }
}
