using System;

namespace SecondAssembly
{
    public class Teacher
    {

        public int Experience { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetTeacherName (string firstName, string lastName)
        {
            try
            {
                int i = 5;
                int infinity = i / 0;

            }
            catch (Exception ex)
            {
                throw;
            }
            return firstName + lastName;
        }
    }
}
