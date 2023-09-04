using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea un paciente, un doctor y una cita
            Patient patient = new Patient("Juan", "Perez", "3.312.475-0", 45, "099547654");
            Doctor doctor = new Doctor("Pedro", "Gomez", "5.483.596-8", "Medico general");
            try
            {
                Service.ScheduleAppointment(patient, doctor, new DateTime(2023, 10, 10), new DateTime(2023, 10, 10, 10, 15, 30));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}