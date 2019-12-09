using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Acme.SimpleTaskApp.Customers
{
    [Table("Customer")]
    public class Customer : Entity, IHasCreationTime
    {
        public const int MaxLength = 256;

        [Required]
        [StringLength(MaxLength)]
        public string Name{ get; set; }


        public DateTime CreationTime { get; set; }

        public string Area { get; set; }


        public Customer()
        {
            CreationTime = Clock.Now;
        }

        public Customer(string name)
            : this()
        {
            Name = name;
        }
    }

}