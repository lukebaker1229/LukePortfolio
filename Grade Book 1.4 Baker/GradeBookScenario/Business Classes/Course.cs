using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBookScenario.Business_Classes;

namespace GradeBookScenario
{
    /// <summary>
    /// The class which is used to represent a course.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Course
    {
        /// <summary>
        /// The fee for the course.
        /// </summary>
        public decimal Fee;

        /// <summary>
        /// The final exam assignment.
        /// </summary>
        public Assignment Final;

        /// <summary>
        /// The midterm assignment.
        /// </summary>
        public Assignment Midterm;

        /// <summary>
        /// The name of the course.
        /// </summary>
        public string Name;

        /// <summary>
        /// The catalog number of the course.
        /// </summary>
        public string Number;

        /// <summary>
        /// The teacher of the course.
        /// </summary>
        public Instructor Teacher;

        /// <summary>
        /// The course assigment.
        /// </summary>
        public void CompleteAssignment()
        {
        }

        /// <summary>
        /// Course.
        /// </summary>
        public void FindHelp()
        {
        }
    }
}