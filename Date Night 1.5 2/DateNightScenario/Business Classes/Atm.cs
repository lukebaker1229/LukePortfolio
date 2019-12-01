using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent an automatic teller machine (ATM).
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Atm
    {
        /// <summary>
        /// The amount of cash currently in the machine.
        /// </summary>
        public decimal CashAmount;

        /// <summary>
        /// Withdraws money from the machine.
        /// </summary>
        /// <param name="amount">The amount of money to withdraw.</param>
        /// <returns>The amount of money withdrawn.</returns>
        public decimal WithdrawMoney(decimal amount)
        {
            decimal amountWithdrawn = 0;

            // Remove withdrawn money from ATM's cash amount, if the machine has enough.
            if (this.CashAmount >= amount)
            {
                amountWithdrawn = amount;

                this.CashAmount -= amountWithdrawn;
            }

            return amountWithdrawn;
        }
    }
}