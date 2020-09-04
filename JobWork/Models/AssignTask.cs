using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobWork.Models
{

    public class AssignTask
    {
        [Key]
        public int TaskId { get; set; }
        [Required]

        public string TaskName { get; set; }

    }
}