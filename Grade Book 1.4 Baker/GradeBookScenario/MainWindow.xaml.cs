using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GradeBookScenario.Business_Classes;

namespace GradeBookScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The Blackboard grade book.
        /// </summary>
        public GradeBook Blackboard;

        /// <summary>
        /// The Canvas book.
        /// </summary>
        public GradeBook Canvas;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates Blackboard and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newBlackboardButton_Click(object sender, RoutedEventArgs e)
        {
            this.Blackboard = new GradeBook();

            this.Blackboard.CurrentStudent = new Student();
            this.Blackboard.Url = "mygradebook.com";
            this.Blackboard.Version = "4.1.0";

            this.Blackboard.CurrentStudent.Course = new Course();
            this.Blackboard.CurrentStudent.Id = 210083;
            this.Blackboard.CurrentStudent.IsOnProbation = true;
            this.Blackboard.CurrentStudent.KnowledgeLevel = 65.5;
            this.Blackboard.CurrentStudent.Name = "Arthur";
            this.Blackboard.CurrentStudent.RequiredSessions = 3;

            this.Blackboard.CurrentStudent.Course.Fee = 500.00m;
            this.Blackboard.CurrentStudent.Course.Final = new Assignment();
            this.Blackboard.CurrentStudent.Course.Midterm = new Assignment();
            this.Blackboard.CurrentStudent.Course.Name = "Web Design";
            this.Blackboard.CurrentStudent.Course.Number = "211";
            this.Blackboard.CurrentStudent.Course.Teacher = new Instructor();

            this.Blackboard.CurrentStudent.Course.Teacher.CertificationExam = new Attempt();
            this.Blackboard.CurrentStudent.Course.Teacher.KnowledgeLevel = 90.5;
            this.Blackboard.CurrentStudent.Course.Teacher.Name = "Alan";
            this.Blackboard.CurrentStudent.Course.Teacher.Salary = 41000.00m;
            this.Blackboard.PrimaryInstructor = this.Blackboard.CurrentStudent.Course.Teacher;
            this.Blackboard.PrimaryInstructor.Assistant = new Instructor();

            // Assign field values of primary instructors assistant
            this.Blackboard.PrimaryInstructor.Assistant.KnowledgeLevel = 75.3;
            this.Blackboard.PrimaryInstructor.Assistant.Name = "Sheldon";
            this.Blackboard.PrimaryInstructor.Assistant.Salary = 400000.00m;

            this.Blackboard.CurrentStudent.Course.Teacher.CertificationExam.CompletionDate = "08/23/2018";
            this.Blackboard.CurrentStudent.Course.Teacher.CertificationExam.Score = 99.0;

            this.Blackboard.CurrentStudent.Course.Final.Difficulty = 64.8;
            this.Blackboard.CurrentStudent.Course.Final.Name = "Website 1";
            this.Blackboard.CurrentStudent.Course.Final.Points = 100.0;
            this.Blackboard.CurrentStudent.Course.Final.Type = "Final";

            this.Blackboard.CurrentStudent.Course.Midterm.Difficulty = 12.7;
            this.Blackboard.CurrentStudent.Course.Midterm.Name = "HTML Exercises";
            this.Blackboard.CurrentStudent.Course.Midterm.Points = 100.0;
            this.Blackboard.CurrentStudent.Course.Midterm.Type = "Midterm";
            this.Blackboard.CurrentStudent.Course.Midterm.Submission = new Attempt();
        }

        private void newCanvasButton_Click(object sender, RoutedEventArgs e)
        {
            this.Canvas = new GradeBook();

            this.Canvas.CurrentStudent = new Student();
            this.Canvas.Url = "instructure.com";
            this.Canvas.Version = "1.1.3";

            this.Canvas.CurrentStudent.Course = new Course();
            this.Canvas.CurrentStudent.Id = 240237;
            this.Canvas.CurrentStudent.KnowledgeLevel = 87.8;
            this.Canvas.CurrentStudent.Name = "Samantha";
            this.Canvas.CurrentStudent.RequiredSessions = 4;

            this.Canvas.CurrentStudent.Course.Fee = 400.00m;
            this.Canvas.CurrentStudent.Course.Final = new Assignment();
            this.Canvas.CurrentStudent.Course.Midterm = new Assignment();
            this.Canvas.CurrentStudent.Course.Name = "English Comp";
            this.Canvas.CurrentStudent.Course.Number = "101";
            this.Canvas.CurrentStudent.Course.Teacher = new Instructor();

            this.Canvas.CurrentStudent.Course.Final.Difficulty = 66.2;
            this.Canvas.CurrentStudent.Course.Final.Name = "Term Paper";
            this.Canvas.CurrentStudent.Course.Final.Points = 100.0;
            this.Canvas.CurrentStudent.Course.Final.Type = "Final";

            this.Canvas.CurrentStudent.Course.Midterm.Difficulty = 31.3;
            this.Canvas.CurrentStudent.Course.Midterm.Name = "Short Essay";
            this.Canvas.CurrentStudent.Course.Midterm.Points = 100.0;
            this.Canvas.CurrentStudent.Course.Midterm.Type = "Midterm";

            this.Canvas.CurrentStudent.Course.Teacher.CertificationExam = new Attempt();
            this.Canvas.CurrentStudent.Course.Teacher.KnowledgeLevel = 95.0;
            this.Canvas.CurrentStudent.Course.Teacher.Name = "Jeff";
            this.Canvas.CurrentStudent.Course.Teacher.Salary = 50000.00m;
            this.Canvas.PrimaryInstructor = this.Canvas.CurrentStudent.Course.Teacher;
            this.Canvas.PrimaryInstructor.Assistant = new Instructor();

            // Assign field values of primary instructors assistant
            this.Canvas.PrimaryInstructor.KnowledgeLevel = 85.3;
            this.Canvas.PrimaryInstructor.Name = "Samuel";
            this.Canvas.PrimaryInstructor.Salary = 35000.00m;

            this.Canvas.CurrentStudent.Course.Teacher.CertificationExam.CompletionDate = "11/18/2016";
            this.Canvas.CurrentStudent.Course.Teacher.CertificationExam.Score = 98.0;
        }

        private void takeFinalButton_Click(object sender, RoutedEventArgs e)
        {
            this.Blackboard.CurrentStudent.TakeAssignment();
            this.Blackboard.CurrentStudent.Course.CompleteAssignment();
            this.Blackboard.CurrentStudent.Course.Final.Complete();
        }

        private void writeFinalPaperButton_Click(object sender, RoutedEventArgs e)
        {
            this.Canvas.CurrentStudent.TakeAssignment();
            this.Canvas.CurrentStudent.Course.CompleteAssignment();
            this.Canvas.CurrentStudent.Course.Final.Complete();
        }

        private void tutorArthurButton_Click(object sender, RoutedEventArgs e)
        {
            this.Blackboard.CurrentStudent.GetHelp();
            this.Blackboard.CurrentStudent.Course.FindHelp();
            this.Blackboard.CurrentStudent.Course.Teacher.Assistant.TutorStudent();
            this.Blackboard.CurrentStudent.Course.Teacher.TutorStudent();
        }

        private void tutorSamanthaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Canvas.CurrentStudent.GetHelp();
            this.Canvas.CurrentStudent.Course.FindHelp();
            this.Canvas.CurrentStudent.Course.Teacher.Assistant.TutorStudent();
            this.Canvas.CurrentStudent.Course.Teacher.TutorStudent();
        }

        private void takeMidtermButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void writeEssayButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}