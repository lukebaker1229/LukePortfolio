using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a person being romantically pursued.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Pursued
    {
        /// <summary>
        /// The age of the pursued.
        /// </summary>
        public int Age;

        /// <summary>
        /// The pursued's residence.
        /// </summary>
        public House Home;

        /// <summary>
        /// The pursued's current location.
        /// </summary>
        public string Location;

        /// <summary>
        /// The name of the pursued.
        /// </summary>
        public string Name;

        /// <summary>
        /// The pursued's romance level.
        /// </summary>
        public double RomanceLevel;

        /// <summary>
        /// The pursued accepts a gift from someone.
        /// </summary>
        /// <param name="giftName">The name of the gift to be accepted.</param>
        /// <returns>A value representing how much the romance level has increased.</returns>
        public double AcceptGift(string giftName)
        {
            double adjustment;

            // Calculate adjustment to romance level, based upon gift type.
            if (giftName == "Box of Chocolates")
            {
                adjustment = 5.0;
            }
            else if (giftName == "WuvLuv")
            {
                adjustment = -10.0;
            }
            else if (giftName == "Bouquet of Roses")
            {
                adjustment = 10.0;
            }
            else if (giftName == "Engagement Ring")
            {
                adjustment = 40.0;
            }
            else
            {
                adjustment = 0.0;
            }

            // Change romance level by adjustment amount.
            this.RomanceLevel += adjustment;

            return adjustment;
        }

        /// <summary>
        /// Change the location of the pursued.
        /// </summary>
        /// <param name="location">The new location.</param>
        public void GoTo(string location)
        {
            this.Location = location;
        }

        /// <summary>
        /// The pursued is offered a kiss from someone.
        /// </summary>
        /// <returns>A value indicating whether or not the kiss was accepted.</returns>
        public bool ReceiveKiss()
        {
            double adjustment;

            // Accept kiss if romance level is greater than 50.0.
            bool wasKissAccepted = this.RomanceLevel > 50.0;

            // If kiss was accepted...
            if (wasKissAccepted)
            {
                // Set the romance level adjustment at 5.0.
                adjustment = 5.0;
            }
            else
            {
                // Set the romance level adjustment at 2.5.
                adjustment = -2.5;
            }

            // Adjust romance level.
            this.RomanceLevel += adjustment;

            return wasKissAccepted;
        }

        /// <summary>
        /// The pursued bids farewell for the evening.
        /// </summary>
        public void SayGoodnight()
        {
            // Increase romance level.
            this.RomanceLevel += 5.0;
        }
    }
}