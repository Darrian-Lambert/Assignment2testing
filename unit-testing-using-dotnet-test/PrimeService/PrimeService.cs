using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false; //not prime
            } else if (candidate == 2) { //two is prime
                return true; //prime
            } else {
                double checkLength = Math.Sqrt(candidate); //no need to continue checking after the square root

                for (int i = 2; i <= checkLength; i++) {
                    if (candidate % i == 0) {
                        return false; //not prime
                    }
                }

                return true; //prime
            }
        }
    }
}