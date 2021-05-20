using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterScenario
{
    /// <summary>
    /// The class which is used to represent a screening room.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class ScreeningRoom
    {
        /// <summary>
        /// The number of guests currently in the screening room.
        /// </summary>
        public int NumberOfSeatsOccupied;

        /// <summary>
        /// The number of guests that can be admitted to the screening room.
        /// </summary>
        public int SeatingCapacity;

        /// <summary>
        /// blah.
        /// </summary>
        public Movie FeaturedMovie;

        /// <summary>
        /// blag.
        /// </summary>
        public void PresentMovie()
        {
            if (this.FeaturedMovie.ViewLicenses > 0)
            {
                this.FeaturedMovie.ViewLicenses -= 1;
            }
        }

        public bool SeatGuest(string titleOnTicket)
        {
            bool result = false;
            if (titleOnTicket == FeaturedMovie.Title && NumberOfSeatsOccupied < SeatingCapacity)
            {
                this.NumberOfSeatsOccupied++;
                    return result = true;
            }
            else
            {
                return result = false;
            }
        }

        internal bool SeatGuest()
        {
            throw new NotImplementedException();
        }
    }
}