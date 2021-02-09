using Demo_Test_Doubles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Test_Doubles_Stub_Test
{
    public class StubClass : IAge
    {
        public string Get(int age)
        {
            return "Minor Age";
        }

    }
}
