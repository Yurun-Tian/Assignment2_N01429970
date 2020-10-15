using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01429970.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This program will compute the total Calories of the meal.
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <example>eg. GET ../api/J1/Menu/4/4/4/4   ->   "Your total calorie count is 0"</example>
        /// <example>eg. GET ../api/J1/Menu/1/2/3/4   ->   "Your total calorie count is 691"</example>
        /// <example>eg. GET ../api/J1/Menu/1/2/4/8   ->   "Please type the right index choice!"</example>
        /// <returns>The summation of each product's calorie.</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            if (burger > 0 && burger <= 4 && drink > 0 && drink <= 4 && side > 0 && side <= 4 && dessert > 0 && dessert <= 4)
            {
                int[] burgerCalories = new int[] { 461, 431, 420, 0 };
                int[] drinkCalories = new int[] { 130, 160, 118, 0 };
                int[] sideCalories = new int[] { 100, 57, 70, 0 };
                int[] dessertCalories = new int[] { 167, 266, 75, 0 };
                int totalCalories = burgerCalories[burger - 1] + drinkCalories[drink - 1] + sideCalories[side - 1] + dessertCalories[dessert - 1];
                return $"Your total calorie count is {totalCalories}";
            }
            else
            {
                return "Please type the right index choice!";
            }
        }
    }
}
