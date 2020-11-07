// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem_Workshop
{

    public class HotelReservation
    {
        // Creating a Dictionary to store the record of the  hotelName, weekdayRatesForRegular and weekendRatesForRegular of the hotel.
        public Dictionary<string, Hotel> hotelRecords;
        public HotelReservation()
        {
            hotelRecords = new Dictionary<string, Hotel>();
        }
        /// <summary>
        /// UC1 Add Hotel with name and rates for regular customer.
        /// </summary>
        /// <param name="hotel"></param>
        public void AddHotelRecords(Hotel hotel)
        {
            if (hotelRecords.ContainsKey(hotel.hotelName))
            {
                Console.WriteLine("Hotel already exists..!!");

            }

            hotelRecords.Add(hotel.hotelName, hotel);
        }
    }
}
