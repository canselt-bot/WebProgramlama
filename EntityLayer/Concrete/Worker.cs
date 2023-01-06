using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Worker
    {
        [Key]

        public int WorkerID { get; set; }

        public string? WorkerName { get; set; }

        public string? WorkerAbout { get; set; }

        public string? WorkerMail { get; set; }

        public string WorkerPassword { get; set; }

        public bool WorkerStatus { get; set;}
    }
}
