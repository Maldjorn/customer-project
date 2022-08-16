using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersClassLibrary
{
    public abstract class Person
    {
        
        private string firstName;
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "String should be less than 50 char")]
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {

                firstName = value;
            }
        }
        
        private string secondName;
        [StringLength(50)]
        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
            }
        }

    }
}
