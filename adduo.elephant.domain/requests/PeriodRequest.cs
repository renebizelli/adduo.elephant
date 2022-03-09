using Microsoft.AspNetCore.Mvc;
using System;

namespace adduo.elephant.domain.requests
{
    [BindProperties]
    public class PeriodRequest
    {
        public int Year { get; set; }
        public int Month { get; set; }

        public bool Validate()
        {
            
            return Year > 0 && (Month >= 1 && Month <= 12);
        }

        public void ThrowIfInvalid()
        {
            if(!Validate())
            {
                throw new ArgumentException($"Invalid period: {Year}/{Month}");
            }
        }
    }
}
