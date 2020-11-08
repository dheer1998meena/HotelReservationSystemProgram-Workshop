﻿// --------------------------------------------------------------------------------------------------------------------
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
        /// Creating a Dictionary to store the record of the  hotelName, weekdayRatesForRegular and weekendRatesForRegular of the hotel.
        public Dictionary<string, Hotel> hotelRecords;
        public HotelReservation()
        {
            hotelRecords = new Dictionary<string, Hotel>();
        }
        /// <summary>
        /// Creating List of Hotels of type Hotel.
        /// </summary>
        List<Hotel> hotelList = new List<Hotel>();

        /// <summary>
        /// Add Hotel with name and rates for regular customer.
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
        /// <summary>
        /// Creating a method for Calculating Cost of hotel.
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public int CalculateCost(Hotel hotel, DateTime startDate, DateTime endDate)
        {
            var cost = 0;
            var weekdayRate = hotel.weekdayRatesForRegular;
            var weekendRate = hotel.weekendRatesForRegular;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                    cost += weekendRate;
                else
                    cost += weekdayRate;
            }
            return cost;
        }
        /// <summary>
        /// Creating method for find the cheapest Hotel for given Date Range. 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Hotel FindCheapestHotel(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                Console.WriteLine("Error! StartDate greater than EndDate");
            }

            var cost = Int32.MaxValue;
            Hotel lowBudgetHotel = new Hotel();
            foreach (var hotel in hotelRecords)
            {
                var temp = cost;
                cost = Math.Min(cost, CalculateCost(hotel.Value, startDate, endDate));
                if (temp != cost)
                    lowBudgetHotel = hotel.Value;
            }
            return lowBudgetHotel;
        }
        /// <summary>
        /// Creating method for Find Cheapest hotel based on weekday and weekrates.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public List<Hotel> FindCheapestHotels(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                Console.WriteLine("Start date cannot be greater than end date");
                return null;
            }
            var cost = Int32.MaxValue;
            var cheapestHotels = new List<Hotel>();
            foreach (var hotel in hotelRecords)
            {
                var temp = cost;
                cost = Math.Min(cost, CalculateCost(hotel.Value, startDate, endDate));

            }
            foreach (var hotel in hotelRecords)
            {
                if (CalculateCost(hotel.Value, startDate, endDate) == cost)
                    cheapestHotels.Add(hotel.Value);
            }
            return cheapestHotels;
        }
    }
}
