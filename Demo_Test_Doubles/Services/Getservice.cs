using Demo_Test_Doubles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Test_Doubles.Services
{
    public class Getservice : IAge
    {
        public string Get(int age)
        {
            if (age > 0)
            {
                if (age <= 18)
                {
                    return "Minor Age";
                }
                else if (age > 18 && age <= 60)
                {
                    return "Adult";
                }
                else
                {
                    return "Senior Citizen";
                }

            }
            else
            {
                return "Age cannot be negative";
            }
        }
    }
}
