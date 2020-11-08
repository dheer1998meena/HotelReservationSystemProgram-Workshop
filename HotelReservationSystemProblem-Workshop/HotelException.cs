using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem_Workshop
{
    public class HotelException : Exception
    {
        /// <summary>
        /// Exception types
        /// </summary>
        public enum ExceptionType
        {
            INVALID_DATE,
            INVALID_CUSTOMER_TYPE,
            INVALID_HOTEL_TYPE
        }

        ExceptionType type;


        /// <summary>
        /// Constructor of custom exception inheriting from Exception class
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public HotelException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
