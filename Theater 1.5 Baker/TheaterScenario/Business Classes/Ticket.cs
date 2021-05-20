using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterScenario
{
    /// <summary>
    /// The class which is used to represent a movie ticket.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Ticket
    {
        /// <summary>
        /// The title of the movie.
        /// </summary>
        public string MovieTitle;

        /// <summary>
        /// The price paid for the ticket.
        /// </summary>
        public decimal Price;
    }
}