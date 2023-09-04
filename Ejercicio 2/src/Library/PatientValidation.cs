using System;
using System.Text;

namespace Library
{
    public class PatientValidation
    {
        /*La responsabilidad de esta clase es la de validar los datos del paciente.
        Debe validar que el nombre, apellido, id, edad y número de teléfono sean
        correctos. Los datos son proporcionados por Patient*/

        public static bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("El nombre no puede estar vacío");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new Exception("El apellido no puede estar vacío");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateId(string id)
        {
            if (IdValidation.IdIsValid(id))
            {
                return true;
            }
            else
            {
                throw new Exception("El número de cédula ingresado no es válido");
            }
        }

        public static bool ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("La edad no puede ser menor a 0");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length < 9 || phoneNumber.Length > 9)
            {
                throw new Exception("El número de teléfono ingrsado no es válido");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidatePatient(Patient patient)
        {
            if (ValidateName(patient.Name) && ValidateLastName(patient.LastName) && ValidateId(patient.Id) && ValidateAge(patient.Age) && ValidatePhoneNumber(patient.PhoneNumber))
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