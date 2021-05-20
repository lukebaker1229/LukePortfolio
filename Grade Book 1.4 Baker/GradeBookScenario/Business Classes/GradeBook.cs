using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GradeBookScenario.Business_Classes;

namespace GradeBookScenario
{
    /// <summary>
    /// The class which is used to represent a grade book.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class GradeBook
    {
        /// <summary>
        /// The grade book's current student.
        /// </summary>
        public Student CurrentStudent;

        /// <summary>
        /// The grade book's uniform resource locator (URL).
        /// </summary>
        public string Url;

        /// <summary>
        /// The current version of the GradeBook.
        /// </summary>
        public string Version;

        /// <summary>
        /// The gradebook's instructor.
        /// </summary>
        public Instructor PrimaryInstructor;
    }
}