using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;


namespace MyAssignment2_Upasana_n01666688.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// At Chip’s Fast Food emporium there's a very simple menu. Each food item is selected by entering a digit choice.
        /// Writing a program that will compute the total Calories of the meal.
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>RESPONSE with the total calorie count for sleected items : Your Total Calorie count is totalCalories = burgerchoices[burger] + drinkchoices[drink] + sidechoices[side] + dessertchoices[dessert];</returns>
        /// <example>GET/api/Menu/4/4/4/4
        /// GET/api/J1/Menu/1/2/3/4</example>


        [HttpGet]
        [Route("api/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerchoices = { 0, 461, 431, 420, 0 }; //created array to store the calorie value for each item
            int[] drinkchoices = { 0, 130, 160, 118, 0 };
            int[] sidechoices = { 0, 100, 57, 70, 0 };
            int[] dessertchoices = { 0, 167, 266, 75, 0 };

            if (burger < 1 || burger > 4) return "Invalid Choice"; // loops will check the user choices from 1 to 4
            if (drink < 1 || drink > 4) return "Invalid Choice";
            if (side < 1 || side > 4) return "Invalid Choice";
            if (dessert < 1 || dessert > 4) return "Invalid Choice";

            // calculate the total calorie count for a meal based on user choices
            int totalCalories = burgerchoices[burger] + drinkchoices[drink] + sidechoices[side] + dessertchoices[dessert];

            return "Your Total Calorie Count is " + totalCalories;
        }
    }
}

