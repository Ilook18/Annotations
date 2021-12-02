using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Annotations
{
    class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18,99,ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

    }
}
