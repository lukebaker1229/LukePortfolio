using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookScenario
{
    /// <summary>
    /// The class which is used to represent a student.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Student
    {
        /// <summary>
        /// The student's enrolled course.
        /// </summary>
        public Course Course;

        /// <summary>
        /// The student's ID number.
        /// </summary>
        public int Id;

        /// <summary>
        /// An indicator of whether or not the student is on probation.
        /// </summary>
        public bool IsOnProbation;

        /// <summary>
        /// The student's knowledge level.
        /// </summary>
        public double KnowledgeLevel;

        /// <summary>
        /// The student's name.
        /// </summary>
        public string Name;

        /// <summary>
        /// The number of sessions required for the student to be removed from probation.
        /// </summary>
        public int RequiredSessions;

        /// <summary>
        /// The assigment.
        /// </summary>
        public void TakeAssignment(string type, string date )
        {
        }

        /// <summary>
        /// ok.
        /// </summary>
        public void GetHelp()
        {
            this.IsOnProbation = false;
        }
    }
}