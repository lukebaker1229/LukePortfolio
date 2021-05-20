using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookScenario.Business_Classes
{
    /// <summary>
    /// The attempt.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Attempt
    {
        /// <summary>
        /// The accuracy of the submission.
        /// </summary>
        public double Accuracy;

        /// <summary>
        /// The completion date.
        /// </summary>
        public string CompletionDate;

        /// <summary>
        /// The score.
        /// </summary>
        public double Score;
    }
}
