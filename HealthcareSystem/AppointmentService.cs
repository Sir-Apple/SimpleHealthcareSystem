using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareSystem
{
    public class AppointmentService
    {
        private List<Appointment> appointments = new List<Appointment>();

        public void ScheduleAppointment(Patient patient, Doctor doctor, DateTime appointmentDate)
        {
            var appointment = new Appointment(patient, doctor, appointmentDate);
            appointments.Add(appointment);
            Console.WriteLine("Appointment scheduled successfully.");
        }

        public void ShowAppointments()
        {
            Console.WriteLine("All Appointments:");
            foreach (var appointment in appointments)
            {
                appointment.DisplayAppointmentDetails();
                Console.WriteLine();
            }
        }
    }
}
