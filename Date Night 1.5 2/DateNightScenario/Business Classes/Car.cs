using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a car.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Car
    {
        /// <summary>
        /// The color of the car.
        /// </summary>
        public string Color;

        /// <summary>
        /// The gas level of the car.
        /// </summary>
        public double GasLevel;

        /// <summary>
        /// The car's GPS system to determine distances to places.
        /// </summary>
        public City Gps;

        /// <summary>
        /// An indicator of whether or not the car is running.
        /// </summary>
        public bool IsRunning;

        /// <summary>
        /// The license plate number of the car.
        /// </summary>
        public string LicenseNumber;

        /// <summary>
        /// The car's current location.
        /// </summary>
        public string Location;

        /// <summary>
        /// The model of the car.
        /// </summary>
        public string Model;

        /// <summary>
        /// The capacity of the gas tank.
        /// </summary>
        public double TankCapacity;

        /// <summary>
        /// The year the car was manufactured.
        /// </summary>
        public int Year;

        /// <summary>
        /// Goes to a location.
        /// </summary>
        public void GoTo(string location)
        {
            double gallonsRequired = 0.0;

            // Set the number of gallons required based on the destination. Not realistic because it doesn't account for starting point.
            if (location == this.Gps.Salon.Name)
            {
                gallonsRequired = 0.45;
            }
            else if (location == this.Gps.CornerStore.Name)
            {
                gallonsRequired = 0.35;
            }
            else if (location == this.Gps.House1.Name)
            {
                gallonsRequired = 0.36;
            }
            else if (location == this.Gps.House2.Name)
            {
                gallonsRequired = 0.75;
            }
            else if (location == this.Gps.MiniGolf.Name)
            {
                gallonsRequired = 1.22;
            }

            // Don't even try to go if you don't have enough gas. This car plans ahead!
            if (this.GasLevel > gallonsRequired)
            {
                // Start the car.
                this.Start();

                // Burn that  gas! Round the result to keep the GasLevel field always at 2 decimal places.
                this.GasLevel = Math.Round(this.GasLevel - gallonsRequired, 2);

                // Set the car's Location field to the new location, e.g. We're there!
                this.Location = location;

                // Shut off the car.
                this.ShutOff();
            }
        }

        /// <summary>
        /// Shuts off the car.
        /// </summary>
        public void ShutOff()
        {
            // Don't try to shut it off unless it is running.
            if (this.IsRunning)
            {
                this.IsRunning = false;
            }
        }

        /// <summary>
        /// Starts the car.
        /// </summary>
        public void Start()
        {
            // Don't try to start it unless it isn't running.
            if (!this.IsRunning)
            {
                this.IsRunning = true;
            }
        }
    }
}
