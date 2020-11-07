// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using HotelReservationSystemProblem_Workshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationMsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Initiallizing the instamnnce object of HotelReservation Classs.
        /// </summary>
        HotelReservation reservation = new HotelReservation();

        /// <summary>
        ///  UC1 Creating TestMethod Add Hotel with name and rates for regular customer
        /// </summary>
        [TestMethod]
        public void AddHotelWithName_AndRatesForRegularCustomer()
        {
            ///Act
            var hotel1 = new Hotel { hotelName = "Lakewood", weekdayRatesForRegular = 110, weekendRatesForRegular =90 };
            var hotel2 = new Hotel { hotelName = "Bridgewood", weekdayRatesForRegular = 160, weekendRatesForRegular = 60 };
            var hotel3 = new Hotel { hotelName = "Ridgewood", weekdayRatesForRegular = 220, weekendRatesForRegular = 150 };
            var count = reservation.hotelRecords.Count;
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            reservation.AddHotelRecords(hotel3);
            int Actual = reservation.hotelRecords.Count;
            int expected = count + 3;
            ///Assert
            Assert.AreEqual(expected, Actual);
        }
    }
}
