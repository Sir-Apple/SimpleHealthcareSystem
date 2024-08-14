using System;

namespace HealthcareSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new Patient("John Doe", 30, "P001", "No known allergies");
            var doctor = new Doctor("Dr. Smith", 45, "D001", "Cardiology");

            var appointmentService = new AppointmentService();
            appointmentService.ScheduleAppointment(patient, doctor, DateTime.Now.AddDays(3));

            appointmentService.ShowAppointments();
        }
    }
}
