using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a mini golf course.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class MiniGolfCourse
    {
        /// <summary>
        /// The address of the mini golf course.
        /// </summary>
        public string Address;

        /// <summary>
        /// The price of an ice cream cone.
        /// </summary>
        public decimal ConePrice;

        /// <summary>
        /// The price of a game of mini golf.
        /// </summary>
        public decimal GamePrice;

        /// <summary>
        /// The amount of money in the mini golf course's cash register.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// The name of the mini golf course.
        /// </summary>
        public string Name;

        /// <summary>
        /// Serves ice cream.
        /// </summary>
        /// <param name="numberOfCones">The number of ice cream cones to serve.</param>
        /// <param name="payment">The payment for the ice cream cones.</param>
        public void ServeIceCream(int numberOfCones, decimal payment)
        {
            // Calculate total cost of ice cream cones.
            decimal totalConeCost = numberOfCones * this.ConePrice;

            if (payment >= totalConeCost)
            {
                // Add payment to mini golf's money balance.
                this.MoneyBalance += payment;
            }
        }

        /// <summary>
        /// Plays a game of golf.
        /// </summary>
        /// <param name="payment">The payment for the game.</param>
        public void PlayGolf(decimal payment)
        {
            // Add payment to mini golf's money balance.
            if (payment >= this.GamePrice)
            {
                this.MoneyBalance += payment;
            }
        }
    }
}