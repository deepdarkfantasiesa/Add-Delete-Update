using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Acme.SimpleTaskApp.Workers
{
    [Table("Certificate")]
    public class Certificate : Entity, IHasCreationTime
    {
        public const int MaxLength = 256;

        [Required]
        [StringLength(MaxLength)]
        public string Certification { get; set; }


        public DateTime CreationTime { get; set; }


        [ForeignKey(nameof(WorkerID))]
        public HouseWorker Worker { get; set; }
        public int WorkerID { get; set; }


        public Certificate()
        {
            CreationTime = Clock.Now;
        }

        public Certificate(string cert, int workerid)
            : this()
        {
            Certification = cert;
            CreationTime = Clock.Now;
            WorkerID = workerid;
        }
    }

}