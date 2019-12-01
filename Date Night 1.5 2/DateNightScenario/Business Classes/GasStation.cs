using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a gas station.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class GasStation
    {
        /// <summary>
        /// The address of the gas station.
        /// </summary>
        public string Address;

        /// <summary>
        /// The gas station's automated teller machine (ATM).
        /// </summary>
        public Atm Atm;

        /// <summary>
        /// The price of gas (per gallon).
        /// </summary>
        public decimal GasPricePerGallon;

        /// <summary>
        /// The amount of money in the gas station's cash drawer.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// The name of the gas station.
        /// </summary>
        public string Name;

        /// <summary>
        /// Sells gas.
        /// </summary>
        /// <param name="amountSold">The amount of gas to be sold (in gallons).</param>
        /// <returns>The total cost of the the gas that was sold.</returns>
        public decimal SellGas(double amountSold)
        {
            // Calculate gas cost.
            decimal gasCost = Math.Round((decimal)amountSold * this.GasPricePerGallon, 2);

            // Add payment to gas station's money balance.
            this.MoneyBalance += gasCost;

            return gasCost;
        }
    }
}