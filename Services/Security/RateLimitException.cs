using System;

namespace PL_VehicleRental.Services.Security
{
    public class RateLimitException : Exception
    {
        public RateLimitException(string message) : base(message) { }
    }
}
