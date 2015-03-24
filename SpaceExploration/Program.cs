using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceExploration
{

    // Firing rocket boosters 30 seconds increases velocity 5%
    // What is velocity after firing for 5 minutes if start speed is 10000 mph
    // What is velocity after 2 hours of 5 minute burns separated by 10 minute coasts
    class Program
    {
        static void Main(string[] args)
        {
            // stating speed is 10000mph
            float currentSpeed = 10000.0f;

            // 2 hours is 8 burn/coast intervals
            for (int j = 0; j < 8; j++)
            {

                // 5 minutes is 10 30 second increments
                for (int i = 0; i < 10; i++)
                {
                    currentSpeed = currentSpeed * 1.05f;
                }

                // answer the first question on the first iteration
                if (j == 0)
                {
                    Console.WriteLine("Velocity after first burn is: " + currentSpeed + " MPH"); 
                }

            }

            Console.WriteLine("After 2 hours the velocity is: " + currentSpeed + " MPH");
            Console.ReadLine();
        
            
        }
    }
}
