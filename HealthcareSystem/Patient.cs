using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareSystem
{
    public class Patient : Person
    {
        public string PatientId { get; private set; }
        public string MedicalHistory { get; private set; }

        public Patient(string name, int age, string patientId, string medicalHistory)
            : base(name, age)
        {
            PatientId = patientId;
            MedicalHistory = medicalHistory;
        }

        public override void DisplayInfo() // Polymorphism
        {
            Console.WriteLine($"Patient: {Name}, Age: {Age}, ID: {PatientId}");
        }
    }
}
