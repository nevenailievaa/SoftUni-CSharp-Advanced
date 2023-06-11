using System.Globalization;
using System.Text;

namespace SoftUniKindergarten
{
    public class Child
    {
        //Constructor
        public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParentName = parentName;
            ContactNumber = contactNumber;
        }

        //Properties
        public string FirstName {get; set;}
        public string LastName {get; set; }
        public int Age {get; set; }
        public string ParentName {get; set; }
        public string ContactNumber {get; set; }

        //Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Child: {this.FirstName} {this.LastName}, Age: {this.Age}, Contact info: {this.ParentName} - {this.ContactNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
