using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace JobsApiRegister
{
    public class Jobs 
    {
        public Jobs(int id, string firstName, string name, string middleName, decimal salary, DateTime dateOfBirth,  JobsTitle jobsTitle)
        {
            Id = id;
            FirstName = firstName;
            Name = name;
            MiddleName = middleName;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            JobsTitle = jobsTitle;
        }
        public Jobs() 
        { 


        }   
       

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public JobsTitle JobsTitle { get; set; }
    }
}

