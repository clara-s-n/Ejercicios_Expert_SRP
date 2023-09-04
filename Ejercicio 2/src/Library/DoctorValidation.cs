using System;
using System.Text;

namespace Library
{
    public class DoctorValidation
    {   /*La responsabilidad de esta clase es la de validar los datos del paciente.
        Debe validar que el nombre, apellido, id, edad y número de teléfono sean
        correctos. Los datos son proporcionados por Doctor*/
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
        public static bool ValidateSpeciality(string speciality)
        {
            if (string.IsNullOrEmpty(speciality))
            {
                throw new Exception("La especialidad no puede estar vacía");
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateDoctor(Doctor doctor)
        {
            if (ValidateName(doctor.Name) && ValidateLastName(doctor.LastName) && ValidateId(doctor.Id) && ValidateSpeciality(doctor.Speciality))
            {
                return true;
            }
            else
            {
                throw new Exception("Los datos del doctor no son válidos");
            }
        }
    }
}