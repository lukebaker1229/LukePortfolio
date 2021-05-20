using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBookScenario.Business_Classes;

namespace GradeBookScenario
{
    /// <summary>
    /// The class which is used to represent an assignment.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Assignment
    {
        /// <summary>
        /// The assignment's difficulty rating on a scale of 1-100.
        /// </summary>
        public double Difficulty;

        /// <summary>
        /// The name of the assignment.
        /// </summary>
        public string Name;

        /// <summary>
        /// The total points possible on the assignment.
        /// </summary>
        public double Points;

        /// <summary>
        /// The type of assignment; e.g. Midterm or Final.
        /// </summary>
        public string Type;

        /// <summary>
        /// The submission for the assignment.
        /// </summary>
        public Attempt Submission;

        /// <summary>
        /// The assignment.
        /// </summary>
        public void Complete()
        {
            this.Submission = new Attempt();
            this.Submission.Accuracy = 70.0;
        }
    }
}