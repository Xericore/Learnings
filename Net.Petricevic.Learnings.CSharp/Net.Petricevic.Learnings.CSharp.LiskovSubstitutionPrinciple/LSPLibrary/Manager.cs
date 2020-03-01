﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Petricevic.Learnings.CSharp.LiskovSubstitutionPrinciple.LSPLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
