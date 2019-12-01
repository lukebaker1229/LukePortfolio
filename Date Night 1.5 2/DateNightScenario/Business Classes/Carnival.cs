using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a carnival.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Carnival
    {
        /// <summary>
        /// The admission price to the carnival.
        /// </summary>
        public readonly decimal AdmissionPrice = 8.00m;

        /// <summary>
        /// The number of tokens needed for a carnival game.
        /// </summary>
        public readonly int GameTokenCount = 1;

        /// <summary>
        /// The number of tokens needed for a carnival ride.
        /// </summary>
        public readonly int RideTokenCount = 2;

        /// <summary>
        /// The address of the carnival.
        /// </summary>
        public string Address;

        /// <summary>
        /// The bus assigned to the carnival's neighborhood.
        /// </summary>
        public Bus CityBus;

        /// <summary>
        /// The amount of money in the carnival.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// The name of the carnival.
        /// </summary>
        public string Name;

        /// <summary>
        /// The cost of a carnival token.
        /// </summary>
        public decimal TokenCost;

        /// <summary>
        /// Admits a visitor to the carnival.
        /// </summary>
        /// <param name="guestCount">The number of guests in party.</param>
        /// <param name="payment">The payment for entry.</param>
        /// <param name="tokenCount">The number of tokens requested.</param>
        /// <returns>The number of tokens provided.</returns>
        public int AdmitVisitor(int guestCount, decimal payment, int tokenCount)
        {
            int soldTokens = 0;

            // If sufficient payment was provided...
            if (payment >= this.GetAdmissionPrice(guestCount, tokenCount))
            {
                // Add payment to carnival's money balance.
                this.MoneyBalance += payment;

                // Get sold tokens from token bucket.
                soldTokens = tokenCount;
            }

            // Return purchased tokens.
            return soldTokens;
        }

        /// <summary>
        /// Calculates the admission price for the carnival.
        /// </summary>
        /// <param name="guestCount">The number of guests in the party.</param>
        /// <param name="tokenCount">The number of tokens requested.</param>
        /// <returns>The price of admission.</returns>
        public decimal GetAdmissionPrice(int guestCount, int tokenCount)
        {
            // Calculate admission price.
            decimal admissionPrice = (guestCount * this.AdmissionPrice) + (this.TokenCost * tokenCount);

            return admissionPrice;
        }

        /// <summary>
        /// Play ring toss game.
        /// </summary>
        /// <param name="tokens">The tokens required to play.</param>
        /// <returns>The name of the gift won.</returns>
        public string PlayRingToss(int tokens)
        {
            // Create a new prize.
            Merchandise prize = new Merchandise();

            // Set fields of the prize.
            prize.Name = "WuvLuv";
            prize.Price = 19.95m;

            return prize.Name;
        }

        /// <summary>
        /// Rides the ferris wheel.
        /// </summary>
        /// <param name="tokens">The tokens required for the ride.</param>
        public void RideFerrisWheel(int tokens)
        {
        }
    }
}