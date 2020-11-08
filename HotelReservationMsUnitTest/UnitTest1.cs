// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using HotelReservationSystemProblem_Workshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HotelReservationMsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Initiallizing the instance object of HotelReservation Classs.
        /// </summary>
        HotelReservation reservation = new HotelReservation();
        /// <summary>
        /// Creating instance object of hotel class and store the record  of hotel.
        /// </summary>
        Hotel hotel1 = new Hotel { hotelName = "Lakewood", weekdayRatesForRegular = 110, weekendRatesForRegular = 90 };
        Hotel hotel2 = new Hotel { hotelName = "Bridgewood", weekdayRatesForRegular = 160, weekendRatesForRegular = 60 };
        Hotel hotel3 = new Hotel { hotelName = "Ridgewood", weekdayRatesForRegular = 220, weekendRatesForRegular = 150 };
        

        /// <summary>
        ///  UC1 Creating TestMethod Add Hotel with name and rates for regular customer
        /// </summary>
        [TestMethod]
        public void AddingListofHotels_ShouldReturn_CountofHotelsinList()
        {
            ///Act
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            reservation.AddHotelRecords(hotel3);
            var count = reservation.hotelRecords.Count;
           
            int Actual = reservation.hotelRecords.Count;
            int expected = count;
            ///Assert
            Assert.AreEqual(expected, Actual);
        }
        /// <summary>
        /// UC2 Creating TestMethod for Testing Find the Cheapest Hotel.
        /// </summary>
        [TestMethod]
        public void GivenStartandEndDates_ShouldReturn_CheapestHotelForWeekdays()
        {
            //Act
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            reservation.AddHotelRecords(hotel3);
            var startDate = Convert.ToDateTime("10Sep2020");
            var endDate = Convert.ToDateTime("11Sep2020");
            Hotel cheapestHotel = reservation.FindCheapestHotel(startDate, endDate);
            var expected = reservation.hotelRecords["Lakewood"];
            //Assert
            Assert.AreEqual(expected, cheapestHotel);
        }
    }
}
