using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNightScenario
{
    /// <summary>
    /// The class which is used to represent a person engaging in a romantic pursuit.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Pursuer
    {
        /// <summary>
        /// The age of the pursuer.
        /// </summary>
        public int Age;

        /// <summary>
        /// The pursuer's friend.
        /// </summary>
        public Pursued Friend;

        /// <summary>
        /// The pursuer's house.
        /// </summary>
        public House Home;

        /// <summary>
        /// The pursuer's hometown.
        /// </summary>
        public City Hometown;

        /// <summary>
        /// The pursuer's current location.
        /// </summary>
        public string Location;

        /// <summary>
        /// The amount of money in the pursuer's pocket.
        /// </summary>
        public decimal MoneyBalance;

        /// <summary>
        /// The name of the pursuer.
        /// </summary>
        public string Name;

        /// <summary>
        /// The pursuer's romance level.
        /// </summary>
        public double RomanceLevel;

        /// <summary>
        /// The pursuer's vehicle.
        /// </summary>
        public Car Vehicle;

        /// <summary>
        /// The pursuer buys gas for vehicle.
        /// </summary>
        public void BuyGas()
        {
            // Calculate amount of gas needed.
            double gasAmount = this.Vehicle.TankCapacity - this.Vehicle.GasLevel;

            decimal gasCost = this.Hometown.CornerStore.SellGas(gasAmount);

            // Add gas to vehicle.
            this.Vehicle.GasLevel = Math.Round(this.Vehicle.GasLevel + gasAmount, 2);

            this.MoneyBalance -= gasCost;
        }

        /// <summary>
        /// The guy goes on a date to the county fair.
        /// </summary>
        public void CountyFairDate()
        {
            this.DriveTo(this.Friend.Home.Name, true);

            this.VisitCountyFair();

            bool wasKissAccepted = this.DropOffDate();

            this.DriveTo(this.Home.Name, false);
        }

        public void DriveTo(string location, bool withFriend)
        {
            this.Vehicle.GoTo(location);

            this.GoTo(location);

            if (withFriend)
            {
                this.Friend.GoTo(location);
            }
        }

        /// <summary>
        /// The guy drops off his date.
        /// </summary>
        public bool DropOffDate()
        {
            // Offer a kiss to your date.
            bool wasKissAccepted = this.GiveKiss();

            // Say goodnight to girlfriend.
            this.Friend.SayGoodnight();

            return wasKissAccepted;
        }

        /// <summary>
        /// The guy gets gas and cash.
        /// </summary>
        public void GetGasAndCash()
        {
            this.DriveTo(this.Hometown.CornerStore.Name, false);

            // If the guy has less than $200.00.
            if (this.MoneyBalance < 200.00m)
            {
                // Withdraw enough money from the corner store's ATM so the guy has a total money balance of $200.00.
                this.MoneyBalance += this.Hometown.CornerStore.Atm.WithdrawMoney(200.00m - this.MoneyBalance);
            }

            // If vehicle gas level is less than tank capacity.
            if (this.Vehicle.GasLevel < this.Vehicle.TankCapacity)
            {
                // Fill vehicle with gas.
                this.BuyGas();
            }
        }

        /// <summary>
        /// The pursuer gets a haircut.
        /// </summary>
        public void GetHaircut()
        {
            this.DriveTo(this.Hometown.Salon.Name, false);

            decimal haircutPayment = this.Hometown.Salon.HaircutPrice;

            this.Hometown.Salon.GiveHaircut(haircutPayment);

            this.MoneyBalance -= haircutPayment;
        }

        /// <summary>
        /// The pursuer gives a gift to his pursued.
        /// </summary>
        public void GiveGift(string giftName)
        {
            // Give gift to pursued.
            double romanceIncrease = this.Friend.AcceptGift(giftName);

            // Increase pursuer's romance level by 30% of pursued's increase in romance level.
            this.RomanceLevel += romanceIncrease * 0.30;
        }

        /// <summary>
        /// The pursuer gives a kiss to his pursued.
        /// </summary>
        /// <returns>A boolean value indicating whether or not the kiss was accepted.</returns>
        public bool GiveKiss()
        {
            bool wasKissAccepted = this.Friend.ReceiveKiss();

            // Attempt to give pursued a kiss.
            if (wasKissAccepted)
            {
                // Increase romance level by 5.
                this.RomanceLevel += 5;
            }

            return wasKissAccepted;
        }

        /// <summary>
        /// The pursuer takes his pursued mini golfing.
        /// </summary>
        public void GoMiniGolfing()
        {
            this.DriveTo(this.Hometown.MiniGolf.Name, true);

            decimal golfPayment = this.Hometown.MiniGolf.GamePrice;

            this.MoneyBalance -= golfPayment * 2;

            this.Hometown.MiniGolf.PlayGolf(golfPayment);

            this.Hometown.MiniGolf.PlayGolf(golfPayment);

            decimal iceCreamPayment = this.Hometown.MiniGolf.ConePrice * 2;

            this.MoneyBalance -= iceCreamPayment;

            this.Hometown.MiniGolf.ServeIceCream(2, iceCreamPayment);

            this.DriveTo(this.Friend.Home.Name, true);
        }

        public void GoTo(string location)
        {
            this.Location = location;
        }

        /// <summary>
        /// The pursuer goes on a mini golf date.
        /// </summary>
        /// <returns>A value indicating whether or not the kiss was accepted.</returns>
        public bool MiniGolfDate()
        {
            this.DriveTo(this.Friend.Home.Name, false);

            this.GoMiniGolfing();

            bool wasKissAccepted = this.DropOffDate();

            this.DriveTo(this.Home.Name, false);

            return wasKissAccepted;
        }

        /// <summary>
        /// The pursuer prepares for a date with his friend.
        /// </summary>
        public void PrepareForDate()
        {
            this.GetGasAndCash();

            this.GetHaircut();

            this.DriveTo(this.Home.Name, false);
        }

        public void RideBusHome()
        {
            string location = this.Friend.Home.Name;

            // Ride to location.
            this.Hometown.CountyFair.CityBus.GoTo(location);

            // Change my location to match where the bus dropped us.
            this.GoTo(location);

            // Change friend's location to match where the bus dropped us.
            this.Friend.GoTo(location);
        }

        public void RideBusToCarnival()
        {
            string location = this.Hometown.CountyFair.Name;

            // Ride to location.
            this.Friend.Home.NeighborhoodBus.GoTo(location);

            // Change my location to match where the bus dropped us.
            this.GoTo(location);

            // Change friend's location to match where the bus dropped us.
            this.Friend.GoTo(location);
        }

        /// <summary>
        /// The pursuer and friend visit the county fair.
        /// </summary>
        public void VisitCountyFair()
        {
            // Take bus to county fair.
            this.RideBusToCarnival();

            Carnival countyFair = this.Hometown.CountyFair;

            // Get cost of admission for two people and five tokens.
            decimal admissionPayment = countyFair.GetAdmissionPrice(2, 5);

            // Add payment to county fair's money balance.
            this.MoneyBalance -= admissionPayment;

            int tokens = 0;

            // Enter fair and receive tokens.
            tokens = countyFair.AdmitVisitor(2, admissionPayment, 5);

            // Play ring toss game.
            string giftName = countyFair.PlayRingToss(countyFair.GameTokenCount);

            // Reduce number of tokens by number used for game.
            tokens -= countyFair.GameTokenCount;

            // Give gift to friend.
            this.GiveGift(giftName);

            // Go on ride.
            countyFair.RideFerrisWheel(countyFair.RideTokenCount);

            // Reduce number of tokens by number used on ride.
            tokens -= countyFair.RideTokenCount;

            // Leave county fair and take bus back to friend's home.
            this.RideBusHome();
        }
    }
}
