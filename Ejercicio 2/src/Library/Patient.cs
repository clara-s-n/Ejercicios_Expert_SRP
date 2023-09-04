using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        /*La responsabilidad de esta clase es la de crear un paciente, almacenar los
        datos del paciente (nombre, apellido, id, edad, número de teléfono) y 
        validarlos con PatientValidation.*/

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public Patient(string name, string lastName, string id, int age, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            Id = id;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            //Devuelve los datos del paciente
            return $"Nombre: {Name} {LastName}\nCédula: {Id}\nEdad: {Age}\nTeléfono: {PhoneNumber}";
        }

        public static bool ValidatePatient(Patient patient)
        {
            if (PatientValidation.ValidateName(patient.Name) && PatientValidation.ValidateLastName(patient.LastName) && PatientValidation.ValidateId(patient.Id) && PatientValidation.ValidateAge(patient.Age) && PatientValidation.ValidatePhoneNumber(patient.PhoneNumber))
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