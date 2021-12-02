using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Annotations
{
    class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class validation");
            Console.WriteLine("-------------------------------\n");
            Employee objemployee = new Employee();
            objemployee.Name = "Anirudh";
            objemployee.Age = 23;
            objemployee.PhoneNumber = "7905142214";
            objemployee.EmailAddress = "anirudhanand984@gmail.com";
            ValidationContext context = new ValidationContext(objemployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objemployee, context, results, true);
            if (!valid)
            {
                foreach(ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objemployee.Name + "\n" + "Age: " + objemployee.Age + "\n" + "PhoneNumber: " + objemployee.PhoneNumber + "\n" + "EmailAddress: " + objemployee.EmailAddress);
            }
            Console.WriteLine("\nPress any Key to exit");
            
         
        }
    }
}
