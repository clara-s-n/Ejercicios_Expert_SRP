using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        /*La responsabilidad de esta clase es la de crear un doctor, almacenar los
        datos del doctor (nombre, apellido, id, especialidad) y validarlos con
        DoctorValidation.*/

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        public string Speciality { get; set; }

        public Doctor(string name, string lastName, string id, string speciality)
        {
            Name = name;
            LastName = lastName;
            Id = id;
            Speciality = speciality;
        }

        public override string ToString()
        {
            //Devuelve los datos del doctor
            return $"Nombre: {Name} {LastName}\nCédula: {Id}\nEspecialidad: {Speciality}";
        }

        public static bool ValidateDoctor(Doctor doctor)
        {
            if (DoctorValidation.ValidateName(doctor.Name) && DoctorValidation.ValidateLastName(doctor.LastName) && DoctorValidation.ValidateId(doctor.Id) && DoctorValidation.ValidateSpeciality(doctor.Speciality))
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