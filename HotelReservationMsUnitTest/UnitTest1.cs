// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HotelReservationMsUnitTest" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using HotelReservationSystemProblem_Workshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        Hotel hotel1 = new Hotel { hotelName = "Lakewood", weekdayRatesForRegular = 110, weekendRatesForRegular = 90, rating=3 };
        Hotel hotel2 = new Hotel { hotelName = "Bridgewood", weekdayRatesForRegular = 160, weekendRatesForRegular = 50, rating=4 };
        Hotel hotel3 = new Hotel { hotelName = "Ridgewood", weekdayRatesForRegular = 220, weekendRatesForRegular = 150,rating=5};
        

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
        /// <summary>
        /// UC3 Test case to check for correct output list of cheap hotels for weekdays & weekends.
        /// </summary>
        [TestMethod]
        public void GivenStartandEndDates_ShouldReturn_CheapestHotelForWeekendandWeekdays()
        {
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            reservation.AddHotelRecords(hotel3);
            var startDate = Convert.ToDateTime("11June2020");
            var endDate = Convert.ToDateTime("12June2020");
            Hotel cheapestHotel = reservation.FindCheapestHotel(startDate, endDate);
            var expected = reservation.hotelRecords["Lakewood"];
            Assert.AreEqual(expected, cheapestHotel);

        }
        /// <summary>
        /// UC4 Test case to check for correct output list of cheapest hotels based on weekdays & weekends.
        /// </summary>
        [TestMethod]
        public void GivenStartandEndDates_ShouldReturn_CheapestHotels_BasedOnWeekdayAndWeekend()
        {
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            var startDate = Convert.ToDateTime("11Sep2020");
            var endDate = Convert.ToDateTime("12Sep2020");

            var expected = reservation.hotelRecords["Lakewood"];
            var result = reservation.FindCheapestHotel(startDate, endDate);
            Assert.AreEqual(expected, result);

        }
        /// <summary>
        /// UC5 Test case to check for Given the list of hotel should return their rating.
        /// </summary>
        [TestMethod]
        public void GiventheListofHotels_ShouldReturn_TheirRatings()
        {
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            reservation.AddHotelRecords(hotel3);
            List<int> ratingList = new List<int>();
            ratingList = reservation.RetrieveHotelRatings();

            List<int> expectedRatingList = new List<int>() { 3, 4, 5 };

            CollectionAssert.AreEqual(ratingList, expectedRatingList);

        }
        /// <summary>
        /// UC6 Test case to check for correct output list of cheap hotels for weekdays And weekends 
        /// date range includes both weekdays and weekends
        /// should return results considering ratings as well
        /// </summary>
        [TestMethod]
        public void GivenStartandEndDates_ShouldReturn_CheapestHotelForWeekendandWeekdaysRATINGS()
        {
            reservation.AddHotelRecords(hotel1);
            reservation.AddHotelRecords(hotel2);
            var startDate = Convert.ToDateTime("11Sep2020");
            var endDate = Convert.ToDateTime("12Sep2020");

            var expected = reservation.hotelRecords["Lakewood"];
            var result = reservation.FindCheapestHotel(startDate, endDate);
            Assert.AreEqual(expected, result);

        }
    }
}
