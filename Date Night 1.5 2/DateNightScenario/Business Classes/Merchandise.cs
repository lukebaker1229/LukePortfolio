using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent an item of merchandise.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Merchandise
    {
        /// <summary>
        /// The name of the merchandise item.
        /// </summary>
        public string Name;

        /// <summary>
        /// The price of the merchandise item.
        /// </summary>
        public decimal Price;
    }
}