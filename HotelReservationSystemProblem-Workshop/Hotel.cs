using System;
using System.Collections.Generic;
using System.Text;

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
namespace HotelReservationSystemProblem_Workshop
{
    /// <summary>
    /// Creating Hotel class.
    /// </summary>
    public class Hotel
    {
        // Defining the field property of hotelName, weekdayRatesForRegular and weekendRatesForRegular.
        public string hotelName { get; set; }
        public int weekdayRatesForRegular { get; set; }
        public int weekendRatesForRegular { get; set; }
    }
}
