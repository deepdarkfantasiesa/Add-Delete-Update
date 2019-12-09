using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Acme.SimpleTaskApp.Workers
{
    [Table("HouseWorker")]
    public class HouseWorker : Entity, IHasCreationTime
    {
        public const int MaxLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [StringLength(MaxLength)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Type { get; set; }

        public string WorkArea { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public string Tel { get; set; }

        public DateTime CreationTime { get; set; }

        [Required]
        [StringLength(MaxLength)]
        public string IDCard { get; set; }

        public HouseWorker()
        {
            CreationTime = Clock.Now;
        }

        public HouseWorker(string name, 
            int age,  
            int type, 
            string tel, 
            string desc, 
            string area)
            : this()
        {
            Name = name;
            Description = desc;
            Age = age;
            Type = type;
            Tel = tel;
            WorkArea = area;

        }
    }

}