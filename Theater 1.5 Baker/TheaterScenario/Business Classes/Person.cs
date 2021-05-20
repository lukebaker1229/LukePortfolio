using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterScenario
{
    /// <summary>
    /// The class which is used to represent a guest.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Person
    {
        /// <summary>
        /// The cash that the person is carrying.
        /// </summary>
        public decimal Cash;

        /// <summary>
        /// The name of the person.
        /// </summary>
        public string Name;

        /// <summary>
        /// The person's ticket.
        /// </summary>
        public Ticket Ticket;

        /// <summary>
        /// blah.
        /// </summary>
        /// <param>blah.</param>
        /// <returns></returns>
        public decimal RemoveMoney(decimal amount)
        {
            decimal amountRemoved = 0.00m;
            if (Cash >= amount)
            {
                amountRemoved = amount;
            }
            else
            {
                amountRemoved = 0.00m;
            }
            return Cash -= amountRemoved;
        }

        internal decimal RemoveMoney()
        {
            throw new NotImplementedException();
        }
    }
}