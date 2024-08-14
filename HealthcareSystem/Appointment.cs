using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareSystem
{
    public class Appointment
    {
        public Patient Patient { get; private set; }
        public Doctor Doctor { get; private set; }
        public DateTime AppointmentDate { get; private set; }

        public Appointment(Patient patient, Doctor doctor, DateTime appointmentDate)
        {
            Patient = patient;
            Doctor = doctor;
            AppointmentDate = appointmentDate;
        }

        public void DisplayAppointmentDetails()
        {
            Console.WriteLine($"Appointment Details:\nPatient: {Patient.Name}\nDoctor: {Doctor.Name}\nDate: {AppointmentDate}");
        }
    }
}
