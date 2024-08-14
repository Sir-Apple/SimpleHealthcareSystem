using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareSystem
{
    public class Doctor : Person
    {
        public string DoctorId { get; private set; }
        public string Specialization { get; private set; }

        public Doctor(string name, int age, string doctorId, string specialization)
            : base(name, age)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public override void DisplayInfo() // Polymorphism
        {
            Console.WriteLine($"Doctor: {Name}, Age: {Age}, Specialization: {Specialization}");
        }
    }
}
