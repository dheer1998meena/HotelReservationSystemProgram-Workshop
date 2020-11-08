// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hotel.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem_Workshop
{
    /// <summary>
    /// Creating Hotel class.
    /// </summary>
    public class Hotel
    {
        /// <summary>
        /// objects containing details of Hotel Class
        /// </summary>
        public string hotelName { get; set; }
        public int weekdayRatesForRegular { get; set; }
        public int weekendRatesForRegular { get; set; }
        public int rating { get; set; }
    }
}
