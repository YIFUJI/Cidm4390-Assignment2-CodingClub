using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    public class Project
    {
        [Key]
        public string ProjectID { get; set; } 

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        [Display(Name = "Project Leader")]
        public bool TeamLeader { get; set; }
        public bool Completed { get; set; } = false;    
        public decimal Price { get; set; }
        public ICollection<ProjectRoster> Personsinfo { get; set; }

    }
}