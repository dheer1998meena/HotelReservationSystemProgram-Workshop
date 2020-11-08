using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystemProblem_Workshop
{
    public class HotelReservationCalculations
    {
        public enum CustomerType { Regular, Reward };
        public static CustomerType GetCustomerType(CustomerType customer)
        {
            Console.Write("Enter the type of Customer : ");
            var cusType = Console.ReadLine().ToLower();
            if (cusType != "regular" && cusType != "reward")
                throw new HotelException(HotelException.ExceptionType.INVALID_CUSTOMER_TYPE, "Invalid Customer Type Entered");
            return cusType == "regular" ? CustomerType.Regular : CustomerType.Reward;
        }
    }
}
