﻿namespace Net.Petricevic.Learnings.CSharp.MVCDemo.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; } = true;
    }
}