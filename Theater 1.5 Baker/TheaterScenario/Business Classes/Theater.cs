using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterScenario
{
    /// <summary>
    /// The class which is used to represent a theater.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Theater
    {
        /// <summary>
        /// The name of the theater.
        /// </summary>
        public string Name;

        /// <summary>
        /// The number of guests admitted.
        /// </summary>
        public int NumberOfGuestsAdmitted;

        /// <summary>
        /// The screening room at the movie theater.
        /// </summary>
        public ScreeningRoom ScreeningRoom;

        /// <summary>
        /// The price of a ticket.
        /// </summary>
        public decimal TicketPrice;

        public Person Guest;

        public Person Attendant;
        private decimal amountRemoved;
        private bool wasGuestAdmitted;

        public void AdmitGuest()
        {
            this.wasGuestAdmitted = this.ScreeningRoom.SeatGuest();
            if (this.wasGuestAdmitted)
            {
                this.NumberOfGuestsAdmitted++;
            }
        }

        public void PresentMovie()
        {
            this.amountRemoved = this.Guest.RemoveMoney(TicketPrice);
            if (amountRemoved == TicketPrice)
            {
                this.Guest.Ticket = new Ticket();
                this.Guest.Ticket.MovieTitle = ScreeningRoom.FeaturedMovie.Title;
                this.Guest.Ticket.Price = TicketPrice;
            }
            else
            {
                this.AdmitGuest();
                this.ScreeningRoom.PresentMovie();
                this.ScreeningRoom.NumberOfSeatsOccupied = 0;
            }
        }
    }
}