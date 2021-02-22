using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// First Name, Last name , Email and Cell Phone of each Person
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhone { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName, string email, string cellPhone)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            CellPhone = cellPhone;
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            
        }

    }

    
}
