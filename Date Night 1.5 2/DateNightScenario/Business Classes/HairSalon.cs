using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a hair salon.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class HairSalon
    {
        /// <summary>
        /// The address of the hair salon.
        /// </summary>
        public string Address;

        /// <summary>
        /// The price of a haircut.
        /// </summary>
        public decimal HaircutPrice;

        /// <summary>
        /// The amount of money in the hair salon's cash box.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// The name of the hair salon.
        /// </summary>
        public string Name;

        /// <summary>
        /// Gives a haircut.
        /// </summary>
        /// <param name="payment">The payment for the haircut.</param>
        public void GiveHaircut(decimal payment)
        {
            this.MoneyBalance += payment;
        }
    }
}