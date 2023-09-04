using System;
using System.Text;

namespace Library
{
    public class AppointmentValidation
    {
        /*La responsabilidad de esta clase es la de validar los datos de la cita,
        recibe datos de Patient y Doctor con la validación de los mismos.*/

        public static bool ValidateDate(DateTime date)
        {
            return date > DateTime.Now;
        }
        public static bool ValidateTime(DateTime time)
        {
            return time > DateTime.Now;
        }

        public static bool ValidateAppointment(Appointment appointment)
        {
            if (ValidateDate(appointment.Date) && ValidateTime(appointment.Time) && PatientValidation.ValidatePatient(appointment.Patient) && DoctorValidation.ValidateDoctor(appointment.Doctor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}