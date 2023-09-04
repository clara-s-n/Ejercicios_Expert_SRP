using System;
using System.Text;

namespace Library
{
    public class Service
    {
        /*La responsabilidad de esta clase es la de coordinar la programación de una
        cita médica, con las clases Patient, Doctor y Appointment, también la
        muestra en consola*/

        public static void ScheduleAppointment(Patient patient, Doctor doctor, DateTime date, DateTime time)
        {
            Appointment appointment = new Appointment(date, time, patient, doctor, Guid.NewGuid().ToString());
            if (AppointmentValidation.ValidateAppointment(appointment))
            {
                Console.WriteLine($"Fecha de hoy: {DateTime.Now}");
                Console.WriteLine("\nCita creada con éxito\n");
                Console.WriteLine(appointment);
            }
            else
            {
                throw new Exception("No fue posible crear la cita");
            }
        }

    }

}