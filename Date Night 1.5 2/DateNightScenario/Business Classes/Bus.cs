using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a bus.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Bus
    {
        /// <summary>
        /// The bus's current location.
        /// </summary>
        public string Location;

        /// <summary>
        /// The name of the bus.
        /// </summary>
        public string Name;

        /// <summary>
        /// The bus transports people to a location.
        /// </summary>
        public void GoTo(string location)
        {
            // Set the bus's Location field to the new location, e.g. We're there!
            this.Location = location;
        }
    }
}