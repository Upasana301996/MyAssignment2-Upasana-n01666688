using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MyAssignment2_Upasana_n01666688.Controllers
{

    public class DiceGameController : ControllerBase
    {

        /// /// <summary>
        /// GET api/DiceGame/{m}/{n}
        /// Calculates and returns the number of ways to get the sum 10 with two dice.
        /// </summary>
        /// <param name="m">Number of sides on the smaller dice.</param>
        /// <param name="n">Number of sides on the larger dice.</param>
        /// <returns>A string indicating the total number of ways to achieve the sum 10.</returns>
        /// <example>GET ../api/J2/DiceGame/6/8
        /// GET ../api/J2/DiceGame/12/4
        /// GET ../api/J2/DiceGame/3/3</example>
        
        [HttpGet]
        [Route("api/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
           

            int ways = 0;
            for (int i = 0; i < m; i++)
            {
                int j = 10 - i;
                if (j >= 1 && j<=n)
                {
                    ways++;
                }
            }

            return "There are " + ways + "total ways to get the sum 10";
        }
    }
}
    

