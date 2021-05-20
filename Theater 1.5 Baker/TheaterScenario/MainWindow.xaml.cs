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

namespace TheaterScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The AMC Theater.
        /// </summary>
        public Theater AmcTheater;

        /// <summary>
        /// The Marcus Theater.
        /// </summary>
        public Theater MarcusTheater;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates the AMC Theater and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newAmcTheaterButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Theater class.
            this.AmcTheater = new Theater();

            // Set field values of AMC Theater.
            this.AmcTheater.Name = "AMC Theater";
            this.AmcTheater.TicketPrice = 15.00m;
            this.AmcTheater.ScreeningRoom = new ScreeningRoom();
            this.AmcTheater.ScreeningRoom.SeatingCapacity = 24;

            // Set field values of the attendant.
            this.AmcTheater.Attendant.Name = "Bryan";

            // Set field values of the featured movie.
            this.AmcTheater.ScreeningRoom.FeaturedMovie.Title = "Avengers: Infinity War";
            this.AmcTheater.ScreeningRoom.FeaturedMovie.ViewLicenses = 2;

            // Set field values of the guest.
            this.AmcTheater.Guest.Cash = 20.00m;
            this.AmcTheater.Guest.Name = "Samantha";

            // Set field values of the screening room.
        }

        /// <summary>
        /// Creates the Marcus Theater and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newMarcusTheaterButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Theater class.
            this.MarcusTheater = new Theater();

            // Set field values of Marcus Theater.
            this.MarcusTheater.Name = "Marcus Theater";
            this.MarcusTheater.TicketPrice = 15.00m;
            this.MarcusTheater.ScreeningRoom = new ScreeningRoom();
            this.MarcusTheater.ScreeningRoom.SeatingCapacity = 32;

            // Set field values of the attendant.
            this.MarcusTheater.Attendant.Name = "Brandy";

            // Set field values of the featured movie.
            this.MarcusTheater.ScreeningRoom.FeaturedMovie.Title = "The LEGO Batman Movie";
            this.MarcusTheater.ScreeningRoom.FeaturedMovie.ViewLicenses = 4;

            // Set field values of the guest.
            this.MarcusTheater.Guest.Cash = 40.00m;
            this.MarcusTheater.Guest.Name = "Samuel";

            // Set field values of the screening room.
        }

        /// <summary>
        /// Presents the movie, "Avengers: Infinity War".
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void presentAvengersInfinityWarButton_Click(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// Presents the movie, "The LEGO Batman Movie".
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void presentLegoBatmanButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}