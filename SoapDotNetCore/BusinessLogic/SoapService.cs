﻿namespace SoapDotNetCore.BusinessLogic
{
    public class SoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of two number is: {num1 + num2}";
        }
    }
}
