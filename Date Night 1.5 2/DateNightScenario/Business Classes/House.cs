using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a house.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class House
    {
        /// <summary>
        /// The address of the house.
        /// </summary>
        public string Address;

        /// <summary>
        /// An indicator of whether or not the house is currently occupied.
        /// </summary>
        public bool IsOccupied;

        /// <summary>
        /// The name of the house.
        /// </summary>
        public string Name;

        /// <summary>
        /// The bus that is assigned to the house's neighborhood.
        /// </summary>
        public Bus NeighborhoodBus;
    }
}