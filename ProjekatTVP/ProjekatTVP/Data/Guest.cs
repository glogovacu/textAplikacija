using System;

namespace ProjekatTVP
{
    public class Guest
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _phone;

        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public override string ToString()
        {
            return "ID:|" + _id + "|First Name:|" + _firstName + "|Last name:|" + _lastName + "|Date of birth:|" + _dateOfBirth.Day + "." + _dateOfBirth.Month + "." + _dateOfBirth.Year + "|Phone:|" + _phone;
        }
    }
}
