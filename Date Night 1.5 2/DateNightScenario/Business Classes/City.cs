using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a city.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class City
    {
        /// <summary>
        /// The city's corner store.
        /// </summary>
        public GasStation CornerStore;

        /// <summary>
        /// The city's county fairgrounds.
        /// </summary>
        public Carnival CountyFair;

        /// <summary>
        /// The city's first house.
        /// </summary>
        public House House1;

        /// <summary>
        /// The city's second house.
        /// </summary>
        public House House2;

        /// <summary>
        /// The city's mini golf course.
        /// </summary>
        public MiniGolfCourse MiniGolf;

        /// <summary>
        /// The name of the city.
        /// </summary>
        public string Name;

        /// <summary>
        /// The city's hair stylist.
        /// </summary>
        public HairSalon Salon;

        /// <summary>
        /// The state that the city is within.
        /// </summary>
        public string State;
    }
}