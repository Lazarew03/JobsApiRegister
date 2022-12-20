using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using JobsApiRegister;

namespace JobsApiRegister
{
    public class JobsTitle
    {
        public JobsTitle(int id, string name)
        {
            Id = id;
            Name = name;
        }

       public JobsTitle() { }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
