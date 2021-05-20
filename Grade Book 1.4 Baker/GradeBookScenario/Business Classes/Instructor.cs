using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookScenario.Business_Classes
{
    /// <summary>
    /// The class which is used to represent an nstructor.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Instructor
    {
        /// <summary>
        /// The knowledge level of the instructor.
        /// </summary>
        public double KnowledgeLevel;

        /// <summary>
        /// The name of the instructor.
        /// </summary>
        public string Name;

        /// <summary>
        /// The instructor's number of students.
        /// </summary>
        public int NumberOfStudentsTutored;

        /// <summary>
        /// The salary of the instructor.
        /// </summary>
        public decimal Salary;

        /// <summary>
        /// The exam the instructor took.
        /// </summary>
        public Attempt CertificationExam;

        /// <summary>
        /// The assistant.
        /// </summary>
        public Instructor Assistant;

        /// <summary>
        /// Whatever.
        /// </summary>
        public void TutorStudent()
        {
            this.NumberOfStudentsTutored = 1;
        }
    }
}
