using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomersClassLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
