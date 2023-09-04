using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        /*La responsabilidad de esta clase es la de crear una cita, almacenar los 
        datos de la cita (fecha, hora, paciente, doctor, identificador, lugar) y validarla
        (con AppointmentValidation), debe utilizar los datos obtenidos de Patient 
        y Doctor.*/

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Id { get; set; }
        public string Place { get; set; }
        public Appointment(DateTime date, DateTime time, Patient patient, Doctor doctor, string id, string place)
        {
            Date = date;
            Time = time;
            Patient = patient;
            Doctor = doctor;
            Id = id;
            //Esta ID es un identificador único que se genera automáticamente
            Place = place;
        }

        public override string ToString()
        {
            return $"Fecha: {Date}\nHora: {Time}\nLugar: {Place}\n\nNombre del paciente: {Patient.Name} {Patient.LastName}\nId del paciente: {Patient.Id}\nEdad del paciente: {Patient.Age}\n\nNombre del doctor: {Doctor.Name} {Doctor.LastName}\nEspecialidad: {Doctor.Speciality} \n\nIdentificador: {Id}";
        }

        public static bool ValidateAppointment(Appointment appointment)
        {
            if (appointment.Date > DateTime.Now)
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