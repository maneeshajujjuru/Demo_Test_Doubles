using Demo_Test_Doubles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Test_Doubles_Fake_Test
{
    public class Fakeclass : IAge
    {
        public string Get(int age)
        {
            if (age < 18 )
                return "Minor Age";
            else
                return "Major Age";
        }
    }
}
